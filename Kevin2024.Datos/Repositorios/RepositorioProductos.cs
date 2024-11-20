using Dapper;
using Kevin2024.Datos.Interfaces;
using Kevin2024.Entidades;
using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Enumeraciones;
using System.Data.SqlClient;

namespace Kevin2024.Datos.Repositorios
{
    public class RepositorioProductos : IRepositorioProductos
    {
        public RepositorioProductos()
        { }

        public void Agregar(SqlConnection conn, Productos producto, SqlTransaction tran)
        {
            string insertQuery = @"INSERT INTO Productos (Nombre, Descripcion, 
                                                            MarcaId, Sabor, CodBarras, 
                                                            TamanioId, CategoriaId, 
                                                            PrecioCosto, PrecioVenta, 
                                                            Stock, NivelDeReposicion, 
                                                            Imagen, Suspendido)
                                    VALUES (@Nombre, @Descripcion, 
                                                            @MarcaId, @Sabor, @CodBarras, 
                                                            @TamanioId, @CategoriaId, 
                                                            @PrecioCosto, @PrecioVenta, 
                                                            @Stock, @NivelDeReposicion, 
                                                            @Imagen, @Suspendido);
                                    SELECT CAST(SCOPE_IDENTITY() AS INT)";

            int primaryKey = conn.QuerySingle<int>(insertQuery, new
            {
                ProductoId = producto.ProductoId,
                Nombre = producto.Nombre,
                Descripcion = producto.Descripcion,
                MarcaId = producto.MarcaId,
                Sabor = producto.Sabor,
                CodBarras = producto.CodBarras,
                TamanioId = producto.TamanioId,
                CategoriaId = producto.CategoriaId,
                PrecioCosto = producto.PrecioCosto,
                PrecioVenta = producto.PrecioVenta,
                Stock = producto.Stock,
                NivelDeReposicion = producto.NivelDeReposicion,
                Imagen = producto.Imagen,
                Suspendido = producto.Suspendido
            }, tran);
            if (primaryKey > 0)
            {
                producto.ProductoId = primaryKey;
                return;
            }
            throw new Exception("No se pudo agregar el Producto");
        }

        public void Borrar(SqlConnection conn, int productoId, SqlTransaction tran)
        {
            string deleteQuery = @"DELETE FROM Productos 
                           WHERE ProductoId=@ProductoId";
            int registrosAfectado = conn.Execute(deleteQuery, new { productoId }, tran);
            if (registrosAfectado == 0)
            {
                throw new Exception("No se pudo eliminar el Producto");
            }
        }

        public void Editar(SqlConnection conn, Productos producto, SqlTransaction tran)
        {
            string updateQuery = @"UPDATE Productos SET 
                                         Nombre=@Nombre, Descripcion=@Descripcion, 
                                         MarcaId = @MarcaId, Sabor = @Sabor, 
                                         CodBarras = @CodBarras, 
                                         TamanioId = @TamanioId, CategoriaId = @CategoriaId, 
                                         PrecioCosto = @PrecioCosto, PrecioVenta=@PrecioVenta, 
                                         Stock = @Stock, NivelDeReposicion = @NivelDeReposicion, 
                                         Imagen = @Imagen, Suspendido = @Suspendido
                                    WHERE ProductoId = @ProductoId";
            int registrosAfectados = conn.Execute(updateQuery, new
            {
                producto.ProductoId,
                producto.Nombre,
                producto.Descripcion,
                producto.MarcaId,
                producto.Sabor,
                producto.CodBarras,
                producto.TamanioId,
                producto.CategoriaId,
                producto.PrecioCosto,
                producto.PrecioVenta,
                producto.Stock,
                producto.NivelDeReposicion,
                producto.Imagen,
                producto.Suspendido
            }, tran);
            if (registrosAfectados == 0)
            {
                throw new Exception("No se pudo editar el Producto");
            }
        }

        public bool EstaRelacionado(SqlConnection conn, int productoId)
        {
            string selectQuery = @"SELECT COUNT(*) FROM DetallesCombos
                                 WHERE ProductoId=@ProductoId";
            return conn.QuerySingle<int>(selectQuery, new { productoId }) > 0;
        }

        public bool Existe(SqlConnection conn, Productos producto)
        {
            string selectQuery = @"SELECT COUNT(*) FROM Productos";
            string finalQuery = string.Empty;
            string conditional = string.Empty;
            if (producto.ProductoId == 0)
            {
                conditional = " WHERE CodBarras = @CodBarras";
            }
            else
            {
                conditional = " WHERE CodBarras = @CodBarras AND ProductoId<>@ProductoId";
            }
            finalQuery = string.Concat(selectQuery, conditional);
            return conn.QuerySingle<int>(finalQuery, producto) > 0;
        }

