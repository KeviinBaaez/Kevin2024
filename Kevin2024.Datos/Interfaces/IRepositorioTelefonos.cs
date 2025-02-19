using Kevin2024.Entidades.Entidades;
using System.Data.SqlClient;

namespace Kevin2024.Datos.Interfaces
{
    public interface IRepositorioTelefonos
    {
        void Agregar(Telefonos telefono, SqlConnection conn, SqlTransaction tran);
        int GetTelefonoIdIfExist(Telefonos telefono, SqlConnection conn, SqlTransaction tran);
        Telefonos? GetTelefonoPorId(int telefonoId, SqlConnection conn, SqlTransaction? tran = null);
        List<Telefonos> GetTelefonosPorClienteId(int clienteId, SqlConnection conn, SqlTransaction? tran = null);
    }
}
