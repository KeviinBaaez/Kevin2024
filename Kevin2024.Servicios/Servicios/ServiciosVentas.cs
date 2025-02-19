using Kevin2024.Datos.Interfaces;
using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using Kevin2024.Entidades;
using Kevin2024.Servicios.Interfaces;
using System.Data.SqlClient;

namespace Kevin2024.Servicios.Servicios
{
    public class ServiciosVentas : IServiciosVentas
    {
        private readonly IRepositorioVentas _repositorio;
        private readonly IRepositorioDetallesVentas? _repositorioDetalles;
        private readonly string? _cadena;

        public ServiciosVentas(IRepositorioVentas? repositorio,
            IRepositorioDetallesVentas repositorioDetalles,
            string? cadena)
        {
            _repositorio = repositorio ?? throw new ApplicationException("Dependencias no cargadas!!!");
            _repositorioDetalles = repositorioDetalles ?? throw new ApplicationException("Dependencias no cargadas!!!");

            _cadena = cadena;
        }
        public void Guardar(Venta venta)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        if (venta.VentaId == 0)
                        {
                            _repositorio!.Agregar(conn, venta, tran);

                            foreach (var item in venta.Detalles)
                            {
                                item.VentaId = venta.VentaId;
                                _repositorioDetalles!.Agregar(item, conn, tran);
                            }

                        }
                        else
                        {
                            throw new Exception("Ocurrio un error inesperado.");
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

        public void Borrar(int ventaId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        _repositorio!.Borrar(conn, ventaId, tran);
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
        public int GetCantidad(Func<VentaListDto, bool>? filter = null)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetCantidad(conn, filter);
            }
        }
        public List<VentaListDto>? GetLista(int currentPage, int pageSize, Orden orden, Func<VentaListDto, bool>? filter = null)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetLista(conn, currentPage, pageSize, orden, filter);
            }
        }
        public int GetPaginaPorRegistro(string nombre, int pageSize)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetPaginaPorRegistro(conn, nombre, pageSize);
            }
        }
        public Venta? GetVentaPorId(int ventaId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetVentaPorId(conn, ventaId);
            }
        }
    }
}
