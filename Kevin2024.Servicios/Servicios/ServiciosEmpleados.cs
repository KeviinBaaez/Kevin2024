using Kevin2024.Datos.Interfaces;
using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using Kevin2024.Servicios.Interfaces;
using System.Data.SqlClient;

namespace Kevin2024.Servicios.Servicios
{
    public class ServiciosEmpleados : IServiciosEmpleados
    {
        private readonly IRepositorioEmpleados? _repositorio;
        private readonly string? _cadena;

        public ServiciosEmpleados(IRepositorioEmpleados? repositorio, string? cadena)
        {
            _repositorio = repositorio ?? throw new Exception("Dependencias no cargadas..");
            _cadena = cadena;
        }

        public void Borrar(int empleadoId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        _repositorio!.Borrar(conn, empleadoId, tran);
                        tran.Commit();
                    }
                    catch (Exception)
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }

        //public bool EstaRelacionado(int empleadoId)
        //{
        //    using (var conn = new SqlConnection(_cadena))
        //    {
        //        conn.Open();
        //        return _repositorio!.EstaRelacionado(conn, empleadoId);
        //    }
        //}

        public bool Existe(Empleados empleado)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.Existe(conn, empleado);
            }
        }

        public int GetCantidad(Func<EmpleadosListDto, bool>? filter, TiposDeDatos? generoFiltro = null)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetCantidad(conn, filter, generoFiltro);
            }
        }

        public Empleados? GetEmpleadoPorId(int empleadoId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetEmpleadoPorId(conn, empleadoId);
            }
        }

        public List<EmpleadosListDto>? GetLista(int currentPage, int pageSize, Orden orden, Func<EmpleadosListDto, bool>? filter, TiposDeDatos? generoFiltro = null)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetLista(conn, currentPage, pageSize, orden, filter, generoFiltro);
            }
        }

        public int GetPaginaPorRegistro(string? nombre, int pageSize)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetPaginaPorRegistro(conn, nombre, pageSize);
            }
        }

        public void Guardar(Empleados empleado)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        if (empleado.EmpleadoId == 0)
                        {
                            _repositorio!.Agregar(conn, empleado, tran);
                        }
                        else
                        {
                            _repositorio!.Editar(conn, empleado, tran);
                        }
                        tran.Commit();
                    }
                    catch (Exception)
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}
