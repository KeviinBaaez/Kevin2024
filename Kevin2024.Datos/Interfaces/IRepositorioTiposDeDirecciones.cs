using Kevin2024.Entidades.Entidades;
using System.Data.SqlClient;

namespace Kevin2024.Datos.Interfaces
{
    public interface IRepositorioTiposDeDirecciones
    {
        List<TipoDireccion> GetLista(SqlConnection conn);
        TipoDireccion GetTipoDireccionPorId(SqlConnection conn, int tipoDireccionId);
    }
}
