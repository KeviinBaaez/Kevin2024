using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using System.Data.SqlClient;

namespace Kevin2024.Datos.Interfaces
{
    public interface IRepositorioVentas
    {
        void Agregar(SqlConnection conn, Venta venta, SqlTransaction tran);
        void Borrar(SqlConnection conn, int ventaId, SqlTransaction tran);
        int GetCantidad(SqlConnection conn, Func<VentaListDto, bool>? filter);
        List<VentaListDto>? GetLista(SqlConnection conn, int currentPage, int pageSize, Orden orden, Func<VentaListDto, bool>? filter);
        int GetPaginaPorRegistro(SqlConnection conn, string nombre, int pageSize);
        Venta? GetVentaPorId(SqlConnection conn, int ventaId);
    }
}
