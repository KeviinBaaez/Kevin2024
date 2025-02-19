using Dapper;
using Kevin2024.Datos.Interfaces;
using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Kevin2024.Datos.Repositorios
{
    public class RepositorioClientes : IRepositorioClientes
    {
        public void Agregar(Cliente cliente, SqlConnection conn, SqlTransaction tran)
        {
            string insertQuery = @"INSERT INTO Clientes 
                (Nombre, Apellido, Documento) 
                VALUES (@Nombres, @Apellido, @Documento); 
                SELECT CAST(SCOPE_IDENTITY() as int)";

            int primaryKey = conn.QuerySingle<int>(insertQuery, cliente, tran);
            if (primaryKey > 0)
            {
                cliente.ClienteId = primaryKey;
                return;
            }
            throw new Exception("No se pudo agregar el cliente");
        }

        public void Borrar(int clienteId, SqlConnection conn, SqlTransaction tran)
        {
            var deleteQuery = @"DELETE FROM Clientes 
                                    WHERE ClienteId=@ClienteId";
            int registrosAfectados = conn
                .Execute(deleteQuery, new { clienteId }, tran);
            if (registrosAfectados == 0)
            {
                throw new Exception("No se pudo borrar el cliente");
            }
        }

        public void Editar(Cliente cliente, SqlConnection conn, SqlTransaction tran)
        {
            var updateQuery = @"UPDATE Clientes SET Documento=@Documento,
                                    Apellido=@Apellido, Nombre=@Nombres
                                WHERE ClienteId=@ClienteId";
            int registrosAfectados = conn.Execute(updateQuery, cliente, tran);
            if (registrosAfectados == 0)
            {
                throw new Exception("No se pudo editar el cliente");
            }
        }

        public bool Existe(Cliente cliente, SqlConnection conn)
        {
            try
            {
                string selectQuery = @"SELECT COUNT(*) FROM Clientes ";
                string finalQuery = string.Empty;
                string conditional = string.Empty;
                if (cliente.ClienteId == 0)
                {
                    conditional = "WHERE Documento = @Documento";
                }
                else
                {
                    conditional = @"WHERE Documento = @Documento
                            AND ClienteId<>@ClienteId";
                }
                finalQuery = string.Concat(selectQuery, conditional);
                return conn.QuerySingle<int>(finalQuery, cliente) > 0;

            }
            catch (Exception)
            {

                throw new Exception("No se pudo comprobar si existe el cliente");
            }
        }

        public int GetCantidad(SqlConnection conn, Func<ClienteListDto, bool>? filter, TiposDeDatos? generoFiltro)
        {
            var selectQuery = "SELECT COUNT(*) FROM Clientes";
            List<string> conditions = new List<string>();

            return conn.ExecuteScalar<int>(selectQuery);
        }

        public Cliente? GetClientePorId(int clienteId, SqlConnection conn)
        {
            string selectQuery = @"SELECT ClienteId, Documento, Nombre AS Nombres, Apellido 
                                FROM Clientes WHERE ClienteId=@ClienteId";
            var cliente = conn.QuerySingleOrDefault<Cliente>(selectQuery, new { @ClienteId = clienteId });

            if (cliente == null)
            {
                return null;
            }
            return cliente;
        }

        public List<Cliente> GetClientes(SqlConnection conn)
        {
            var selectQuery = @"SELECT 
                c.ClienteId, 
                c.Documento, 
                c.Apellido,
                c.Nombres
            FROM Clientes c
            ORDER BY c.Apellido, c.Nombres";
            return conn.Query<Cliente>(selectQuery).ToList();
        }

        public ClienteDetalleDto? GetDetalleCliente(int clienteId, SqlConnection conn)
        {
            string selectQuery = @"SELECT ClienteId, Documento, Nombres, Apellido 
                FROM Clientes 
                WHERE ClienteId=@ClienteId";
            var cliente = conn.QuerySingleOrDefault<ClienteDetalleDto>(selectQuery, new { @ClienteId = clienteId });

            // Si el cliente no existe, retornamos null
            if (cliente == null)
            {
                return null;
            }
            string direccionesQuery = @"SELECT d.DireccionId,
                                            td.Descripcion AS TipoDireccion,
                                            d.Calle,
                                            d.Altura,
                                            d.Entre1,
                                            d.Entre2
                                    FROM ClientesDirecciones cd 
                                    INNER JOIN Direcciones d ON cd.DireccionId = d.DireccionId 
                                    INNER JOIN TiposDirecciones td ON td.TipoDireccionId=cd.TipoDireccionId
                                    WHERE cd.ClienteId = @ClienteId";
            var direcciones = conn.Query<DireccionListDto>(direccionesQuery, new { @ClienteId = clienteId }).ToList();
            cliente.Direcciones.AddRange(direcciones);

            string telefonosQuery = @"SELECT t.TelefonoId, t.Numero, 
                                         tt.Descripcion AS TipoTelefono
                                  FROM ClientesTelefonos ct 
                                  INNER JOIN Telefonos t ON ct.TelefonoId = t.TelefonoId 
                                  INNER JOIN TiposTelefonos tt ON ct.TipoTelefonoId = tt.TipoTelefonoId
                                  WHERE ct.ClienteId = @ClienteId";

            var telefonos = conn.Query<TelefonoListDto>(telefonosQuery, new { @ClienteId = clienteId }).ToList();
            cliente.Telefonos.AddRange(telefonos);
            return cliente;
        }

        public List<ClienteListDto> GetLista(SqlConnection conn, int currentPage, int pageSize, Orden orden, Func<ClienteListDto, bool>? filter)
        {
            var lista = new List<ClienteListDto>();
            var finalQuery = string.Empty;
            var ordenQuery = string.Empty;
            var conditions = string.Empty;
            string selectQuery = @"SELECT c.ClienteId, 
                               CONCAT(Nombre, ' ', Apellido) AS NombreCompleto,
                               c.Documento AS Documento,
                               CONCAT(d.Calle, ' ', d.Altura) AS DireccionPrincipal,
                               t.Numero AS TelefonoPrincipal  
                             FROM Clientes c
                                LEFT JOIN (
                                    SELECT ClienteId, MIN(DireccionId) AS MinDireccionId
                                    FROM ClientesDirecciones
                                    GROUP BY ClienteId
                                    ) cd ON cd.ClienteId = c.ClienteId
                                LEFT JOIN Direcciones d ON d.DireccionId = cd.MinDireccionId
                                LEFT JOIN (
                                    SELECT ClienteId, MIN(TelefonoId) AS MinTelefonoId
                                    FROM ClientesTelefonos
                                    GROUP BY ClienteId
                                    ) ct ON ct.ClienteId = c.ClienteId
                                LEFT JOIN Telefonos t ON t.TelefonoId = ct.MinTelefonoId";
            if (orden == Orden.Ninguno)
            {
                ordenQuery = @" ORDER BY Nombre";
            }
            if (orden == Orden.OrdenAZ)
            {
                ordenQuery = @" ORDER BY Nombre";
            }
            if (orden == Orden.OrdenZA)
            {
                ordenQuery = @" ORDER BY Nombre Desc";
            }


            finalQuery = string.Concat(selectQuery, conditions, ordenQuery);
            var listaClientes = conn.Query<ClienteListDto>(finalQuery).ToList();
            lista.AddRange(listaClientes);
            if (filter != null)
            {
                lista = lista.Where(filter).ToList();
            }
            return lista.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
        }

        public List<Cliente> GetListaCombo(SqlConnection conn)
        {
            string selectQuery = @"SELECT c.ClienteId, 
                            c.Apellido, c.Nombre AS Nombres
                            FROM Clientes c";
            return conn.Query<Cliente>(selectQuery).ToList();
        }

        public int GetPaginaPorRegistro(SqlConnection conn, object nombre, int pageSize)
        {
            string positionQuery = @"WITH ClientesOrdenados As (SELECT ROW_NUMBER() 
                            OVER (ORDER BY Nombre) As RowNum, Nombre FROM Clientes)
                            SELECT RowNum FROM ClientesOrdenados 
                                WHERE Nombre=@Nombre";
            int position = conn.ExecuteScalar<int>(positionQuery, new { Nombre = nombre });
            return (int)Math.Ceiling((decimal)position / pageSize);
        }
    }
}
