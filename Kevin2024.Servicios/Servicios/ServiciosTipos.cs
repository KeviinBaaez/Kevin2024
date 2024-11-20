using Kevin2024.Datos.Interfaces;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using Kevin2024.Servicios.Interfaces;
using System.Data.SqlClient;

namespace Kevin2024.Servicios.Servicios
{
    public class ServiciosTipos : IServiciosTipos
    {
        private readonly IRepositorioTipos? _repositorio;
        private readonly string? _cadena;
        public ServiciosTipos(IRepositorioTipos? repositorio, string? cadena)
        {
            _repositorio = repositorio;
            _cadena = cadena;
        }

        public void Borrar(Tipos tipo, int tipoId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                using(var tran = conn.BeginTransaction())
                {
                    try
                    {
                        _repositorio!.Borrar(conn, tipo, tipoId, tran);
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

        public bool EstaRelacionado(Tipos tipo, int tipoId)
        {
            using(var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.EstaRelacionado(conn, tipo, tipoId);
            }
        }

        public bool Existe(Tipos tipo, TiposDeDatos tiposDeDatos)
        {
            using(var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.Existe(conn, tipo, tiposDeDatos);
            }
        }

        public int GetCantidad(Tipos tipo, Func<TiposDeDatos, bool>? filter)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetCantidad(conn, tipo, filter);
            }
        }

        public List<TiposDeDatos>? GetLista(Tipos tipo, int currentPage, int pageSize, Orden orden, Func<TiposDeDatos, bool>? filter)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetLista(conn, tipo, currentPage, pageSize, orden, filter);
            }
        }

        public List<TiposDeDatos>? GetLista(Tipos tipo)
        {
            using(var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetLista(conn, tipo);
            }
        }

        public int GetPaginaPorRegistro(Tipos tipo, string? descripcion, int pageSize)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetPaginaPorRegistro(conn, tipo, descripcion, pageSize);
            }
        }

        public void Guardar(Tipos tipo, TiposDeDatos tiposDeDatos)
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
                            _repositorio!.Agregar(conn,tipo, tiposDeDatos, tran);
                        }
                        else
                        {
                            _repositorio!.Editar(conn, tipo, tiposDeDatos, tran);
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
