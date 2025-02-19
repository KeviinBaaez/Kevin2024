using Kevin2024.Entidades.Entidades;
using System.Data.SqlClient;

namespace Kevin2024.Datos.Interfaces
{
    public interface IRepositorioDetallesVentas
    {
        void Agregar(DetalleVenta detalle, SqlConnection conn, SqlTransaction tran);
    }
}
