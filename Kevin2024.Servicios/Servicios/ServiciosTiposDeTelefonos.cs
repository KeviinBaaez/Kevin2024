using Kevin2024.Datos.Interfaces;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Servicios.Interfaces;
using System.Data.SqlClient;

namespace Kevin2024.Servicios.Servicios
{
    public class ServiciosTiposDeTelefonos : IServiciosTiposDeTelefonos
    {
        private readonly IRepositorioTiposDeTelefonos _repositorio;
        private readonly string _cadena;
        public ServiciosTiposDeTelefonos(IRepositorioTiposDeTelefonos repositorio, string cadena)
        {
            _repositorio = repositorio;
            _cadena = cadena;
        }

        public List<TipoTelefono> GetLista()
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio.GetLista(conn);
            }
        }

        public TipoTelefono GetTipoTelefonoPorId(int tipoTelefonoId)
        {
            using(var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio.GetTipoTelefonoPorId(tipoTelefonoId, conn);
            }
        }
    }
}
