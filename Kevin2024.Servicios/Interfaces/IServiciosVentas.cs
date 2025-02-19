using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;

namespace Kevin2024.Servicios.Interfaces
{
    public interface IServiciosVentas
    {
        void Borrar(int ventaId);
        int GetCantidad(Func<VentaListDto, bool>? filter = null);
        List<VentaListDto>? GetLista(int currentPage, int pageSize, Orden orden, Func<VentaListDto, bool>? filter = null);
        int GetPaginaPorRegistro(string nombre, int pageSize);
        Venta? GetVentaPorId(int ventaId);
        void Guardar(Venta venta);
    }
}
