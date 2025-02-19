using Kevin2024.Datos.Interfaces;
using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using Kevin2024.Servicios.Interfaces;
using System.Data.SqlClient;

namespace Kevin2024.Servicios.Servicios
{
    public class ServiciosOrden : IServiciosOrden
    {
        private readonly IRepositorioOrden _repositorio;
        private readonly IRepositorioDetalleOrden? _repositorioDetalles;
        private readonly string? _cadena;

        public ServiciosOrden(IRepositorioOrden? repositorio,
            IRepositorioDetalleOrden repositorioDetalles,
            string? cadena)
        {
            _repositorio = repositorio ?? throw new ApplicationException("Dependencias no cargadas!!!");
            _repositorioDetalles = repositorioDetalles ?? throw new ApplicationException("Dependencias no cargadas!!!");

            _cadena = cadena;
        }
        public void Guardar(OrdenPedido orden)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        if (orden.OrdenId == 0)
                        {
                            _repositorio!.Agregar(conn, orden, tran);
                            foreach (var item in orden.Detalles)
                            {
                                item.OrdenId = orden.OrdenId;
                                _repositorioDetalles!.Agregar(item, conn, tran);
                            }

                        }
                        else
                        {
                            _repositorio!.Editar(conn, orden, tran);
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
        public void Borrar(int ordenId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        _repositorio!.Borrar(conn, ordenId, tran);
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
        public int GetCantidad(Func<OrdenListDto, bool>? filter = null)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetCantidad(conn, filter);
            }
        }
        public List<OrdenListDto>? GetLista(int currentPage, int pageSize, Orden orden, Func<OrdenListDto, bool>? filter = null)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetLista(conn, currentPage, pageSize, orden, filter);
            }
        }

        public OrdenPedido? GetOrdenPorId(int ordenId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetOrdenPorId(conn, ordenId);
            }
        }

        public void CancelarOrden(int ordenId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                using(var tran = conn.BeginTransaction())
                {
                    try
                    {
                        _repositorio!.CancelarOrden(conn, ordenId, tran);
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

        public void OrdenCompletada(int ordenId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        _repositorio!.OrdenCompletada(conn, ordenId, tran);
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

        public void OrdenEnviada(int ordenId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        _repositorio!.OrdenEnviada(conn, ordenId, tran);
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

        public void OrdenPendiente(int ordenId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        _repositorio!.OrdenPendiente(conn, ordenId, tran);
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
