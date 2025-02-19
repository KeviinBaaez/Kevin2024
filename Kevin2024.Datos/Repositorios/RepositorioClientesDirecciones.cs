using Dapper;
using Kevin2024.Datos.Interfaces;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.ViewModels;
using System.Data.SqlClient;

namespace Kevin2024.Datos.Repositorios
{
    public class RepositorioClientesDirecciones : IRepositorioClientesDirecciones
    {
        public void Agregar(ClienteDireccion clienteDireccion, SqlConnection conn, SqlTransaction tran)
        {
            var insertQuery = @"INSERT INTO ClientesDirecciones (ClienteId, DireccionId, TipoDireccionId)
                VALUES (@ClienteId, @DireccionId, @TipoDireccionId);";
            conn.Execute(insertQuery, clienteDireccion, tran);
        }

        public void BorrarPorClienteId(int clienteId, SqlConnection conn, SqlTransaction tran)
        {
            var query = "DELETE FROM ClientesDirecciones WHERE ClienteId = @ClienteId";
            conn.Execute(query, new { ClienteId = clienteId }, tran);
        }

        public List<ClienteDireccion> GetDireccionesPorClienteId(int clienteId, SqlConnection conn)
        {
            var query = @"SELECT cd.*, td.TipoDireccionId, td.Descripcion AS 'TipoDireccion.Descripcion' FROM ClientesDirecciones cd 
                            INNER JOIN TiposDirecciones td On td.TipoDireccionId = cd.TipoDireccionId
                    WHERE ClienteId = @ClienteId";
            return conn.Query<ClienteDireccion>(query, new { ClienteId = clienteId }).ToList();
        }

        public List<Direccion> GetListaDireccionesPorCliente(int clienteId, SqlConnection conn)
        {
            var selectQuery = @"SELECT cd.ClienteId, 
                                d.DireccionId, d.Calle, d.Altura, d.Entre1, d.Entre2, d.Piso, d.Depto
                                FROM ClientesDirecciones cd 
                                INNER JOIN Direcciones d on d.DireccionId = cd.DireccionId 
                                WHERE cd.ClienteId = @ClienteId";
            return conn.Query<Direccion>(selectQuery, new { ClienteId = clienteId }).ToList();
        }
    }
}
