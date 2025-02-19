using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;

namespace Kevin2024.Servicios.Interfaces
{
    public interface IServiciosOrden
    {
        void Borrar(int ordenId);
        void CancelarOrden(int ordenId);
        int GetCantidad(Func<OrdenListDto, bool>? filter);
        List<OrdenListDto>? GetLista(int currentPage, int pageSize, Orden orden, Func<OrdenListDto, bool>? filter);
        OrdenPedido? GetOrdenPorId(int ordenId);
        void Guardar(OrdenPedido? orden);
        void OrdenCompletada(int ordenId);
        void OrdenEnviada(int ordenId);
        void OrdenPendiente(int ordenId);
    }
}
