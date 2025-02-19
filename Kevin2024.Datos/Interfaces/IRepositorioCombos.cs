using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using System.Data.SqlClient;

namespace Kevin2024.Datos.Interfaces
{
    public interface IRepositorioCombos
    {
        void Agregar(SqlConnection conn, Combo combo, SqlTransaction tran);
        void Borrar(SqlConnection conn, int productoId, SqlTransaction tran);
        void Editar(SqlConnection conn, Combo combo, SqlTransaction tran);
        bool EstaRelacionado(SqlConnection conn, int productoId);
        bool Existe(SqlConnection conn, Combo combo);
        int GetCantidad(SqlConnection conn, Func<ComboListDto, bool>? filter);
        List<ComboListDto>? GetLista(SqlConnection conn, int currentPage, int pageSize, Orden orden, Func<ComboListDto, bool>? filter);
        int GetPaginaPorRegistro(SqlConnection conn, string nombre, int pageSize);
        Combo GetProductoPorId(SqlConnection conn, int productoId);
    }
}
