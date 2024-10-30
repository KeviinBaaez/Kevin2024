using Kevin2024.Entindades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kevin2024.Datos.Interfaces
{
    public interface IRepositorioIngredinetes
    {
        List<Ingredientes> GetLista(SqlConnection conn);
    }
}
