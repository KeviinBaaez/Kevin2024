using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using System.Data.SqlClient;

namespace Kevin2024.Datos.Interfaces
{
    public interface IRepositorioTipos
    {
        void Agregar(SqlConnection conn, Tipos tipo, TiposDeDatos tiposDeDatos, SqlTransaction tran);
        void Borrar(SqlConnection conn, Tipos tipo, int tipoId, SqlTransaction tran);
        void Editar(SqlConnection conn, Tipos tipo, TiposDeDatos tiposDeDatos, SqlTransaction tran);
        bool EstaRelacionado(SqlConnection conn, Tipos tipo, int tipoId);
        bool Existe(SqlConnection conn, Tipos tipo, TiposDeDatos tiposDeDatos);
        int GetCantidad(SqlConnection conn, Tipos tipo, Func<TiposDeDatos, bool>? filter);
        List<TiposDeDatos>? GetLista(SqlConnection conn, Tipos tipo, int currentPage, int pageSize, Orden orden, Func<TiposDeDatos, bool>? filter);
        List<TiposDeDatos>? GetLista(SqlConnection conn, Tipos tipo);
        int GetPaginaPorRegistro(SqlConnection conn, Tipos tipo, string? descripcion, int pageSize);
    }
}
