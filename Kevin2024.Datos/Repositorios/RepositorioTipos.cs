using Dapper;
using Kevin2024.Datos.Interfaces;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using System.Data.SqlClient;

namespace Kevin2024.Datos.Repositorios
{
    public class RepositorioTipos : IRepositorioTipos
    {

        public void Agregar(SqlConnection conn, Tipos tipo, TiposDeDatos tiposDeDatos, SqlTransaction tran)
        {
            int primarykey = 0;
            string insertQuery = string.Empty;
            if (tipo == Tipos.Genero)
            {
                insertQuery = @"INSERT INTO Generos (Descripcion) 
                            VALUES(@Descripcion) SELECT CAST(SCOPE_IDENTITY() AS int)";
                int primaryKey = conn.QuerySingle<int>(insertQuery, new
                {
                    GeneroId = tiposDeDatos.TipoId,
                    Descripcion = tiposDeDatos.Descripcion
                }, tran);
            }
            if (tipo == Tipos.Marcas)
            {
                insertQuery = @"INSERT INTO Marcas (Nombre) 
                                VALUES (@Nombre);
                                SELECT CAST(SCOPE_IDENTITY() AS INT)";
                primarykey = conn.QuerySingle<int>(insertQuery, new
                {
                    MarcaId = tiposDeDatos.TipoId,
                    Nombre = tiposDeDatos.Descripcion
                }, tran);

            }
            if (tipo == Tipos.Categoria)
            {
                insertQuery = @"INSERT INTO Categorias (Descripcion) 
                                VALUES (@Descripcion);
                                SELECT CAST(SCOPE_IDENTITY() AS INT)";
                primarykey = conn.QuerySingle<int>(insertQuery, new
                {
                    CategoriaId = tiposDeDatos.TipoId,
                    Descripcion = tiposDeDatos.Descripcion
                }, tran);
            }
            if (tipo == Tipos.Tamanio)
            {
                insertQuery = @"INSERT INTO Tamaños (Descripcion) 
                                    VALUES (@Descripcion);
                                    SELECT CAST(SCOPE_IDENTITY() AS INT)";
                primarykey = conn.QuerySingle<int>(insertQuery, new
                {
                    TamanioId = tiposDeDatos.TipoId,
                    Descripcion = tiposDeDatos.Descripcion,
                }, tran);
            }
            if (primarykey > 0)
            {
                tiposDeDatos.TipoId = primarykey;
                return;
            }
            throw new Exception("No se pudo agregar el registro");

        }

        public void Borrar(SqlConnection conn, Tipos tipo, int tipoId, SqlTransaction tran)
        {
            var deleteQuery = string.Empty;
            if (tipo == Tipos.Genero)
            {
                deleteQuery = @"DELETE FROM Generos WHERE GeneroId=@TipoId";

            }
            if (tipo == Tipos.Marcas)
            {
                deleteQuery = @"DELETE FROM Marcas WHERE MarcaId=@TipoId";

            }
            if (tipo == Tipos.Categoria)
            {
                deleteQuery = @"DELETE FROM Categorias WHERE CategoriaId=@TipoId";
            }
            if (tipo == Tipos.Tamanio)
            {
                deleteQuery = @"DELETE FROM Tamaños WHERE TamanioId=@TipoId";
            }
            int registrosAfectados = conn.Execute(deleteQuery, new { tipoId }, tran);
            if (registrosAfectados == 0)
            {
                throw new Exception("No se pudo eliminar el registro");
            }
        }

        public void Editar(SqlConnection conn, Tipos tipo, TiposDeDatos tiposDeDatos, SqlTransaction tran)
        {
            string updateQuery = string.Empty;
            if (tipo == Tipos.Genero)
            {
                updateQuery = @"UPDATE Generos SET Descripcion=@Descripcion 
                                WHERE GeneroId=@TipoId";
            }
            if (tipo == Tipos.Marcas)
            {
                updateQuery = @"UPDATE Marcas SET Nombre=@Descripcion 
                                    WHERE MarcaId=@TipoId";
            }
            if (tipo == Tipos.Categoria)
            {
                updateQuery = @"UPDATE Categorias SET Descripcion=@Descripcion 
                                    WHERE CategoriaId=@TipoId";
            }
            if (tipo == Tipos.Tamanio)
            {
                updateQuery = @"UPDATE Tamaños SET Descripcion=@Descripcion 
                                    WHERE TamanioId=@TipoId";
            }
            int registrosAfectados = conn.Execute(updateQuery, new
            {
                tiposDeDatos.TipoId,
                tiposDeDatos.Descripcion
            }, tran);
            if (registrosAfectados == 0)
            {
                throw new Exception("No se pudo editar");
            }
        }

