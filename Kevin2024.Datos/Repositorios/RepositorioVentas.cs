using Dapper;
using Kevin2024.Datos.Interfaces;
using Kevin2024.Entidades;
using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using System.Data.SqlClient;

namespace Kevin2024.Datos.Repositorios
{
    public class RepositorioVentas : IRepositorioVentas
    {
        public void Agregar(SqlConnection conn, Venta venta, SqlTransaction tran)
        {
            string insertQuery = @"INSERT INTO Ventas 
                (ClienteId, FechaVenta, Regalo, Total, TipoOrdenId, EstadoPagoId ) 
                VALUES (@ClienteId, @FechaVenta, @Regalo, @Total, @TipoVentaId, @EstadoPagoId); 
                SELECT CAST(SCOPE_IDENTITY() as int)";

            int primaryKey = conn.QuerySingle<int>(insertQuery, venta, tran);
            if (primaryKey > 0)
            {
                venta.VentaId = primaryKey;
                return;
            }
            throw new Exception("No se pudo agregar la Venta");
        }

        public void Borrar(SqlConnection conn, int ventaId, SqlTransaction tran)
        {
            string deleteQuery = @"DELETE FROM Ventas WHERE VentaId = @VentaId";
            int registrosAfectados = conn.Execute(deleteQuery, new { ventaId }, tran);
            if(registrosAfectados == 0)
            {
                throw new Exception("No se pudo eliminar la venta");
            }
        }

        public int GetCantidad(SqlConnection conn, Func<VentaListDto, bool>? filter)
        {
            string selectQuery = @"SELECT v.VentaId, 
                                COALESCE(v.ClienteId, 999999) AS ClienteId, 
                                v.FechaVenta, v.Regalo, v.Total, v.TipoVenta,
                                COALESCE(c.Nombre + ' ' + c.Apellido, 'Consumidor Final') AS Cliente
                                    FROM Ventas v
                                    LEFT JOIN Clientes c on c.ClienteId = v.ClienteId 
                                    ORDER BY v.VentaId";
            var listaVentas = conn.Query<VentaListDto>(selectQuery).ToList();
            if(filter != null)
            {
                listaVentas = listaVentas.Where(filter).ToList();
            }
            return listaVentas.Count;
        }

        public List<VentaListDto>? GetLista(SqlConnection conn, int currentPage, int pageSize, Orden orden, Func<VentaListDto, bool>? filter)
        {
            var listaVenta = new List<VentaListDto>();
            var finalQuery = string.Empty;
            var ordenQuery = string.Empty;
            var conditions = string.Empty;
            string selectQuery = @"SELECT v.VentaId, 
                                COALESCE(v.ClienteId, 999999) AS ClienteId, 
                                v.FechaVenta, v.Regalo, v.Total, v.Estado, v.TipoVenta,
                                COALESCE(c.Nombre + ' ' + c.Apellido, 'Consumidor Final') AS Cliente
                                    FROM Ventas v
                                    LEFT JOIN Clientes c on c.ClienteId = v.ClienteId";
            if (orden == Orden.Ninguno)
            {
                ordenQuery = @" ORDER BY v.VentaId";
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
            var listaVentas = conn.Query<VentaListDto>(finalQuery).ToList();
            if (filter != null)
            {
                listaVentas = listaVentas.Where(filter).ToList();
            }
            return listaVentas.Skip((currentPage-1)*pageSize).Take(pageSize).ToList();
        }

        public int GetPaginaPorRegistro(SqlConnection conn, string nombre, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Venta? GetVentaPorId(SqlConnection conn, int ventaId)
        {
            var selectQuery = @"SELECT
				v.VentaId,
				COALESCE(v.ClienteId,999999) AS ClienteId,
				v.FechaVenta,
				v.Regalo,
				v.Total,
				v.Estado,
				COALESCE(v.ClienteId,999999) AS ClienteId,
				COALESCE(c.Nombre,'Consumidor') as Nombres,
				COALESCE(c.Apellido,'Final') as Apellido,
				dv.DetalleVentaId,
				dv.VentaId,
				dv.ProductoId,
				dv.ComboId,
				dv.Cantidad,
				dv.Precio,
				p.ProductoId,
				p.Nombre AS Nombre,
				co.ComboId,
				co.Nombre As Nombre
				FROM Ventas v LEFT JOIN Clientes c ON v.ClienteId=c.ClienteId
				INNER JOIN DetallesVentas dv ON v.VentaId=dv.VentaId
				LEFT JOIN Productos p ON dv.ProductoId=p.ProductoId
				LEFT JOIN Combos co ON co.ComboId=dv.ComboId
				WHERE v.VentaId=@VentaId";
            var ventasDictionary = new Dictionary<int, Venta>();
            var resultado = conn.Query<Venta, Cliente, DetalleVenta, Productos, Combo, Venta>(selectQuery,
                (venta, cliente, detalle, producto, combo) =>
                {
                    if (!ventasDictionary.TryGetValue(venta.VentaId, out var ventaEntry))
                    {
                        ventaEntry = venta;
                        venta.Cliente = cliente;
                        venta.Detalles = new List<DetalleVenta>();
                        ventasDictionary.Add(venta.VentaId, ventaEntry);
                    }
                    detalle.Productos = producto;
                    detalle.Combo = combo;
                    ventaEntry.Detalles.Add(detalle);
                    return ventaEntry;

                },
                    new { @VentaId = ventaId },
                    splitOn: "ClienteId,DetalleVentaId,ProductoId,ComboId"
                ).FirstOrDefault();

            return ventasDictionary.Values.FirstOrDefault();
        }
    }
}
