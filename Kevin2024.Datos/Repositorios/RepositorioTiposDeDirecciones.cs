using Dapper;
using Kevin2024.Datos.Interfaces;
using Kevin2024.Entidades.Entidades;
using System.Data.SqlClient;

namespace Kevin2024.Datos.Repositorios
{
    public class RepositorioTiposDeDirecciones : IRepositorioTiposDeDirecciones
    {
        public List<TipoDireccion> GetLista(SqlConnection conn)
        {
            var selectQuery = @"SELECT TipoDireccionId, Descripcion FROM TiposDirecciones
                    ORDER BY Descripcion";
            return conn.Query<TipoDireccion>(selectQuery).ToList();
        }

        public TipoDireccion GetTipoDireccionPorId(SqlConnection conn, int tipoDireccionId)
        {
            var selectQuery = @"SELECT TipoDireccionId, Descripcion FROM TiposDirecciones
                    WHERE TipoDireccionId = @TipoDireccionId";
            return conn.QuerySingle<TipoDireccion>(selectQuery, new { TipoDireccionId = tipoDireccionId});
        }
    }
}
