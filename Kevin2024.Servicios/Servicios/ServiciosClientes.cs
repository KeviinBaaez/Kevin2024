using Kevin2024.Datos.Interfaces;
using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using Kevin2024.Entidades.ViewModels;
using Kevin2024.Servicios.Interfaces;
using System.Data.SqlClient;

namespace Kevin2024.Servicios.Servicios
{
    public class ServiciosClientes : IServiciosClientes
    {
        private readonly IRepositorioClientes _repositorioClientes;
        private readonly IRepositorioDirecciones _repositorioDirecciones;
        private readonly IRepositorioTelefonos _repositorioTelefonos;
        private readonly IRepositorioClientesDirecciones _repositorioClientesDirecciones;
        private readonly IRepositorioClientesTelefonos _repositorioClientesTelefonos;
        private readonly string _cadena;

        public ServiciosClientes(
            IRepositorioClientes repositorioClientes,
            IRepositorioDirecciones repositorioDirecciones,
            IRepositorioTelefonos repositorioTelefonos,
            IRepositorioClientesDirecciones repositorioClientesDirecciones,
            IRepositorioClientesTelefonos repositorioClientesTelefonos,
            string cadena)
        {
            _repositorioClientes = repositorioClientes;
            _repositorioDirecciones = repositorioDirecciones;
            _repositorioTelefonos = repositorioTelefonos;
            _repositorioClientesDirecciones = repositorioClientesDirecciones;
            _repositorioClientesTelefonos = repositorioClientesTelefonos;
            _cadena = cadena;
        }

        public void Guardar(Cliente cliente)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        if (cliente.ClienteId == 0)
                        {
                            _repositorioClientes.Agregar(cliente, conn, tran);
                        }
                        else
                        {
                            _repositorioClientes.Editar(cliente, conn, tran);
                            _repositorioClientesDirecciones.BorrarPorClienteId(cliente.ClienteId, conn, tran);
                            _repositorioClientesTelefonos.BorrarPorClienteId(cliente.ClienteId, conn, tran);
                        }

                        foreach (var clienteDireccion in cliente.ClienteDirecciones)
                        {
                            int direccionIdExistente = _repositorioDirecciones
                                .GetDireccionIdIfExists(clienteDireccion.Direccion, conn, tran);
                            if (direccionIdExistente == 0)
                            {
                                _repositorioDirecciones.Agregar(clienteDireccion.Direccion, conn, tran);
                                clienteDireccion.DireccionId = clienteDireccion.Direccion.DireccionId;
                            }
                            else
                            {
                                clienteDireccion.DireccionId = direccionIdExistente;
                            }

                            clienteDireccion.ClienteId = cliente.ClienteId;
                            _repositorioClientesDirecciones.Agregar(clienteDireccion, conn, tran);
                        }

                        foreach (var clienteTelefono in cliente.ClienteTelefonos)
                        {
                            int telefonoIdExistente = _repositorioTelefonos
                                .GetTelefonoIdIfExist(clienteTelefono.Telefono, conn, tran);
                            if (clienteTelefono.Telefono.TelefonoId == 0)
                            {
                                _repositorioTelefonos.Agregar(clienteTelefono.Telefono, conn, tran);
                            }
                            clienteTelefono.ClienteId = cliente.ClienteId;
                            clienteTelefono.TelefonoId = clienteTelefono.Telefono.TelefonoId;
                            _repositorioClientesTelefonos.Agregar(clienteTelefono, conn, tran);
                        }

                        tran.Commit();
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }

        public void Borrar(int clienteId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        _repositorioClientesDirecciones.BorrarPorClienteId(clienteId, conn, tran);
                        _repositorioClientesTelefonos.BorrarPorClienteId(clienteId, conn, tran);
                        _repositorioClientes.Borrar(clienteId, conn, tran);

                        tran.Commit();
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }

        public int GetCantidad(Func<ClienteListDto, bool>? filter, TiposDeDatos? generoFiltro = null)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                return _repositorioClientes.GetCantidad(conn, filter, generoFiltro);
            }
        }

        public Cliente? GetClientePorId(int clienteId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                var cliente = _repositorioClientes.GetClientePorId(clienteId, conn);
                if (cliente != null)
                {
                    cliente.ClienteDirecciones = _repositorioClientesDirecciones.GetDireccionesPorClienteId(clienteId, conn);
                    cliente.ClienteTelefonos = _repositorioClientesTelefonos.GetTelefonosPorClienteId(clienteId, conn);
                }
                return cliente;
            }
        }

        public List<ClienteListDto> GetLista(int currentPage, int pageSize, Orden orden, Func<ClienteListDto, bool>? filter)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorioClientes.GetLista(conn, currentPage, pageSize, orden, filter);
            }
        }

        public bool Existe(Cliente cliente)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorioClientes.Existe(cliente, conn);
            }

        }

        public ClienteDetalleDto? GetDetalleCliente(int clienteId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorioClientes.GetDetalleCliente(clienteId, conn);
            }

        }

        public List<Cliente> GetClientes()
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorioClientes.GetClientes(conn);
            }

        }

        public int GetPaginaPorRegistro(object nombre, int pageSize)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorioClientes!.GetPaginaPorRegistro(conn, nombre, pageSize);
            }
        }

        public List<Direccion> GetListaDireccionesPorCliente(int clienteId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorioClientesDirecciones.GetListaDireccionesPorCliente(clienteId, conn);
            }
        }

        public List<Telefonos> GetListaTelefonosPorCliente(int clienteId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorioClientesTelefonos.GetListaTelefonosPorCliente(clienteId, conn);
            }
        }

        public List<Cliente> GetListaCombo()
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorioClientes.GetListaCombo(conn);
            }
        }

        public Direccion? GetDireccionPorId(int direccionId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorioDirecciones!.GetDireccionPorId(direccionId, conn);
            }
        }

        public Telefonos GetTelefonoPorId(int telefonoId)
        {
            using(var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorioTelefonos!.GetTelefonoPorId(telefonoId, conn)!;
            }
        }
    }
}
