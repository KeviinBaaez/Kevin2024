using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;

namespace Kevin2024.Servicios.Interfaces
{
    public interface IServiciosEmpleados
    {
        void Borrar(int empleadoId);
        bool Existe(Empleados empleado);
        int GetCantidad(Func<EmpleadosListDto, bool>? filter);
        Empleados GetEmpleadoPorId(int empleadoId);
        List<EmpleadosListDto>? GetLista(int currentPage, int pageSize, Orden orden, Func<EmpleadosListDto, bool>? filter);
        int GetPaginaPorRegistro(string? nombre, int pageSize);
        void Guardar(Empleados empleado);
    }
}