        public bool EstaRelacionado(SqlConnection conn, Tipos tipo, int tipoId)
        {
            string selectQuery = string.Empty;
            if (tipo == Tipos.Genero)
            {
                selectQuery = @"SELECT COUNT(*) FROM Empleados
                                    WHERE GeneroId=@TipoId";

            }
            if (tipo == Tipos.Marcas)
            {
                selectQuery = @"SELECT COUNT(*) FROM Productos 
                                    WHERE MarcaId=@TipoId";
            }
            if (tipo == Tipos.Categoria)
            {
                selectQuery = @"SELECT COUNT(*) FROM Productos 
                                    WHERE CategoriaId=@TipoId";
            }
            if (tipo == Tipos.Tamanio)
            {
                selectQuery = @"SELECT COUNT(*) FROM Productos 
                                    WHERE TamanioId=@TipoId";
            }
            return conn.QuerySingle<int>(selectQuery, new { tipoId }) > 0;
        }

        public bool Existe(SqlConnection conn, Tipos tipo, TiposDeDatos tiposDeDatos)
        {
            string selectQuery = string.Empty;
            string finalQuery = string.Empty;
            string conditional = string.Empty;
            if (tipo == Tipos.Genero)
            {
                selectQuery = @"SELECT COUNT(*) FROM Generos";
                if (tiposDeDatos.TipoId == 0)
                {
                    conditional = " WHERE Descripcion = @Descripcion";
                }
                else
                {
                    conditional = " WHERE Descripcion = @Descripcion AND GeneroId<>@TipoId";
                }
            }
            if (tipo == Tipos.Marcas)
            {
                selectQuery = @"SELECT COUNT(*) FROM Marcas";

                if (tiposDeDatos.TipoId == 0)
                {
                    conditional = " WHERE Nombre = @Descripcion";
                }
                else
                {
                    conditional = " WHERE Nombre = @Descripcion AND MarcaId<>@TipoId";
                }

            }
            if (tipo == Tipos.Categoria)
            {
                selectQuery = @"SELECT COUNT(*) FROM Categorias";
                if (tiposDeDatos.TipoId == 0)
                {
                    conditional = " WHERE Descripcion = @Descripcion";
                }
                else
                {
                    conditional = " WHERE Descripcion = @Descripcion AND CategoriaId<>@TipoId";
                }
            }
            if (tipo == Tipos.Tamanio)
            {
                selectQuery = @"SELECT COUNT(*) FROM Tamaños";
                if (tiposDeDatos.TipoId == 0)
                {
                    conditional = " WHERE Descripcion=@Descripcion";
                }
                else
                {
                    conditional = " WHERE Descripcion=@Descripcion AND TamanioId<>@TipoId";
                }
            }
            finalQuery = string.Concat(selectQuery, conditional);
            return conn.QuerySingle<int>(finalQuery, tiposDeDatos) > 0;
        }

        public int GetCantidad(SqlConnection conn, Tipos tipo, Func<TiposDeDatos, bool>? filter)
        {
            var lista = new List<TiposDeDatos>();
            var selectQuery = string.Empty;
            if (tipo == Tipos.Genero)
            {
                selectQuery = @"SELECT GeneroId, Descripcion FROM Generos";
            }
            if (tipo == Tipos.Marcas)
            {
                selectQuery = @"SELECT MarcaId As TipoId, Nombre As Descripcion FROM Marcas";
            }
            if (tipo == Tipos.Categoria)
            {
                selectQuery = "SELECT CategoriaId, Descripcion FROM Categorias";
            }
            if (tipo == Tipos.Tamanio)
            {
                selectQuery = @"SELECT TamanioId, Descripcion FROM Tamaños";
            }
            var listaTipos = conn.Query<TiposDeDatos>(selectQuery).ToList();
            lista.AddRange(listaTipos);
            if (filter != null)
            {
                lista = lista.Where(filter).ToList();
            }
            return lista.Count;
        }

