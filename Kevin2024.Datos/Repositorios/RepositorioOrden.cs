using Dapper;
using Kevin2024.Datos.Interfaces;
using Kevin2024.Entidades;
using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using System.Data.SqlClient;

namespace Kevin2024.Datos.Repositorios
{
    public class RepositorioOrden : IRepositorioOrden
    {
        public void Agregar(SqlConnection conn, OrdenPedido orden, SqlTransaction tran)
        {
            string insertQuery = @"INSERT INTO Orden 
                (ClienteId, Fechaorden, Regalo, Total, EstadoOrdenId, TipoOrdenId, EstadoPagoId) 
                 VALUES 
               (@ClienteId, @Fechaorden, @Regalo, @Total, @EstadoOrdenId, @TipoOrdenId, @EstadoPagoId); 
                SELECT CAST(SCOPE_IDENTITY() as int)";

            int primaryKey = conn.QuerySingle<int>(insertQuery, orden, tran) ;
            if (primaryKey > 0)
            {
                orden.OrdenId = primaryKey;
                return;
            }
            throw new Exception("No se pudo agregar la orden");
        }

        public void Borrar(SqlConnection conn, int ordenId, SqlTransaction tran)
        {
            string deleteQuery = @"DELETE FROM Orden WHERE OrdenId = @OrdenId";
            int registrosAfectados = conn.Execute(deleteQuery, new { ordenId }, tran);
            if (registrosAfectados == 0)
            {
                throw new Exception("No se pudo eliminar la orden");
            }
        }

        public void CancelarOrden(SqlConnection conn, int ordenId, SqlTransaction tran)
        {
            string InsertQuery = @"UPDATE Orden SET EstadoOrdenId = 1 Where OrdenId = @ordenId";
            int registrosAfectados = conn.Execute(InsertQuery, new { ordenId }, tran);
            if(registrosAfectados == 0)
            {
                throw new Exception("No se pudo cancelar la órden");
            }
        }

        public void Editar(SqlConnection conn, OrdenPedido orden, SqlTransaction tran)
        {
            string updateQuery = @"UPDATE Orden SET EstadoPagoId = 1 WHERE OrdenId = @OrdenId";
            int registrosAfectados = conn.Execute(updateQuery, orden,  tran);
            if (registrosAfectados == 0)
            {
                throw new Exception("No se pudo cambiar el estado de pago");
            }
        }

        public int GetCantidad(SqlConnection conn, Func<OrdenListDto, bool>? filter)
        {
            string selectQuery = @"SELECT o.ordenId, 
                                COALESCE(o.ClienteId, 999999) AS ClienteId, 
                                o.FechaOrden, o.Regalo, o.Total, o.TipoOrdenId,
                                COALESCE(c.Nombre + ' ' + c.Apellido, 'Consumidor Final') AS Cliente,
                                o.EstadoOrdenId
                                    FROM orden o
                                    LEFT JOIN Clientes c on c.ClienteId = o.ClienteId 
                                    ORDER BY o.ordenId";
            var listaordens = conn.Query<OrdenListDto>(selectQuery).ToList();
            if (filter != null)
            {
                listaordens = listaordens.Where(filter).ToList();
            }
            return listaordens.Count;
        }

        public List<OrdenListDto>? GetLista(SqlConnection conn, int currentPage, int pageSize, Orden orden, Func<OrdenListDto, bool>? filter)
        {
            var listaorden = new List<OrdenListDto>();
            var finalQuery = string.Empty;
            var ordenQuery = string.Empty;
            var conditions = string.Empty;
            string selectQuery = @"SELECT o.ordenId, 
                                    COALESCE(o.ClienteId, 999999) AS ClienteId, 
                                    o.Fechaorden, o.Regalo, o.Total, 
                                    COALESCE(c.Nombre + ' ' + c.Apellido, 'Consumidor Final') AS Cliente,
								    tp.TipoOrdenId, tp.Descripcion AS TipoDeOrden,
								    eo.EstadoOrdenId, eo.Descripcion AS EstadoOrden,
                                    ep.EstadopagoId, ep.Descripcion AS EstadoPago
                                   FROM orden o
                                    LEFT JOIN Clientes c on c.ClienteId = o.ClienteId
									INNER JOIN TiposDeOrden tp on tp.TipoOrdenId = o.TipoOrdenId
									INNER JOIN EstadoOrden eo on eo.EstadoOrdenId = o.EstadoOrdenId
                                    INNER JOIN EstadoPagos ep on ep.EstadoPagoId = o.EstadoPagoId";
            if (orden == Orden.Ninguno)
            {
                ordenQuery = @" ORDER BY o.ordenId Desc";
            }
            if (orden == Orden.OrdenAZ)
            {
                ordenQuery = @" ORDER BY Cliente";
            }
            if (orden == Orden.OrdenZA)
            {
                ordenQuery = @" ORDER BY Cliente Desc";
            }
            finalQuery = string.Concat(selectQuery, conditions, ordenQuery);
            var listaordens = conn.Query<OrdenListDto>(finalQuery).ToList();
            if (filter != null)
            {
                listaordens = listaordens.Where(filter).ToList();
            }
            return listaordens.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
        }


