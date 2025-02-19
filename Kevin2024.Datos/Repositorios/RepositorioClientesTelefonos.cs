using Dapper;
using Kevin2024.Datos.Interfaces;
using Kevin2024.Entidades.Entidades;
using System.Data.SqlClient;

namespace Kevin2024.Datos.Repositorios
{
    public class RepositorioClientesTelefonos : IRepositorioClientesTelefonos
    {
        public void Agregar(ClienteTelefono clienteTelefono, SqlConnection conn, SqlTransaction tran)
        {
            var insertQuery = @"INSERT INTO ClientesTelefonos (ClienteId, TelefonoId, TipoTelefonoId)
            VALUES (@ClienteId, @TelefonoId, @TipoTelefonoId);";
            conn.Execute(insertQuery, clienteTelefono, tran);
        }

        public void BorrarPorClienteId(int clienteId, SqlConnection conn, SqlTransaction tran)
        {
            var query = "DELETE FROM ClientesTelefonos WHERE ClienteId = @ClienteId";
            conn.Execute(query, new { ClienteId = clienteId }, tran);
        }

        public List<Telefonos> GetListaTelefonosPorCliente(int clienteId, SqlConnection conn)
        {
            var query = @"SELECT ct.ClienteId, t.Numero AS Numero FROM ClientesTelefonos ct
                            LEFT JOIN Telefonos t on t.TelefonoId = ct.TelefonoId
                            WHERE ct.ClienteId = @ClienteId";
            return conn.Query <Telefonos>(query, new { ClienteId = clienteId }).ToList();
        }

        public List<ClienteTelefono> GetTelefonosPorClienteId(int clienteId, SqlConnection conn)
        {
            var query = "SELECT * FROM ClientesTelefonos WHERE ClienteId = @ClienteId";
            return conn.Query<ClienteTelefono>(query, new { ClienteId = clienteId }).ToList();
        }
    }
}
