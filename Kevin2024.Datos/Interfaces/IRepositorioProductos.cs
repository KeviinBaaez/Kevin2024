using Kevin2024.Entidades;
using Kevin2024.Entidades.Dtos;
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
    public interface IRepositorioProductos
    {
        void Agregar(SqlConnection conn, Productos producto, SqlTransaction tran);
        void Borrar(SqlConnection conn, int productoId, SqlTransaction tran);
        void Editar(SqlConnection conn, Productos producto, SqlTransaction tran);
        bool EstaRelacionado(SqlConnection conn, int productoId);
        bool Existe(SqlConnection conn, Productos producto);
        int GetCantidad(SqlConnection conn, Func<ProductosListDto, bool>? filter = null, Orden? orden = null, TiposDeDatos? consulta = null);
        int GetCantidad(SqlConnection conn, Func<Productos, bool>? filter = null);
        List<ProductosListDto>? GetLista(SqlConnection conn, int currentPage, int pageSize, Orden orden, Func<ProductosListDto, bool>? filter = null, TiposDeDatos? consulta = null);
        List<Productos>? GetListaCombo(SqlConnection conn, Func<Productos, bool>? filter);
        List<Productos>? GetListaProductos(SqlConnection conn, TipoProducto tipoProducto);
        int GetPaginaPorRegistro(SqlConnection conn, string nombre, int pageSize);
        Productos? GetProductoPorId(SqlConnection conn, TipoProducto tipoProducto, int productoId);
    }
}
