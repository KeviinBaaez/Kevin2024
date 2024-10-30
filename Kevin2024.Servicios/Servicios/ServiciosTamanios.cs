using Kevin2024.Datos.Interfaces;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using Kevin2024.Servicios.Interfaces;
using System.Data.SqlClient;

namespace Kevin2024.Servicios.Servicios
{
    public class ServiciosTamanios : IServiciosTamanios
    {
        private readonly IRepositorioTamanios? _repositorio;
        private readonly string? _cadena;
        public ServiciosTamanios(IRepositorioTamanios repositorio, string? cadena)
        {
            _repositorio = repositorio ?? throw new ApplicationException("Dependencias no cargadas!!");
            _cadena = cadena;
        }

        public void Borrar(int tamanioId)
        {
            using(var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        _repositorio!.Borrar(conn, tamanioId, tran);
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

        public bool EstaRelacionado(int tamanioId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.EstaRelacionado(conn, tamanioId);
            }
        }

        public bool Existe(Tamanio tamanio)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.Existe(conn, tamanio);
            }
        }

        public int GetCantidad(Func<Tamanio, bool>? filter)
        {
            using(var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetCantidad(conn, filter);
            }
        }

        public List<Tamanio>? GetLista(int currentPage, int pageSize, Orden orden, Func<Tamanio, bool>? filter)
        {
            using(var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetLista(conn, currentPage, pageSize, orden, filter);
            }
        }

        public List<Tamanio> GetLista()
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetLista(conn);
            }
        }

        public int GetPaginaPorRegistro(string descripcion, int pageSize)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetPaginaPorRegistro(conn, descripcion, pageSize);
            }
        }

        public void Guardar(Tamanio tamanio)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        if(tamanio.TamanioId == 0)
                        {
                            _repositorio!.Agregar(conn, tamanio, tran);
                        }
                        else
                        {
                            _repositorio!.Editar(conn, tamanio, tran);
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
