using Kevin2024.Entidades;
using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;

namespace Kevin2024.Servicios.Interfaces
{
    public interface IServiciosProductos
    {
        void Borrar(int productoId);
        bool EstaRelacionado(int productoId);
        bool Existe(Productos producto);
        int GetCantidad(Func<ProductosListDto, bool>? filter = null, Orden? orden = null, TiposDeDatos? consulta = null);
        int GetCantidad(Func<Productos, bool>? filter = null);
        List<ProductosListDto>? GetLista(int currentPage, int pageSize, Orden orden, Func<ProductosListDto, bool>? filter = null, TiposDeDatos? consulta = null);
        List<Productos>? GetListaProductos(TipoProducto tipoProducto);
        List<Productos>? GetListaCombo(Func<Productos, bool>? filter = null);
        int GetPaginaPorRegistro(string nombre, int pageSize);
        Productos? GetProductoPorId(TipoProducto tipoProducto, int productoId);
        void Guardar(Productos producto);
    }
}
