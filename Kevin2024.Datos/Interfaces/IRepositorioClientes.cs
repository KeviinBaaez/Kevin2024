using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using System.Data.SqlClient;

namespace Kevin2024.Datos.Interfaces
{
    public interface IRepositorioClientes
    {
        void Agregar(Cliente cliente, SqlConnection conn, SqlTransaction tran);
        void Borrar(int clienteId, SqlConnection conn, SqlTransaction tran);
        void Editar(Cliente cliente, SqlConnection conn, SqlTransaction tran);
        bool Existe(Cliente cliente, SqlConnection conn);
        int GetCantidad(SqlConnection conn, Func<ClienteListDto, bool>? filter, TiposDeDatos? generoFiltro);
        Cliente? GetClientePorId(int clienteId, SqlConnection conn);
        List<Cliente> GetClientes(SqlConnection conn);
        ClienteDetalleDto? GetDetalleCliente(int clienteId, SqlConnection conn);
        List<ClienteListDto> GetLista(SqlConnection conn, int currentPage, int pageSize, Orden orden, Func<ClienteListDto, bool>? filter);
        List<Cliente> GetListaCombo(SqlConnection conn);
        int GetPaginaPorRegistro(SqlConnection conn, object nombre, int pageSize);
    }
}
