using Kevin2024.Datos.Interfaces;
using Kevin2024.Servicios.Interfaces;
using System.Data.SqlClient;

namespace Kevin2024.Servicios.Servicios
{
    public class ServiciosLogin : IServiciosLogin
    {
        private readonly IRepositorioLogin? _repositorio;
        private readonly string? _cadena;

        public ServiciosLogin(IRepositorioLogin repositorio, string? cadena)
        {
            _repositorio = repositorio ?? throw new ApplicationException("Dependecias no cargadas");
            _cadena = cadena;
        }

        public bool Conectar(string usuario, string clave)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.Conectar(conn, usuario, clave);
            }
        }
    }
}
