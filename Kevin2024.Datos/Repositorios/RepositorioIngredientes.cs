using Dapper;
using Kevin2024.Datos.Interfaces;
using Kevin2024.Entindades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kevin2024.Datos.Repositorios
{
    public class RepositorioIngredientes : IRepositorioIngredinetes
    {
        public RepositorioIngredientes()
        {
            
        }

        public List<Ingredientes> GetLista(SqlConnection conn)
        {
            string selectQuery = @"SELECT IngredientesId, Nombre, Suspendido 
                                    FROM Ingredientes 
                                        ORDER BY Nombre";
            return conn.Query<Ingredientes>(selectQuery).ToList();   
        }
    }
}
