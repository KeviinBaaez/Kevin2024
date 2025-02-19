using Kevin2024.Datos.Interfaces;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using Kevin2024.Servicios.Interfaces;
using System.Data.SqlClient;

namespace Kevin2024.Servicios.Servicios
{
    public class ServiciosUsuarios : IServiciosUsuarios
    {
        private readonly IRepositorioUsuario? _repositorio;
        private readonly string _cadena;    

        public ServiciosUsuarios(IRepositorioUsuario? repositorio, string cadena)
        {
            _repositorio = repositorio ?? throw new ApplicationException("Dependencias no cargadas!!"); ;
            _cadena = cadena;
        }

        public void Borrar(int usuarioId)
        {
            using(var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                using(var tran = conn.BeginTransaction())
                {
                    try
                    {
                        _repositorio!.Borrar(conn, usuarioId, tran);
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

        public bool Existe(Usuario usuario)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.Existe(conn, usuario);
            }
        }

        public int GetCantidad(Func<Usuario, bool>? filter)
        {
            using(var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetCantidad(conn, filter);
            }
        }

        public List<Usuario>? GetLista(int currentPage, int pageSize, Orden orden, Func<Usuario, bool>? filter)
        {
            using(var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetLista(conn,  currentPage, pageSize, orden, filter);
            }
        }

        public void GuardarUsuario(Usuario usuario)
        {
            using(var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                using(var tran = conn.BeginTransaction())
                {
                    try
                    {
                        if (usuario.UsuarioId == 0)
                        {
                            _repositorio!.Agregar(conn, usuario, tran);
                        }
                        else
                        {
                            _repositorio!.Editar(conn, usuario, tran);
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
