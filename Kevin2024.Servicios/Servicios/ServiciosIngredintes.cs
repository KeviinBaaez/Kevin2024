using Kevin2024.Datos.Interfaces;
using Kevin2024.Entindades;
using Kevin2024.Servicios.Interfaces;
using System.Data.SqlClient;

namespace Kevin2024.Servicios.Servicios
{
    public class ServiciosIngredintes : IServiciosIngredientes
    {
        private readonly IRepositorioIngredinetes? _repositorio;
        private readonly string? _cadena;

        public ServiciosIngredintes(IRepositorioIngredinetes? repositorio, string? cadena)
        {
            _repositorio = repositorio ?? throw new ApplicationException("Dependencias No Cargadas!!");
            _cadena = cadena;
        }

        public List<Ingredientes> GetLista()
        {
            using(var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetLista(conn);
            }
        }
    }
}
