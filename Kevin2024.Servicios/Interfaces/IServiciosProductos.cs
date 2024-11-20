using Kevin2024.Entidades;
using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Enumeraciones;

namespace Kevin2024.Servicios.Interfaces
{
    public interface IServiciosProductos
    {
        void Borrar(int productoId);
        bool EstaRelacionado(int productoId);
        bool Existe(Productos producto);
        int GetCantidad(Func<ProductosListDto, bool>? filter = null);
        List<ProductosListDto>? GetLista(int currentPage, int pageSize, Orden orden, Func<ProductosListDto, bool>? filter = null);
        int GetPaginaPorRegistro(string nombre, int pageSize);
        Productos? GetProductoPorId(int productoId);
        void Guardar(Productos producto);
    }
}
