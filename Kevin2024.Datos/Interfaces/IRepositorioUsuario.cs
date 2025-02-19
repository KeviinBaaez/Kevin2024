using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using System.Data.SqlClient;

namespace Kevin2024.Datos.Interfaces
{
    public interface IRepositorioUsuario
    {
        void Borrar(SqlConnection conn, int usuarioId, SqlTransaction tran);
        void Editar(SqlConnection conn, Usuario usuario, SqlTransaction tran);
        bool Existe(SqlConnection conn, Usuario usuario);
        int GetCantidad(SqlConnection conn, Func<Usuario, bool>? filter);
        List<Usuario>? GetLista(SqlConnection conn, int currentPage, int pageSize, Orden orden, Func<Usuario, bool>? filter);
        void Agregar(SqlConnection conn, Usuario usuario, SqlTransaction tran);
    }
}
