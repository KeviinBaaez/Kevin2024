using Dapper;
using Kevin2024.Datos.Interfaces;
using Kevin2024.Entidades.Entidades;
using System.Data.SqlClient;

namespace Kevin2024.Datos.Repositorios
{
    public class RepositorioDetallesVentas : IRepositorioDetallesVentas
    {
        public void Agregar(DetalleVenta detalle, SqlConnection conn, SqlTransaction tran)
        {
            string insertQuery = @"INSERT INTO DetallesVentas 
                (VentaId, ProductoId, ComboId, Cantidad, Precio) 
                VALUES (@VentaId, @ProductoId, @ComboId, @Cantidad, @Precio); 
                SELECT CAST(SCOPE_IDENTITY() as int)";

            int primaryKey = conn.QuerySingle<int>(insertQuery, detalle, tran);
            if (primaryKey > 0)
            {
                detalle.DetalleVentaId = primaryKey;
                return;
            }
            throw new Exception("No se pudo agregar el detalle de venta");
        }
    }
}
