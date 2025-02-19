using Kevin2024.Datos.Interfaces;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using Kevin2024.Servicios.Interfaces;
using System.Data.SqlClient;

namespace Kevin2024.Servicios.Servicios
{
    public class ServiciosArchivos : IServiciosArchivos
    {
        private readonly IRepositorioArchivos? _repositorio;
        private readonly string? _cadena;
        public ServiciosArchivos(IRepositorioArchivos? repositorio, string? cadena)
        {
            _repositorio = repositorio;
            _cadena = cadena;
        }

        public void Borrar(Archivo archivo, int tipoId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                using(var tran = conn.BeginTransaction())
                {
                    try
                    {
                        _repositorio!.Borrar(conn, archivo, tipoId, tran);
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

        public bool EstaRelacionado(Archivo archivo, int tipoId)
        {
            using(var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.EstaRelacionado(conn, archivo, tipoId);
            }
        }

        public bool Existe(Archivo archivo, TiposDeDatos tiposDeDatos)
        {
            using(var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.Existe(conn, archivo, tiposDeDatos);
            }
        }

        public int GetCantidad(Archivo archivo, Func<TiposDeDatos, bool>? filter)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetCantidad(conn, archivo, filter);
            }
        }

        public List<TiposDeDatos>? GetLista(Archivo archivo, int currentPage, int pageSize, Orden orden, Func<TiposDeDatos, bool>? filter)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetLista(conn, archivo, currentPage, pageSize, orden, filter);
            }
        }

        public List<TiposDeDatos>? GetLista(Archivo archivo)
        {
            using(var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetLista(conn, archivo);
            }
        }

        public int GetPaginaPorRegistro(Archivo archivo, string? descripcion, int pageSize)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetPaginaPorRegistro(conn, archivo, descripcion, pageSize);
            }
        }

        public void Guardar(Archivo archivo, TiposDeDatos tiposDeDatos)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        if (tiposDeDatos.TipoId == 0)
                        {
                            _repositorio!.Agregar(conn,archivo, tiposDeDatos, tran);
                        }
                        else
                        {
                            _repositorio!.Editar(conn, archivo, tiposDeDatos, tran);
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
