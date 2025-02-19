using Dapper;
using Kevin2024.Datos.Interfaces;
using Kevin2024.Entidades.Entidades;
using System.Data.SqlClient;

namespace Kevin2024.Datos.Repositorios
{
    public class RepositorioDetallesCombos : IRepositorioDetallesCombos
    {
        public void Agregar(DetallesCombos item, SqlConnection conn, SqlTransaction tran)
        {
            string insertQuery = @"INSERT INTO DetallesCombos 
                                (ComboId, ProductoId, Cantidad)
                                VALUES(@ComboId, @ProductoId, @Cantidad);
                                SELECT CAST(SCOPE_IDENTITY() AS int)";
            int primaryKey = conn.QuerySingle<int>(insertQuery, item, tran);
            if(primaryKey > 0)
            {
                item.DetalleComboId = primaryKey;
                return;
            }
            throw new Exception("No se pudo agregar el combo");
        }

        public void Borrar(int ProductoId, SqlConnection conn, SqlTransaction tran)
        {
            string deleteQuery = @"DELETE FROM DetallesCombos WHERE ComboId = @ProductoId";
            int registrosAfectados = conn.Execute(deleteQuery, new {ProductoId }, tran);
            if(registrosAfectados == 0)
            {
                throw new Exception("No se puedo borrar el producto del combo");
            }
        }
    }
}
