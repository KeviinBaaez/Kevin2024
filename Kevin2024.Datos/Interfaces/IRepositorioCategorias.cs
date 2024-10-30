using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kevin2024.Datos.Interfaces
{
    public interface IRepositorioCategorias
    {
        void Agregar(SqlConnection conn, Categorias categoria, SqlTransaction tran);
        void Borrar(SqlConnection conn, int categoriaId, SqlTransaction tran);
        void Editar(SqlConnection conn, Categorias categoria, SqlTransaction tran);
        bool EstaRelacionado(SqlConnection conn, int categoriaId);
        bool Existe(SqlConnection conn, Categorias categoria);
        int GetCantidad(SqlConnection conn, Func<Categorias, bool>? filter);
        List<Categorias>? GetLista(SqlConnection conn, int currentPage, int pageSize, Orden orden, Func<Categorias, bool>? filter);
        List<Categorias>? GetLista(SqlConnection conn);
        int GetPaginaPorRegistro(SqlConnection conn, string descripcion, int pageSize);
    }
}
