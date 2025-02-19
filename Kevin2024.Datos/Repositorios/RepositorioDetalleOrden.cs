using Dapper;
using Kevin2024.Datos.Interfaces;
using Kevin2024.Entidades.Entidades;
using System.Data.SqlClient;

namespace Kevin2024.Datos.Repositorios
{
    public class RepositorioDetalleOrden : IRepositorioDetalleOrden
    {
        public void Agregar(DetalleOrden detalle, SqlConnection conn, SqlTransaction tran)
        {
            string insertQuery = @"INSERT INTO DetalleOrden 
                (OrdenId, ComboId, ProductoId, Cantidad, Precio) 
                VALUES (@OrdenId, @ComboId, @ProductoId, @Cantidad, @Precio); 
                SELECT CAST(SCOPE_IDENTITY() as int)";

            int primaryKey = conn.QuerySingle<int>(insertQuery, detalle, tran);
            if (primaryKey > 0)
            {
                detalle.DetalleOrdenId = primaryKey;
                return;
            }
            throw new Exception("No se pudo agregar el detalle de orden");
        }
    }
}
