using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.ViewModels;
using System.Data.SqlClient;

namespace Kevin2024.Datos.Interfaces
{
    public interface IRepositorioClientesDirecciones
    {
        void Agregar(ClienteDireccion clienteDireccion, SqlConnection conn, SqlTransaction tran);
        void BorrarPorClienteId(int clienteId, SqlConnection conn, SqlTransaction tran);
        List<ClienteDireccion> GetDireccionesPorClienteId(int clienteId, SqlConnection conn);
        //List<DireccionConTipoVm> GetListaDirecciones(int clienteId, SqlConnection conn);
        List<Direccion> GetListaDireccionesPorCliente(int clienteId, SqlConnection conn);
        //List<ClienteDireccion> TraemeLasDirecciones(SqlConnection conn, int clienteId);
    }
}