        public List<TiposDeDatos>? GetLista(SqlConnection conn, Tipos tipo, int currentPage, int pageSize, Orden orden, Func<TiposDeDatos, bool>? filter)
        {
            var listaTipos = new List<TiposDeDatos>();
            var ordenQuery = string.Empty;
            var finalQuery = string.Empty;
            var selectQuery = string.Empty;
            if (tipo == Tipos.Genero)
            {
                selectQuery = @"SELECT GeneroId As TipoId, Descripcion FROM Generos";
                if (orden == Orden.OrdenAZ)
                {
                    ordenQuery = @" ORDER BY Descripcion";
                }
                if (orden == Orden.OrdenZA)
                {
                    ordenQuery = @" ORDER BY Descripcion DESC";
                }

            }
            if (tipo == Tipos.Marcas)
            {
                selectQuery = @"SELECT MarcaId As TipoId, Nombre As Descripcion From Marcas";

                if (orden == Orden.OrdenAZ)
                {
                    ordenQuery = @" ORDER BY Nombre";
                }
                if (orden == Orden.OrdenZA)
                {
                    ordenQuery = @" ORDER BY Nombre Desc";
                }

            }
            if (tipo == Tipos.Categoria)
            {
                selectQuery = @"SELECT CategoriaId As TipoId, Descripcion From Categorias";

                if (orden == Orden.OrdenAZ)
                {
                    ordenQuery = @" ORDER BY Descripcion";
                }
                if (orden == Orden.OrdenZA)
                {
                    ordenQuery = @" ORDER BY Descripcion Desc";
                }
            }
            if (tipo == Tipos.Tamanio)
            {
                selectQuery = @"SELECT TamanioId AS TipoId, 
                                    Descripcion From Tamaños";
                if (orden == Orden.OrdenAZ)
                {
                    ordenQuery = " ORDER BY Descripcion";
                }
                if (orden == Orden.OrdenZA)
                {
                    ordenQuery = " ORDER BY Descripcion DESC";
                }
            }
            finalQuery = string.Concat(selectQuery, ordenQuery);
            var lista = conn.Query<TiposDeDatos>(finalQuery).ToList();
            listaTipos.AddRange(lista);
            if (filter != null)
            {
                listaTipos = listaTipos.Where(filter).ToList();
            }
            return listaTipos.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
        }

        public List<TiposDeDatos>? GetLista(SqlConnection conn, Tipos tipo)
        {
            var listaTipos = new List<TiposDeDatos>();
           
            var selectQuery = string.Empty;
            if (tipo == Tipos.Genero)
            {
                selectQuery = @"SELECT GeneroId As TipoId, Descripcion FROM Generos";
            }
            if (tipo == Tipos.Marcas)
            {
                selectQuery = @"SELECT MarcaId As TipoId, Nombre As Descripcion From Marcas";
            }
            if (tipo == Tipos.Categoria)
            {
                selectQuery = @"SELECT CategoriaId As TipoId, Descripcion From Categorias";
            }
            if (tipo == Tipos.Tamanio)
            {
                selectQuery = @"SELECT TamanioId AS TipoId, 
                                    Descripcion From Tamaños";
            }
            var lista = conn.Query<TiposDeDatos>(selectQuery).ToList();
            listaTipos.AddRange(lista);
            return listaTipos;
        }

        public int GetPaginaPorRegistro(SqlConnection conn, Tipos tipo, string? descripcion, int pageSize)
        {
            string positionQuery = string.Empty;
            if (tipo == Tipos.Genero)
            {
                positionQuery = @"WITH GenerosOrdenados As (SELECT ROW_NUMBER() OVER (ORDER BY Descripcion) 
                        AS RowNum, Descripcion FROM Generos)
                        SELECT RowNum FROM GenerosOrdenados WHERE Descripcion = @Descripcion";
            }
            if (tipo == Tipos.Marcas)
            {
                positionQuery = @"WITH MarcasOrdenadas As (SELECT ROW_NUMBER() 
                            OVER (ORDER BY Nombre) As RowNum, Nombre FROM Marcas)
                            SELECT RowNum FROM MarcasOrdenadas 
                                WHERE Nombre=@Descripcion";
            }
            if (tipo == Tipos.Categoria)
            {
                positionQuery = @"WITH CategoriasOrdenadas As (SELECT ROW_NUMBER() 
                            OVER (ORDER BY Descripcion) As RowNum, Descripcion FROM Categorias)
                            SELECT RowNum FROM CategoriasOrdenadas 
                                WHERE Descripcion=@Descripcion";
            }
            if (tipo == Tipos.Tamanio)
            {
                positionQuery = @"WITH TamanioOrdenado AS (SELECT ROW_NUMBER() 
                                    OVER (ORDER BY Descripcion) AS RowNum, Descripcion 
                                        FROM Tamaños)
                                    SELECT RowNum FROM TamanioOrdenado
                                    WHERE Descripcion=@Descripcion";
            }

            int position = conn.ExecuteScalar<int>(positionQuery, new { Descripcion = descripcion });
            return (int)Math.Ceiling((decimal)position / pageSize);
        }
    }
}
