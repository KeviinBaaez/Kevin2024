using Kevin2024.Datos.Interfaces;
using Kevin2024.Entidades;
using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using Kevin2024.Servicios.Interfaces;
using System.Data.SqlClient;

namespace Kevin2024.Servicios.Servicios
{
    public class ServiciosProductos : IServiciosProductos
    {
        private readonly IRepositorioProductos? _repositorio;
        private readonly string? _cadena;
        public ServiciosProductos(IRepositorioProductos? repositorio, string cadena)
        {
            _repositorio = repositorio ?? throw new ApplicationException("Dependencias no cargadas!!");
            _cadena = cadena;
        }
        public void Guardar(Productos producto)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        if (producto.ProductoId == 0)
                        {
                            _repositorio!.Agregar(conn, producto, tran);
                        }
                        else
                        {
                            _repositorio!.Editar(conn, producto, tran);
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
        public bool Existe(Productos producto)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.Existe(conn, producto);
            }
        }
        public void Borrar(int productoId)
        {
            using(var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                using(var tran = conn.BeginTransaction())
                {
                    try
                    {
                        _repositorio!.Borrar(conn, productoId, tran);
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
        public bool EstaRelacionado(int productoId)
        {
            using(var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.EstaRelacionado(conn, productoId);
            }
        }
        public int GetCantidad(Func<ProductosListDto, bool>? filter = null, Orden? orden = null, TiposDeDatos? consulta = null)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetCantidad(conn, filter, orden, consulta);
            }
        }
        public List<ProductosListDto>? GetLista(int currentPage, int pageSize, Orden orden, Func<ProductosListDto, bool>? filter = null, TiposDeDatos? consulta = null)
        {
            using(var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetLista(conn, currentPage, pageSize, orden, filter, consulta);
            }
        }
        public List<Productos>? GetListaCombo(Func<Productos, bool>? filter = null)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetListaCombo(conn, filter);
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
        public Productos? GetProductoPorId(TipoProducto tipoProducto, int productoId)
        {
            using(var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetProductoPorId(conn, tipoProducto, productoId);
            }
        }

        public int GetCantidad(Func<Productos, bool>? filter = null)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetCantidad(conn, filter);
            }
        }

        public List<Productos>? GetListaProductos(TipoProducto tipoProducto)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetListaProductos(conn, tipoProducto);
            }
        }
    }
}
