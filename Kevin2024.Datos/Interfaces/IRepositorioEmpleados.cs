using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using System.Data.SqlClient;

namespace Kevin2024.Datos.Interfaces
{
    public interface IRepositorioEmpleados
    {
        void Agregar(SqlConnection conn, Empleados empleado, SqlTransaction tran);
        void Borrar(SqlConnection conn, int empleadoId, SqlTransaction tran);
        void Editar(SqlConnection conn, Empleados empleado, SqlTransaction tran);
        bool Existe(SqlConnection conn, Empleados empleado);
        int GetCantidad(SqlConnection conn, Func<EmpleadosListDto, bool>? filter);
        Empleados? GetEmpleadoPorId(SqlConnection conn, int empleadoId);
        List<EmpleadosListDto>? GetLista(SqlConnection conn, int currentPage, int pageSize, Orden orden, Func<EmpleadosListDto, bool>? filter);
        int GetPaginaPorRegistro(SqlConnection conn, string? nombre, int pageSize);
    }
}
