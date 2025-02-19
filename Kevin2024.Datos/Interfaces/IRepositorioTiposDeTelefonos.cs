using Kevin2024.Entidades.Entidades;
using System.Data.SqlClient;

namespace Kevin2024.Datos.Interfaces
{
    public interface IRepositorioTiposDeTelefonos
    {
        List<TipoTelefono> GetLista(SqlConnection conn);
        TipoTelefono GetTipoTelefonoPorId(int tipoTelefonoId, SqlConnection conn);
    }
}
