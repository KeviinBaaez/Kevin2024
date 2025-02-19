using Kevin2024.Entidades.Entidades;
using System.Data.SqlClient;

namespace Kevin2024.Datos.Interfaces
{
    public interface IRepositorioClientesTelefonos
    {
        void Agregar(ClienteTelefono clienteTelefono, SqlConnection conn, SqlTransaction tran);
        void BorrarPorClienteId(int clienteId, SqlConnection conn, SqlTransaction tran);
        List<Telefonos> GetListaTelefonosPorCliente(int clienteId, SqlConnection conn);
        List<ClienteTelefono> GetTelefonosPorClienteId(int clienteId, SqlConnection conn);
    }
}
