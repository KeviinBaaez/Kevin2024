using Dapper;
using Kevin2024.Datos.Interfaces;
using Kevin2024.Entidades.Entidades;
using System.Data.SqlClient;

namespace Kevin2024.Datos.Repositorios
{
    public class RepositorioTiposDeTelefonos : IRepositorioTiposDeTelefonos
    {
        public List<TipoTelefono> GetLista(SqlConnection conn)
        {
            var selectQuery = @"SELECT TipoTelefonoId, Descripcion FROM TiposTelefonos
                    ORDER BY Descripcion";
             return conn.Query<TipoTelefono>(selectQuery).ToList();
        }

        public TipoTelefono GetTipoTelefonoPorId(int tipoTelefonoId, SqlConnection conn)
        {
            var selectQuery = @"SELECT * FROM TiposTelefonos 
                                    WHERE TipoTelefonoId = @TipoTelefonoId";
            return conn.QuerySingle<TipoTelefono>(selectQuery, new { TipoTelefonoId = tipoTelefonoId });
        }
    }
}