        public int GetCantidad(SqlConnection conn, Func<ProductosListDto, bool>? filter = null)
        {
            var listaProductos = new List<ProductosListDto>();
            string selectQuery = @"SELECT ProductoId AS ProductoId,
                                p.Nombre,
								m.Nombre AS Marca,
								p.CodBarras,
                                t.Descripcion AS Tamanio,
								c.Descripcion AS Categoria,
                                PrecioVenta, 
                                Stock, 
                                Suspendido, 
                                Imagen
                           FROM Productos p

                                LEFT JOIN Marcas m on p.MarcaId = m.MarcaId

                                LEFT JOIN Tamaños t on p.TamanioId = t.TamanioId

                                LEFT JOIN Categorias c on p.CategoriaId = c.CategoriaId ";
            var lista = conn.Query<ProductosListDto>(selectQuery).ToList();
            listaProductos.AddRange(lista);

            if (filter != null)
            {
                listaProductos = listaProductos.Where(filter).ToList();
            }
            return listaProductos.Count;
        }

        public List<ProductosListDto>? GetLista(SqlConnection conn, int currentPage, int pageSize, Orden orden, Func<ProductosListDto, bool>? filter = null)
        {
            var listaProductos = new List<ProductosListDto>();
            string ordenQuery = string.Empty;
            string finalQuery = string.Empty;
            var selectQuery = @"SELECT ProductoId AS ProductoId,
                                p.Nombre,
								m.Nombre AS Marca,
								p.CodBarras,
                                t.Descripcion AS Tamanio,
								c.Descripcion AS Categoria,
                                PrecioVenta, 
                                Stock, 
                                Suspendido,
                                Imagen
                           FROM Productos p

                                LEFT JOIN Marcas m on p.MarcaId = m.MarcaId

                                LEFT JOIN Tamaños t on p.TamanioId = t.TamanioId

                                LEFT JOIN Categorias c on p.CategoriaId = c.CategoriaId";
            if(orden == Orden.Ninguno)
            {
                ordenQuery = @" ORDER BY p.Nombre";
            }
            if (orden == Orden.OrdenAZ)
            {
                ordenQuery = @" ORDER BY p.Nombre";
            }
            if (orden == Orden.OrdenZA)
            {
                ordenQuery = @" ORDER BY p.Nombre Desc";
            }
            finalQuery = string.Concat(selectQuery, ordenQuery);
            var lista = conn.Query<ProductosListDto>(finalQuery).ToList();
            listaProductos.AddRange(lista);
            if (filter != null)
            {
                listaProductos = listaProductos.Where(filter).ToList();
            }
            return listaProductos.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
        }

        public int GetPaginaPorRegistro(SqlConnection conn, string nombre, int pageSize)
        {
            string positionQuery = @"WITH ProductosOrdenados As (SELECT ROW_NUMBER() 
                                   OVER (ORDER BY Nombre) As RowNum, Nombre 
                                  FROM Productos)
                              SELECT RowNum From ProductosOrdenados 
                              WHERE Nombre = @Nombre";
            int position = conn.ExecuteScalar<int>(positionQuery, new { Nombre = nombre });
            return (int)Math.Ceiling((decimal)position / pageSize);
        }

        public Productos? GetProductoPorId(SqlConnection conn, int productoId)
        {
            string selectQuery = @"SELECT ProductoId AS ProductoId,
                            Nombre, Descripcion, 
                                                     MarcaId, Sabor, 
                                                     CodBarras, TamanioId, CategoriaId, 
                                                 PrecioCosto, PrecioVenta, 
                                                 Stock, NivelDeReposicion, 
                                                 Suspendido, Imagen
                               FROM Productos
                                                 WHERE ProductoId=@ProductoId";
            return conn.QuerySingleOrDefault<Productos>(selectQuery, new { @ProductoId = productoId });
        }
    }











    //public Productos? GetProductoPorId(SqlConnection conn, int productoId)
    //    {
    //       // if (tipoProducto == TipoProducto.Bebidas)
    //       // {
    //       //     string selectQuery = @"SELECT BebidaId AS ProductoId,
    //							//MarcaId, Sabor, CodBarras, CategoriaId, 
    //       //                             TamanioId, 
    //       //                         PrecioCosto, PrecioVenta, 
    //       //                         Stock, NivelDeReposicion, 
    //       //                         Suspendido
    //				   //     FROM Bebidas
    //       //                         WHERE BebidaId=@BebidaId";
    //       //     return conn.QuerySingleOrDefault<Bebidas>(selectQuery, new { @BebidaId = productoId });
    //       // }

    //       // if (tipoProducto == TipoProducto.Postres)
    //       // {
    //       //     string selectQuery = @"SELECT PostreId AS ProductoId,
    //							//Nombre, Descripcion, 
    //       //                             MarcaId, Sabor, 
    //       //                             CodBarras, TamanioId, CategoriaId, 
    //       //                         PrecioCosto, PrecioVenta, 
    //       //                         Stock, NivelDeReposicion, 
    //       //                         Suspendido
    //				   //     FROM Postres
    //       //                         WHERE PostreId=@PostreId";
    //       //     return conn.QuerySingleOrDefault<Postre>(selectQuery, new { @PostreId = productoId });
    //       // }
    //        return null;
    //    }
}
