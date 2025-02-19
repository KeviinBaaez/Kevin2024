using Kevin2024.Datos.Interfaces;
using Kevin2024.Datos.Repositorios;
using Kevin2024.Entidades;
using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using Kevin2024.Servicios.Interfaces;
using System.Data.SqlClient;

namespace Kevin2024.Servicios.Servicios
{
    public class ServiciosCombos : IServiciosCombos
    {
        private readonly IRepositorioCombos? _repositorio;
        private readonly IRepositorioDetallesCombos? _repositorioDetallesCombos;
        private readonly string? _cadena;

        public ServiciosCombos(IRepositorioCombos? repositorio, IRepositorioDetallesCombos? repositorioDetalles, string? cadena)
        {
            _repositorio = repositorio ?? throw new ApplicationException("Dependencias no cargadas!!");
            _repositorioDetallesCombos = repositorioDetalles?? throw new ApplicationException("Dependencias no cargadas!!");
            _cadena = cadena;
        }

        public void Guardar(Combo combo)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        if (combo.ProductoId == 0)
                        {
                            _repositorio!.Agregar(conn, combo, tran);
                            foreach (var item in combo.DetallesCombos)
                            {
                                item.ComboId = combo.ProductoId;
                                _repositorioDetallesCombos!.Agregar(item, conn, tran);
                            }
                        }
                        else
                        {
                            _repositorio!.Editar(conn, combo, tran);
                            _repositorioDetallesCombos!.Borrar(combo.ProductoId, conn, tran);
                            foreach (var item in combo.DetallesCombos)
                            {
                                item.ComboId = combo.ProductoId;
                                _repositorioDetallesCombos.Agregar(item, conn, tran);
                            }
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

        public bool Existe(Combo combo)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.Existe(conn, combo);
            }
        }
        public void Borrar(int productoId)
        {
            using(var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
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
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.EstaRelacionado(conn, productoId);

            }
        }



        public int GetCantidad(Func<ComboListDto, bool>? filter)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetCantidad(conn, filter);
            }
        }

        public Combo GetComboPorId(int productoId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetProductoPorId(conn, productoId);
            }
        }

        public List<ComboListDto>? GetLista(int currentPage, int pageSize, Orden orden, Func<ComboListDto, bool>? filter)
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


    }
}
