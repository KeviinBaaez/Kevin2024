using Dapper;
using Kevin2024.Datos.Interfaces;
using Kevin2024.Entidades.Entidades;
using System.Data.SqlClient;

namespace Kevin2024.Datos.Repositorios
{
    public class RepositorioDirecciones : IRepositorioDirecciones
    {
        public void Agregar(Direccion direccion, SqlConnection conn, SqlTransaction tran)
        {
            var query = @"INSERT INTO Direcciones (Calle, Altura, Entre1, Entre2, Piso, Depto)
            VALUES (@Calle, @Altura, @Entre1, @Entre2, @Piso, @Depto);
            SELECT CAST(SCOPE_IDENTITY() as int);
        ";
            direccion.DireccionId = conn.Query<int>(query, direccion, tran).Single();
        }

        public List<Direccion> GetDireccionesPorClienteId(int clienteId, SqlConnection conn, SqlTransaction? tran = null)
        {
            var query = @" SELECT d.* FROM Direcciones d
                        INNER JOIN ClientesDirecciones cd ON d.DireccionId = cd.DireccionId
                        WHERE cd.ClienteId = @ClienteId";
            return conn.Query<Direccion>(query, new { ClienteId = clienteId }, tran).ToList();
        }

        public int GetDireccionIdIfExists(Direccion direccion, SqlConnection conn, SqlTransaction tran)
        {
            var selectQuery = @"SELECT DireccionId FROM Direcciones 
                WHERE Calle = @Calle 
                    AND Altura = @Altura AND Entre1 = @Entre1 
                    AND Entre2 = @Entre2 AND Piso = @Piso AND Depto = @Depto";
            return conn.ExecuteScalar<int>(selectQuery, direccion, tran);
        }

        public Direccion? GetDireccionPorId(int direccionId, SqlConnection conn)
        {
            var query = "SELECT * FROM Direcciones WHERE DireccionId = @DireccionId";
            return conn.QuerySingleOrDefault<Direccion>(query, new { DireccionId = direccionId });
        }
    }
}
