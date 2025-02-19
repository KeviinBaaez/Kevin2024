using Kevin2024.Entidades;
using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;

namespace Kevin2024.Servicios.Interfaces
{
    public interface IServiciosCombos
    {
        void Borrar(int productoId);
        bool EstaRelacionado(int productoId);
        bool Existe(Combo combo);
        int GetCantidad(Func<ComboListDto, bool>? filter);
        Combo GetComboPorId(int productoId);
        List<ComboListDto>? GetLista(int currentPage, int pageSize, Orden orden, Func<ComboListDto, bool>? filter);
        int GetPaginaPorRegistro(string nombre, int pageSize);
        void Guardar(Combo combo);
    }
}
