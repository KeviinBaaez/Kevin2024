using Dapper;
using Kevin2024.Datos.Interfaces;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using System.Data.SqlClient;

namespace Kevin2024.Datos.Repositorios
{
    public class RepositorioTamanios : IRepositorioTamanios
    {
        public RepositorioTamanios()
        {}

        public void Agregar(SqlConnection conn, Tamanio tamanio, SqlTransaction tran)
        {
            string insertQuery = @"INSERT INTO Tamaños (Descripcion, Cantidad) 
                                    VALUES (@Descripcion, @Cantidad);
                                    SELECT CAST(SCOPE_IDENTITY() AS INT)";
            int primaryKey = conn.QuerySingle<int>(insertQuery, new
            {
                TamanioId = tamanio.TamanioId,
                Descripcion = tamanio.Descripcion,
                Cantidad = tamanio.Cantidad
            }, tran);
            if(primaryKey > 0)
            {
                tamanio.TamanioId = primaryKey;
                return;
            }
            throw new Exception("No se pudo agregar el tamaño");

        }

        public void Borrar(SqlConnection conn, int tamanioId, SqlTransaction tran)
        {
            string deleteQuery = @"DELETE FROM Tamaños WHERE TamanioId=@TamanioId";
            int registrosAfectados = conn.Execute(deleteQuery, new { tamanioId }, tran);
            if(registrosAfectados == 0)
            {
                throw new Exception("No se pudo eliminar el tamaño");
            }
        }

        public void Editar(SqlConnection conn, Tamanio tamanio, SqlTransaction tran)
        {
            string updateQuery = @"UPDATE Tamaños SET Descripcion=@Descripcion, Cantidad=@Cantidad 
                                    WHERE TamanioId=@TamanioId";
            int registrosAfectados = conn.Execute(updateQuery, tamanio, tran);
            if (registrosAfectados == 0)
            {
                throw new Exception("No se pudo editar el tamaño");
            }
        }

        public bool EstaRelacionado(SqlConnection conn, int tamanioId)
        {
            string selectQuery = @"SELECT COUNT(*) FROM Bebidas 
                                    WHERE TamanioId=@TamanioId";
            return conn.QuerySingle<int>(selectQuery, new { tamanioId }) > 0;
        }

        public bool Existe(SqlConnection conn, Tamanio tamanio)
        {
            string selectQuery = @"SELECT COUNT(*) FROM Tamaños";
            string finalQuery = string.Empty;
            string conditional = string.Empty;
            if(tamanio.TamanioId == 0)
            {
                conditional = " WHERE Descripcion=@Descripcion";
            }
            else
            {
                conditional = " WHERE Descripcion=@Descripcion AND TamanioId<>@TamanioId";
            }
            finalQuery = string.Concat(selectQuery, conditional);
            return conn.QuerySingle<int>(finalQuery, tamanio) > 0;
        }

        public int GetCantidad(SqlConnection conn, Func<Tamanio, bool>? filter)
        {
            var lista = new List<Tamanio>();
            string selectQuery = @"SELECT TamanioId AS TamanioId, 
                                    Descripcion, Cantidad FROM Tamaños";
            var listaTamanios = conn.Query<Tamanio>(selectQuery).ToList();
            lista.AddRange(listaTamanios);
            if(filter != null)
            {
                listaTamanios = listaTamanios.Where(filter).ToList();
            }
            return listaTamanios.Count;
        }

        public List<Tamanio>? GetLista(SqlConnection conn, int currentPage, int pageSize, Orden orden, Func<Tamanio, bool>? filter)
        {
            var lista = new List<Tamanio>();
            string finalQuery = string.Empty;
            string ordenQuery = string.Empty;
            string selectQuery = @"SELECT TamanioId AS TamanioId, 
                                    Descripcion, Cantidad From Tamaños";
            if(orden == Orden.OrdenAZ)
            {
                ordenQuery = " ORDER BY Descripcion";
            }
            if(orden == Orden.OrdenZA)
            {
                ordenQuery = " ORDER BY Descripcion DESC";
            }
            finalQuery = string.Concat(selectQuery, ordenQuery);
            var listaTamanios = conn.Query<Tamanio>(finalQuery).ToList();
            lista.AddRange(listaTamanios);
            if (filter != null)
            {
                listaTamanios = listaTamanios.Where(filter).ToList();
            }
            return listaTamanios;
        }

        public List<Tamanio> GetLista(SqlConnection conn)
        {
            var lista = new List<Tamanio>();
            string selectQuery = @"SELECT TamanioId AS TamanioId, 
                                    Descripcion, Cantidad 
                                    FROM Tamaños";
            var listaTamanios = conn.Query<Tamanio>(selectQuery).ToList();
            lista.AddRange(listaTamanios);
            return listaTamanios; 
        }

        public int GetPaginaPorRegistro(SqlConnection conn, string descripcion, int pageSize)
        {
            string positionQuery = @"WITH TamanioOrdenado AS (SELECT ROW_NUMBER() 
                                    OVER (ORDER BY Descripcion) AS RowNum, Descripcion 
                                        FROM Tamaños)
                                    SELECT RowNum FROM TamanioOrdenado
                                    WHERE Descripcion=@Descripcion";
            int position = conn.ExecuteScalar<int>(positionQuery, new { Descripcion = descripcion});
            return (int)Math.Ceiling((decimal)position / pageSize);
        }
    }
}
