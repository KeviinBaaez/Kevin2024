using Kevin2024.Entidades.Entidades;
using System.Data.SqlClient;

namespace Kevin2024.Datos.Interfaces
{
    public interface IRepositorioDetallesCombos
    {
        void Agregar(DetallesCombos item, SqlConnection conn, SqlTransaction tran);
        void Borrar(int ProductoId, SqlConnection conn, SqlTransaction tran);
    }
}
