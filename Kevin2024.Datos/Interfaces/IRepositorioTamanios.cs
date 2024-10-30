using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using System.Data.SqlClient;

namespace Kevin2024.Datos.Interfaces
{
    public interface IRepositorioTamanios
    {
        void Agregar(SqlConnection conn, Tamanio tamanio, SqlTransaction tran);
        void Borrar(SqlConnection conn, int tamanioId, SqlTransaction tran);
        void Editar(SqlConnection conn, Tamanio tamanio, SqlTransaction tran);
        bool EstaRelacionado(SqlConnection conn, int tamanioId);
        bool Existe(SqlConnection conn, Tamanio tamanio);
        int GetCantidad(SqlConnection conn, Func<Tamanio, bool>? filter);
        List<Tamanio>? GetLista(SqlConnection conn, int currentPage, int pageSize, Orden orden, Func<Tamanio, bool>? filter);
        List<Tamanio> GetLista(SqlConnection conn);
        int GetPaginaPorRegistro(SqlConnection conn, string descripcion, int pageSize);
    }
}
