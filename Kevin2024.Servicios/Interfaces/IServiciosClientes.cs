using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using Kevin2024.Entidades.ViewModels;
using System.Data.SqlClient;

namespace Kevin2024.Servicios.Interfaces
{
    public interface IServiciosClientes
    {
        void Borrar(int clienteId);
        bool Existe(Cliente cliente);
        List<ClienteListDto> GetLista(int currentPage, int pageSize, Orden orden, Func<ClienteListDto, bool>? filter);
        void Guardar(Cliente cliente);
        Cliente? GetClientePorId(int clienteId);
        int GetCantidad(Func<ClienteListDto, bool>? filter, TiposDeDatos? generoFiltro = null);
        ClienteDetalleDto? GetDetalleCliente(int clienteId);
        List<Cliente> GetClientes();
        int GetPaginaPorRegistro(object nombre, int pageSize);
        List<Direccion> GetListaDireccionesPorCliente(int clienteId);
        List<Telefonos> GetListaTelefonosPorCliente(int clienteId);
        List<Cliente> GetListaCombo();
        Direccion? GetDireccionPorId(int direccionId);

        Telefonos GetTelefonoPorId(int telefonoId);
    }
}
