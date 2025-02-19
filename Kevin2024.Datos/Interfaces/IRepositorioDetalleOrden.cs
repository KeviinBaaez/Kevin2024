using Kevin2024.Entidades.Entidades;
using System.Data.SqlClient;

namespace Kevin2024.Datos.Interfaces
{
    public interface IRepositorioDetalleOrden
    {
        void Agregar(DetalleOrden item, SqlConnection conn, SqlTransaction tran);
    }
}
