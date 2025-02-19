using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using System.Data.SqlClient;

namespace Kevin2024.Datos.Interfaces
{
    public interface IRepositorioArchivos
    {
        void Agregar(SqlConnection conn, Archivo archivo, TiposDeDatos tiposDeDatos, SqlTransaction tran);
        void Borrar(SqlConnection conn, Archivo archivo, int tipoId, SqlTransaction tran);
        void Editar(SqlConnection conn, Archivo archivo, TiposDeDatos tiposDeDatos, SqlTransaction tran);
        bool EstaRelacionado(SqlConnection conn, Archivo archivo, int tipoId);
        bool Existe(SqlConnection conn, Archivo archivo, TiposDeDatos tiposDeDatos);
        int GetCantidad(SqlConnection conn, Archivo archivo, Func<TiposDeDatos, bool>? filter);
        List<TiposDeDatos>? GetLista(SqlConnection conn, Archivo archivo, int currentPage, int pageSize, Orden orden, Func<TiposDeDatos, bool>? filter);
        List<TiposDeDatos>? GetLista(SqlConnection conn, Archivo archivo);
        int GetPaginaPorRegistro(SqlConnection conn, Archivo archivo, string? descripcion, int pageSize);
    }
}
