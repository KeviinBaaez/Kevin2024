using Kevin2024.Entidades.Entidades;
using System.Data.SqlClient;

namespace Kevin2024.Datos.Interfaces
{
    public interface IRepositorioDirecciones
    {
        void Agregar(Direccion direccion, SqlConnection conn, SqlTransaction tran);
        int GetDireccionIdIfExists(Direccion direccion, SqlConnection conn, SqlTransaction tran);
        Direccion? GetDireccionPorId(int direccionId, SqlConnection conn);
        List<Direccion> GetDireccionesPorClienteId(int clienteId,
            SqlConnection conn, SqlTransaction? tran = null);
    }
}
