

using System.Data.SqlClient;

namespace Kevin2024.Datos.Interfaces
{
    public interface IRepositorioLogin
    {
        bool Conectar(SqlConnection conn, string usuario, string clave);
    }
}