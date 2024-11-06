using Dapper;
using Kevin2024.Datos.Interfaces;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;

namespace Kevin2024.Datos.Repositorios
{
    public class RepositorioMarcas : IRepositorioMarcas
    {
        public RepositorioMarcas()
        {
        }
        public void Agregar(SqlConnection conn, Marcas marca, SqlTransaction tran)
        {
            string insertQuery = @"INSERT INTO Marcas (Nombre) 
                                VALUES (@Nombre);
                                SELECT CAST(SCOPE_IDENTITY() AS INT)";
            int primarykey = conn.QuerySingle<int>(insertQuery, new 
            {
                MarcaId = marca.MarcaId,
                Nombre = marca.Nombre
            }, tran);
            if(primarykey > 0)
            {
                marca.MarcaId = primarykey;
                return;
            }
            throw new Exception("No se pudo agregar la marca");
        }

        public void Editar(SqlConnection conn, Marcas marca, SqlTransaction tran)
        {
            string updateQuery = @"UPDATE Marcas SET Nombre=@Nombre 
                                    WHERE MarcaId=@MarcaId";
            int registrosAfectados = conn.Execute(updateQuery, marca, tran);
            if (registrosAfectados == 0)
            {
                throw new Exception("No se pudo editar la marca");
            }
        }

        public void Borrar(SqlConnection conn, int marcaId, SqlTransaction tran)
        {
            string deleteQuery = @"DELETE FROM Marcas WHERE MarcaId=@MarcaId";
            int registrosAfectados = conn.Execute(deleteQuery, new {marcaId}, tran);
            if(registrosAfectados == 0)
            {
                throw new Exception("No se pudo elimar la marca");
            }
        }

        public bool EstaRelacionado(SqlConnection conn, int marcaId)
        {
            string selectQuery = @"SELECT COUNT(*) FROM Productos 
                                    WHERE MarcaId=@marcaId";
            return conn.QuerySingle<int>(selectQuery, new {marcaId}) > 0;   
        }

        public bool Existe(SqlConnection conn, Marcas marca)
        {
            string selectQuery = @"SELECT COUNT(*) FROM Marcas";
            string finalQuery = string.Empty;
            string conditional = string.Empty;
            if(marca.MarcaId == 0)
            {
                conditional = " WHERE Nombre = @Nombre";
            }
            else
            {
                conditional = " WHERE Nombre = @Nombre AND MarcaId<>@MarcaId";
            }
            finalQuery = string.Concat(selectQuery, conditional);
            return conn.QuerySingle<int>(finalQuery, marca) > 0;
        }

        public int GetCantidad(SqlConnection conn, Func<Marcas, bool>? filter)
        {
            var lista = new List<Marcas>();
            string selectQuery = @"SELECT MarcaId, Nombre FROM Marcas";
            var listaMarcas = conn.Query<Marcas>(selectQuery).ToList();
            lista.AddRange(listaMarcas);
            if(filter != null)
            {
                lista = lista.Where(filter).ToList();
            }
            return lista.Count;
        }

        public List<Marcas>? GetLista(SqlConnection conn, int currentPage, int pageSize, Orden orden, Func<Marcas, bool>? filter)
        {
            var lista = new List<Marcas>();
            var finalQuery = string.Empty;
            var ordenQuery = string.Empty;
            string selectQuery = @"SELECT MarcaId, Nombre From Marcas";
            
            if(orden == Orden.OrdenAZ)
            {
                ordenQuery = @" ORDER BY Nombre";
            }
            if(orden == Orden.OrdenZA)
            {
                ordenQuery = @" ORDER BY Nombre Desc";
            }
            finalQuery = string.Concat(selectQuery, ordenQuery);
            var listaMarcas = conn.Query<Marcas>(finalQuery).ToList();
            lista.AddRange(listaMarcas);
            if (filter != null )
            {
                lista = lista.Where(filter).ToList();
            }
            return lista.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
        }

        public List<Marcas>? GetLista(SqlConnection conn)
        {
            string selectQuery = @"SELECT MarcaId, Nombre From Marcas";
            return conn.Query<Marcas>(selectQuery).ToList();
        }

        public int GetPaginaPorRegistro(SqlConnection conn, string nombre, int pageSize)
        {
            string positionQuery = @"WITH MarcasOrdenadas As (SELECT ROW_NUMBER() 
                            OVER (ORDER BY Nombre) As RowNum, Nombre FROM Marcas)
                            SELECT RowNum FROM MarcasOrdenadas 
                                WHERE Nombre=@Nombre";
            int position = conn.ExecuteScalar<int>(positionQuery, new { Nombre = nombre });
            return (int)Math.Ceiling((decimal)position/pageSize);   

        }
    }
}