        public OrdenPedido? GetOrdenPorId(SqlConnection conn, int ordenId)
        {
            var selectQuery = @"SELECT
				o.ordenId,
				COALESCE(o.ClienteId,999999) AS ClienteId,
				o.Fechaorden,
				o.Regalo,
				o.Total,
				COALESCE(o.ClienteId,999999) AS ClienteId,
				COALESCE(c.Nombre,'Consumidor') as Nombres,
				COALESCE(c.Apellido,'Final') as Apellido,
				
				do.DetalleordenId,
				do.ordenId,
				do.ProductoId,
				do.ComboId,
				do.Cantidad,
				do.Precio,
				p.ProductoId,
				p.Nombre AS Nombre,
				co.ComboId,
				co.Nombre As Nombre,

				tp.TipoOrdenId,
				tp.Descripcion,

				ep.EstadoPagoId,
				ep.Descripcion
				FROM orden o 
				LEFT JOIN Clientes c ON o.ClienteId=c.ClienteId
				INNER JOIN DetalleOrden do ON o.ordenId=do.ordenId
				LEFT JOIN Productos p ON do.ProductoId=p.ProductoId
				LEFT JOIN Combos co ON co.ComboId=do.ComboId
				INNER JOIN TiposDeOrden tp on o.TipoOrdenId = tp.TipoOrdenId
				INNER JOIN EstadoPagos ep on ep.EstadoPagoId = o.EstadoPagoId
				WHERE o.ordenId=@ordenId";
            var ordenDictionary = new Dictionary<int, OrdenPedido>();
            var resultado = conn.Query<OrdenPedido, Cliente, DetalleOrden, Productos, Combo, TipoOrden, EstadoPago, OrdenPedido>(selectQuery,
                (orden, cliente, detalle, producto, combo, tipoOrden, estadoPago) =>
                {
                    if (!ordenDictionary.TryGetValue(orden.OrdenId, out var ordenEntry))
                    {
                        ordenEntry = orden;
                        orden.Cliente = cliente;
                        orden.Detalles = new List<DetalleOrden>();
                        orden.TipoOrden = tipoOrden;
                        orden.EstadoPago = estadoPago;
                        ordenDictionary.Add(orden.OrdenId, ordenEntry);
                    }
                    detalle.Productos = producto;
                    detalle.Combo = combo;
                    ordenEntry.Detalles.Add(detalle);
                    return ordenEntry;

                },
                    new { @ordenId = ordenId },
                    splitOn: "ClienteId,DetalleordenId,ProductoId,ComboId,TipoOrdenId,EstadoPagoId"
                ).FirstOrDefault();

            return ordenDictionary.Values.FirstOrDefault();
        }

        public void OrdenCompletada(SqlConnection conn, int ordenId, SqlTransaction tran)
        {
            string InsertQuery = @"UPDATE Orden SET EstadoOrdenId = 4 Where OrdenId = @ordenId";
            int registrosAfectados = conn.Execute(InsertQuery, new { ordenId }, tran);
            if (registrosAfectados == 0)
            {
                throw new Exception("No se pudo cambiar el estado de la órden");
            }
        }

        public void OrdenEnviada(SqlConnection conn, int ordenId, SqlTransaction tran)
        {
            string InsertQuery = @"UPDATE Orden SET EstadoOrdenId = 3 Where OrdenId = @ordenId";
            int registrosAfectados = conn.Execute(InsertQuery, new { ordenId }, tran);
            if (registrosAfectados == 0)
            {
                throw new Exception("No se pudo cambiar el estado de la órden");
            }
        }

        public void OrdenPendiente(SqlConnection conn, int ordenId, SqlTransaction tran)
        {
            string InsertQuery = @"UPDATE Orden SET EstadoOrdenId = 2 Where OrdenId = @ordenId";
            int registrosAfectados = conn.Execute(InsertQuery, new { ordenId }, tran);
            if (registrosAfectados == 0)
            {
                throw new Exception("No se pudo cambiar el estado de la órden");
            }
        }
    }
}
