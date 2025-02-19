using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Entidades;
using System.Data.SqlClient;

namespace Kevin2024.Datos.Interfaces
{
    public interface IRepositorioConsulta
    {
        List<ProductosListDto> GetLista(SqlConnection conn, TiposDeDatos? consulta);
    }
}
