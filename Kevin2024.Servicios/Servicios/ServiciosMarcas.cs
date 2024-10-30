using Kevin2024.Datos.Interfaces;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using Kevin2024.Servicios.Interfaces;
using System.Data.SqlClient;

namespace Kevin2024.Servicios.Servicios
{
    public class ServiciosMarcas : IServiciosMarcas
    {
        private readonly IRepositorioMarcas? _repositorio;
        private readonly string? _cadena;

        public ServiciosMarcas(IRepositorioMarcas repositorio, string? cadena)
        {
            _repositorio = repositorio ?? throw new ApplicationException("Dependencias No Cargadas!!");
            _cadena = cadena;
        }
        public void Guardar(Marcas marca)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        if (marca.MarcaId == 0)
                        {
                            _repositorio!.Agregar(conn, marca, tran);
                        }
                        else
                        {
                            _repositorio!.Editar(conn, marca, tran);
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
        public bool Existe(Marcas marca)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.Existe(conn, marca);
            }
        }
        public void Borrar(int marcaId)
        {
            using(var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                using(var tran = conn.BeginTransaction())
                {
                    try
                    {
                        _repositorio!.Borrar(conn, marcaId, tran);
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
        public bool EstaRelacionado(int marcaId)
        {
            using(var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.EstaRelacionado(conn, marcaId);
            }
        }
        public int GetCantidad(Func<Marcas, bool>? filter)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetCantidad(conn, filter);
            }
        }
        public List<Marcas>? GetLista(int currentPage, int pageSize, Orden orden, Func<Marcas, bool>? filter)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetLista(conn, currentPage, pageSize, orden, filter);
            }
        }
        public List<Marcas>? GetLista()
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetLista(conn);
            }
        }
        public int GetPaginaPorRegistro(string nombre, int pageSize)
        {
            using(var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetPaginaPorRegistro(conn, nombre, pageSize);
            }
        }
    }
}
