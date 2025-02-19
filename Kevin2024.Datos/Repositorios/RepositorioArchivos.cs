using Dapper;
using Kevin2024.Datos.Interfaces;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using System.Data.SqlClient;

namespace Kevin2024.Datos.Repositorios
{
    public class RepositorioArchivos : IRepositorioArchivos
    {

        public void Agregar(SqlConnection conn, Archivo archivo, TiposDeDatos tiposDeDatos, SqlTransaction tran)
        {
            int primarykey = 0;
            string insertQuery = string.Empty;
            if (archivo == Archivo.Genero)
            {
                insertQuery = @"INSERT INTO Generos (Descripcion) 
                            VALUES(@Descripcion) SELECT CAST(SCOPE_IDENTITY() AS int)";
                primarykey = conn.QuerySingle<int>(insertQuery, new
                {
                    GeneroId = tiposDeDatos.TipoId,
                    Descripcion = tiposDeDatos.Descripcion
                }, tran);
            }
            if (archivo == Archivo.Marcas)
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
            if (archivo == Archivo.Categoria)
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
            if (archivo == Archivo.Tamanio)
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
            if (archivo == Archivo.Telefono)
            {
                insertQuery = @"INSERT INTO TiposTelefonos (Descripcion) 
                                    VALUES (@Descripcion);
                                    SELECT CAST(SCOPE_IDENTITY() AS INT)";
                primarykey = conn.QuerySingle<int>(insertQuery, new
                {
                    TipoTelefonoId = tiposDeDatos.TipoId,
                    Descripcion = tiposDeDatos.Descripcion,
                }, tran);
            }
            if (archivo == Archivo.Direccion)
            {
                insertQuery = @"INSERT INTO TiposDirecciones (Descripcion) 
                                    VALUES (@Descripcion);
                                    SELECT CAST(SCOPE_IDENTITY() AS INT)";
                primarykey = conn.QuerySingle<int>(insertQuery, new
                {
                    TipoDireccionId = tiposDeDatos.TipoId,
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

        public void Borrar(SqlConnection conn, Archivo archivo, int tipoId, SqlTransaction tran)
        {
            var deleteQuery = string.Empty;
            if (archivo == Archivo.Genero)
            {
                deleteQuery = @"DELETE FROM Generos WHERE GeneroId=@TipoId";

            }
            if (archivo == Archivo.Marcas)
            {
                deleteQuery = @"DELETE FROM Marcas WHERE MarcaId=@TipoId";

            }
            if (archivo == Archivo.Categoria)
            {
                deleteQuery = @"DELETE FROM Categorias WHERE CategoriaId=@TipoId";
            }
            if (archivo == Archivo.Tamanio)
            {
                deleteQuery = @"DELETE FROM Tamaños WHERE TamanioId=@TipoId";
            }
            if (archivo == Archivo.Telefono)
            {
                deleteQuery = @"DELETE FROM TiposTelefonos WHERE TipoTelefonoId=@TipoId";
            }
            if (archivo == Archivo.Direccion)
            {
                deleteQuery = @"DELETE FROM TiposDirecciones WHERE TipoDireccionId=@TipoId";
            }
            int registrosAfectados = conn.Execute(deleteQuery, new { tipoId }, tran);
            if (registrosAfectados == 0)
            {
                throw new Exception("No se pudo eliminar el registro");
            }
        }

        public void Editar(SqlConnection conn, Archivo archivo, TiposDeDatos tiposDeDatos, SqlTransaction tran)
        {
            string updateQuery = string.Empty;
            if (archivo == Archivo.Genero)
            {
                updateQuery = @"UPDATE Generos SET Descripcion=@Descripcion 
                                WHERE GeneroId=@TipoId";
            }
            if (archivo == Archivo.Marcas)
            {
                updateQuery = @"UPDATE Marcas SET Nombre=@Descripcion 
                                    WHERE MarcaId=@TipoId";
            }
            if (archivo == Archivo.Categoria)
            {
                updateQuery = @"UPDATE Categorias SET Descripcion=@Descripcion 
                                    WHERE CategoriaId=@TipoId";
            }
            if (archivo == Archivo.Tamanio)
            {
                updateQuery = @"UPDATE Tamaños SET Descripcion=@Descripcion 
                                    WHERE TamanioId=@TipoId";
            }
            if (archivo == Archivo.Telefono)
            {
                updateQuery = @"UPDATE TiposTelefonos SET Descripcion=@Descripcion 
                                    WHERE TipoTelefonoId=@TipoId";
            }
            if (archivo == Archivo.Direccion)
            {
                updateQuery = @"UPDATE TiposDirecciones SET Descripcion=@Descripcion 
                                    WHERE TipoDireccionId=@TipoId";
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

        public bool EstaRelacionado(SqlConnection conn, Archivo archivo, int tipoId)
        {
            string selectQuery = string.Empty;
            if (archivo == Archivo.Genero)
            {
                selectQuery = @"SELECT COUNT(*) FROM Empleados
                                    WHERE GeneroId=@TipoId";

            }
            if (archivo == Archivo.Marcas)
            {
                selectQuery = @"SELECT COUNT(*) FROM Productos 
                                    WHERE MarcaId=@TipoId";
            }
            if (archivo == Archivo.Categoria)
            {
                selectQuery = @"SELECT COUNT(*) FROM Productos 
                                    WHERE CategoriaId=@TipoId";
            }
            if (archivo == Archivo.Tamanio)
            {
                selectQuery = @"SELECT COUNT(*) FROM Productos 
                                    WHERE TamanioId=@TipoId";
            }
            if (archivo == Archivo.Telefono)
            {
                selectQuery = @"SELECT COUNT(*) FROM ClientesTelefonos 
                                    WHERE TipoTelefonoId=@TipoId";
            }
            if (archivo == Archivo.Direccion)
            {
                selectQuery = @"SELECT COUNT(*) FROM Clientes 
                                    WHERE TipoDireccionId=@TipoId";
            }
            return conn.QuerySingle<int>(selectQuery, new { tipoId }) > 0;
        }

        public bool Existe(SqlConnection conn, Archivo archivo, TiposDeDatos tiposDeDatos)
        {
            string selectQuery = string.Empty;
            string finalQuery = string.Empty;
            string conditional = string.Empty;
            if (archivo == Archivo.Genero)
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
            if (archivo == Archivo.Marcas)
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
            if (archivo == Archivo.Categoria)
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
            if (archivo == Archivo.Tamanio)
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
            if (archivo == Archivo.Telefono)
            {
                selectQuery = @"SELECT COUNT(*) FROM ArchivoTelefonos";
                if (tiposDeDatos.TipoId == 0)
                {
                    conditional = " WHERE Descripcion=@Descripcion";
                }
                else
                {
                    conditional = " WHERE Descripcion=@Descripcion AND TipoTelefonoId<>@TipoId";
                }
            }
            if (archivo == Archivo.Direccion)
            {
                selectQuery = @"SELECT COUNT(*) FROM TiposDirecciones";
                if (tiposDeDatos.TipoId == 0)
                {
                    conditional = " WHERE Descripcion=@Descripcion";
                }
                else
                {
                    conditional = " WHERE Descripcion=@Descripcion AND TipoDireccionId<>@TipoId";
                }
            }
            finalQuery = string.Concat(selectQuery, conditional);
            return conn.QuerySingle<int>(finalQuery, tiposDeDatos) > 0;
        }

        public int GetCantidad(SqlConnection conn, Archivo archivo, Func<TiposDeDatos, bool>? filter)
        {
            var lista = new List<TiposDeDatos>();
            var selectQuery = string.Empty;
            if (archivo == Archivo.Genero)
            {
                selectQuery = @"SELECT GeneroId, Descripcion FROM Generos";
            }
            if (archivo == Archivo.Marcas)
            {
                selectQuery = @"SELECT MarcaId As TipoId, Nombre As Descripcion FROM Marcas";
            }
            if (archivo == Archivo.Categoria)
            {
                selectQuery = "SELECT CategoriaId, Descripcion FROM Categorias";
            }
            if (archivo == Archivo.Tamanio)
            {
                selectQuery = @"SELECT TamanioId, Descripcion FROM Tamaños";
            }
            if (archivo == Archivo.Telefono)
            {
                selectQuery = @"SELECT TipoTelefonoId, Descripcion FROM TiposTelefonos";
            }
            if (archivo == Archivo.Direccion)
            {
                selectQuery = @"SELECT TipoDireccionId, Descripcion FROM TiposDirecciones";
            }
            var listaTipos = conn.Query<TiposDeDatos>(selectQuery).ToList();
            lista.AddRange(listaTipos);
            if (filter != null)
            {
                lista = lista.Where(filter).ToList();
            }
            return lista.Count;
        }

        public List<TiposDeDatos>? GetLista(SqlConnection conn, Archivo archivo, int currentPage, int pageSize, Orden orden, Func<TiposDeDatos, bool>? filter)
        {
            var listaTipos = new List<TiposDeDatos>();
            var ordenQuery = string.Empty;
            var finalQuery = string.Empty;
            var selectQuery = string.Empty;
            if (archivo == Archivo.Genero)
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
            if (archivo == Archivo.Marcas)
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
            if (archivo == Archivo.Categoria)
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
            if (archivo == Archivo.Tamanio)
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
            if (archivo == Archivo.Telefono)
            {
                selectQuery = @"SELECT TipoTelefonoId AS TipoId, 
                                    Descripcion From TiposTelefonos";
                if (orden == Orden.OrdenAZ)
                {
                    ordenQuery = " ORDER BY Descripcion";
                }
                if (orden == Orden.OrdenZA)
                {
                    ordenQuery = " ORDER BY Descripcion DESC";
                }
            }
            if (archivo == Archivo.Direccion)
            {
                selectQuery = @"SELECT TipoDireccionId AS TipoId, 
                                    Descripcion From TiposDirecciones";
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

        public List<TiposDeDatos>? GetLista(SqlConnection conn, Archivo archivo)
        {
            var listaTipos = new List<TiposDeDatos>();
           
            var selectQuery = string.Empty;
            if (archivo == Archivo.Genero)
            {
                selectQuery = @"SELECT GeneroId As TipoId, Descripcion FROM Generos";
            }
            if (archivo == Archivo.Marcas)
            {
                selectQuery = @"SELECT MarcaId As TipoId, Nombre As Descripcion From Marcas";
            }
            if (archivo == Archivo.Categoria)
            {
                selectQuery = @"SELECT CategoriaId As TipoId, Descripcion From Categorias";
            }
            if (archivo == Archivo.Tamanio)
            {
                selectQuery = @"SELECT TamanioId AS TipoId, 
                                    Descripcion From Tamaños";
            }
            if (archivo == Archivo.Telefono)
            {
                selectQuery = @"SELECT TipoTelefonoId AS TipoId, 
                                    Descripcion From TiposTelefonos";
            }
            if (archivo == Archivo.Direccion)
            {
                selectQuery = @"SELECT TipoDireccionId AS TipoId, 
                                    Descripcion From TiposDirecciones";
            }
            if (archivo == Archivo.Roles)
            {
                selectQuery = @"SELECT RolId AS TipoId, 
                                    Nombre As Descripcion From Roles";
            }
            if (archivo == Archivo.FormasDePago)
            {
                selectQuery = @"SELECT FormaDePagoId AS TipoId, 
                                    Descripcion From FormasDePagos";
            }
            if (archivo == Archivo.EstadoOrden)
            {
                selectQuery = @"SELECT EstadoOrdenId AS TipoId, 
                                    Descripcion From EstadoOrden";
            }
            if (archivo == Archivo.EstadoPago)
            {
                selectQuery = @"SELECT EstadoPagoId As TipoId,
                                    Descripcion From EstadoPagos";
            }
            var lista = conn.Query<TiposDeDatos>(selectQuery).ToList();
            listaTipos.AddRange(lista);
            return listaTipos;
        }

        public int GetPaginaPorRegistro(SqlConnection conn, Archivo archivo, string? descripcion, int pageSize)
        {
            string positionQuery = string.Empty;
            if (archivo == Archivo.Genero)
            {
                positionQuery = @"WITH GenerosOrdenados As (SELECT ROW_NUMBER() OVER (ORDER BY Descripcion) 
                        AS RowNum, Descripcion FROM Generos)
                        SELECT RowNum FROM GenerosOrdenados WHERE Descripcion = @Descripcion";
            }
            if (archivo == Archivo.Marcas)
            {
                positionQuery = @"WITH MarcasOrdenadas As (SELECT ROW_NUMBER() 
                            OVER (ORDER BY Nombre) As RowNum, Nombre FROM Marcas)
                            SELECT RowNum FROM MarcasOrdenadas 
                                WHERE Nombre=@Descripcion";
            }
            if (archivo == Archivo.Categoria)
            {
                positionQuery = @"WITH CategoriasOrdenadas As (SELECT ROW_NUMBER() 
                            OVER (ORDER BY Descripcion) As RowNum, Descripcion FROM Categorias)
                            SELECT RowNum FROM CategoriasOrdenadas 
                                WHERE Descripcion=@Descripcion";
            }
            if (archivo == Archivo.Tamanio)
            {
                positionQuery = @"WITH TamanioOrdenado AS (SELECT ROW_NUMBER() 
                                    OVER (ORDER BY Descripcion) AS RowNum, Descripcion 
                                        FROM Tamaños)
                                    SELECT RowNum FROM TamanioOrdenado
                                    WHERE Descripcion=@Descripcion";
            }
            if (archivo == Archivo.Telefono)
            {
                positionQuery = @"WITH TelefonoOrdenado AS (SELECT ROW_NUMBER() 
                                    OVER (ORDER BY Descripcion) AS RowNum, Descripcion 
                                        FROM TiposTelefonos)
                                    SELECT RowNum FROM TelefonoOrdenado
                                    WHERE Descripcion=@Descripcion";
            }
            if (archivo == Archivo.Direccion)
            {
                positionQuery = @"WITH DireccionOrdenada AS (SELECT ROW_NUMBER() 
                                    OVER (ORDER BY Descripcion) AS RowNum, Descripcion 
                                        FROM TiposDirecciones)
                                    SELECT RowNum FROM DireccionOrdenada
                                    WHERE Descripcion=@Descripcion";
            }
            int position = conn.ExecuteScalar<int>(positionQuery, new { Descripcion = descripcion });
            return (int)Math.Ceiling((decimal)position / pageSize);
        }
    }
}
