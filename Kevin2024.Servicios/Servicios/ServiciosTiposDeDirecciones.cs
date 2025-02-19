using Kevin2024.Datos.Interfaces;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Servicios.Interfaces;
using System.Data.SqlClient;

namespace Kevin2024.Servicios.Servicios
{
    public class ServiciosTiposDeDirecciones : IServiciosTiposDeDirecciones
    {
        private readonly IRepositorioTiposDeDirecciones _repositorio;
        private readonly string _cadena;
        public ServiciosTiposDeDirecciones(IRepositorioTiposDeDirecciones repositorio, string cadena)
        {
            _repositorio = repositorio;
            _cadena = cadena;
        }

        public List<TipoDireccion> GetLista()
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio.GetLista(conn);
            }
        }

        public TipoDireccion GetTipoDireccionPorId(int tipoDireccionId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio.GetTipoDireccionPorId(conn, tipoDireccionId);
            }
        }
    }
}
