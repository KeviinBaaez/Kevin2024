using Dapper;
using Kevin2024.Datos.Interfaces;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using System.Data.SqlClient;

namespace Kevin2024.Datos.Repositorios
{
    public class RepositorioCategorias : IRepositorioCategorias
    {
        public RepositorioCategorias()
        { }
        public void Agregar(SqlConnection conn, Categorias categoria, SqlTransaction tran)
        {
            string insertQuery = @"INSERT INTO Categorias (Descripcion) 
                                VALUES (@Descripcion);
                                SELECT CAST(SCOPE_IDENTITY() AS INT)";
            int primarykey = conn.QuerySingle<int>(insertQuery, new
            {
                CategoriaId = categoria.CategoriaId,
                Descripcion = categoria.Descripcion
            }, tran);
            if (primarykey > 0)
            {
                categoria.CategoriaId = primarykey;
                return;
            }
            throw new Exception("No se pudo agregar la categoria");
        }

        public void Editar(SqlConnection conn, Categorias categoria, SqlTransaction tran)
        {
            string updateQuery = @"UPDATE Categorias SET Descripcion=@Descripcion 
                                    WHERE CategoriaId=@CategoriaId";
            int registrosAfectados = conn.Execute(updateQuery, categoria, tran);
            if (registrosAfectados == 0)
            {
                throw new Exception("No se pudo editar la categoria");
            }
        }

        public void Borrar(SqlConnection conn, int categoriaId, SqlTransaction tran)
        {
            string deleteQuery = @"DELETE FROM Categorias WHERE CategoriaId=@CategoriaId";
            int registrosAfectados = conn.Execute(deleteQuery, new { categoriaId }, tran);
            if (registrosAfectados == 0)
            {
                throw new Exception("No se pudo elimar la categoria");
            }
        }

        public bool EstaRelacionado(SqlConnection conn, int categoriaId)
        {
            string selectQuery = @"SELECT COUNT(*) FROM Bebidas 
                                    WHERE CategoriaId=@categoriaId";
            return conn.QuerySingle<int>(selectQuery, new { categoriaId }) > 0;
        }

        public bool Existe(SqlConnection conn, Categorias categoria)
        {
            string selectQuery = @"SELECT COUNT(*) FROM Categorias";
            string finalQuery = string.Empty;
            string conditional = string.Empty;
            if (categoria.CategoriaId == 0)
            {
                conditional = " WHERE Descripcion = @Descripcion";
            }
            else
            {
                conditional = " WHERE Descripcion = @Descripcion AND CategoriaId<>@CategoriaId";
            }
            finalQuery = string.Concat(selectQuery, conditional);
            return conn.QuerySingle<int>(finalQuery, categoria) > 0;
        }

        public int GetCantidad(SqlConnection conn, Func<Categorias, bool>? filter)
        {
            var lista = new List<Categorias>();
            string selectQuery = @"SELECT CategoriaId, Descripcion FROM Categorias";
            var listaCategorias = conn.Query<Categorias>(selectQuery).ToList();
            lista.AddRange(listaCategorias);
            if (filter != null)
            {
                lista = lista.Where(filter).ToList();
            }
            return lista.Count;
        }

        public List<Categorias>? GetLista(SqlConnection conn, int currentPage, int pageSize, Orden orden, Func<Categorias, bool>? filter)
        {
            var lista = new List<Categorias>();
            var finalQuery = string.Empty;
            var ordenQuery = string.Empty;
            string selectQuery = @"SELECT CategoriaId, Descripcion From Categorias";

            if (orden == Orden.OrdenAZ)
            {
                ordenQuery = @" ORDER BY Descripcion";
            }
            if (orden == Orden.OrdenZA)
            {
                ordenQuery = @" ORDER BY Descripcion Desc";
            }
            finalQuery = string.Concat(selectQuery, ordenQuery);
            var listaCategorias = conn.Query<Categorias>(finalQuery).ToList();
            lista.AddRange(listaCategorias);
            if (filter != null)
            {
                lista = lista.Where(filter).ToList();
            }
            return lista.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
        }

        public List<Categorias>? GetLista(SqlConnection conn)
        {
            string selectQuery = @"SELECT CategoriaId, Descripcion From Categorias";
            return conn.Query<Categorias>(selectQuery).ToList();
        }

        public int GetPaginaPorRegistro(SqlConnection conn, string descripcion, int pageSize)
        {
            string positionQuery = @"WITH CategoriasOrdenadas As (SELECT ROW_NUMBER() 
                            OVER (ORDER BY Descripcion) As RowNum, Descripcion FROM Categorias)
                            SELECT RowNum FROM CategoriasOrdenadas 
                                WHERE Descripcion=@Descripcion";
            int position = conn.ExecuteScalar<int>(positionQuery, new { Descripcion = descripcion });
            return (int)Math.Ceiling((decimal)position / pageSize);

        }
    }
}
