using Dapper;
using Kevin2024.Datos.Interfaces;
using Kevin2024.Entidades.Entidades;
using System.Data.SqlClient;

namespace Kevin2024.Datos.Repositorios
{
    public class RepositorioTelefonos : IRepositorioTelefonos
    {
        public void Agregar(Telefonos telefono, SqlConnection conn, SqlTransaction tran)
        {
            var insertQuery = @"INSERT INTO Telefonos (Numero)
                                    VALUES (@Numero);
                                SELECT CAST(SCOPE_IDENTITY() as int);";
            telefono.TelefonoId = conn.Query<int>(insertQuery, telefono, tran).Single();
        }

        public int GetTelefonoIdIfExist(Telefonos telefono, SqlConnection conn, SqlTransaction tran)
        {
            var selectQuery = @"SELECT TelefonoId FROM Telefonos 
                                    WHERE Numero = @Numero";
            return conn.ExecuteScalar<int>(selectQuery, telefono, tran);
        }

        public Telefonos? GetTelefonoPorId(int telefonoId, SqlConnection conn, SqlTransaction? tran = null)
        {
            var query = "SELECT * FROM Telefonos WHERE TelefonoId = @TelefonoId";
            return conn.QuerySingleOrDefault<Telefonos>(query,
                new { TelefonoId = telefonoId }, tran);
        }

        public List<Telefonos> GetTelefonosPorClienteId(int clienteId, SqlConnection conn, SqlTransaction? tran = null)
        {
            var query = @"SELECT t.* FROM Telefonos t
                    JOIN ClientesTelefonos ct ON t.TelefonoId = ct.TelefonoId
                    WHERE ct.ClienteId = @ClienteId ";
            return conn.Query<Telefonos>(query, new { ClienteId = clienteId }, tran).ToList();
        }
    }
}
