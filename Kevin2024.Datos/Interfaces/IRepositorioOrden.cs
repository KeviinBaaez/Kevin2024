using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using System.Data.SqlClient;

namespace Kevin2024.Datos.Interfaces
{
    public interface IRepositorioOrden
    {
        void Agregar(SqlConnection conn, OrdenPedido orden, SqlTransaction tran);
        void Borrar(SqlConnection conn, int ordenId, SqlTransaction tran);
        void CancelarOrden(SqlConnection conn, int ordenId, SqlTransaction tran);
        void Editar(SqlConnection conn, OrdenPedido orden, SqlTransaction tran);
        int GetCantidad(SqlConnection conn, Func<OrdenListDto, bool>? filter);
        List<OrdenListDto>? GetLista(SqlConnection conn, int currentPage, int pageSize, Orden orden, Func<OrdenListDto, bool>? filter);
        OrdenPedido? GetOrdenPorId(SqlConnection conn, int ordenId);
        void OrdenCompletada(SqlConnection conn, int ordenId, SqlTransaction tran);
        void OrdenEnviada(SqlConnection conn, int ordenId, SqlTransaction tran);
        void OrdenPendiente(SqlConnection conn, int ordenId, SqlTransaction tran);
    }
}
