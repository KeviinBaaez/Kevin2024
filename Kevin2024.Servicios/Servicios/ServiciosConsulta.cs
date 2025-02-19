using Kevin2024.Datos.Interfaces;
using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Servicios.Interfaces;
using System.Data.SqlClient;

namespace Kevin2024.Servicios.Servicios
{
    public class ServiciosConsulta : IServicioConsulta
    {
        private readonly IRepositorioConsulta? _repositorio;
        private readonly string? _cadena;

        public ServiciosConsulta(IRepositorioConsulta? repositorio, string? cadena)
        {
            _repositorio = repositorio;
            _cadena = cadena;
        }

        public List<ProductosListDto> GetLista(TiposDeDatos? consulta)
        {
            using(var conn= new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetLista(conn, consulta);
            }
        }
    }
}
