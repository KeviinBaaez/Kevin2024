using Kevin2024.Entidades;
using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Enumeraciones;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kevin2024.Datos.Interfaces
{
    public interface IRepositorioProductos
    {
        void Agregar(SqlConnection conn, Productos producto, SqlTransaction tran);
        void Borrar(SqlConnection conn, int productoId, SqlTransaction tran);
        void Editar(SqlConnection conn, Productos producto, SqlTransaction tran);
        bool EstaRelacionado(SqlConnection conn, int productoId);
        bool Existe(SqlConnection conn, Productos producto);
        int GetCantidad(SqlConnection conn, Func<ProductosListDto, bool>? filter = null);
        List<ProductosListDto>? GetLista(SqlConnection conn, int currentPage, int pageSize, Orden orden, Func<ProductosListDto, bool>? filter = null);
        int GetPaginaPorRegistro(SqlConnection conn, string nombre, int pageSize);
        Productos? GetProductoPorId(SqlConnection conn, int productoId);
    }
}
