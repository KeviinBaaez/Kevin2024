using Dapper;
using Kevin2024.Datos.Interfaces;
using Kevin2024.Entidades;
using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Entidades;
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

        public int GetCantidad(SqlConnection conn, Func<ProductosListDto, bool>? filter = null, Orden? orden = null, TiposDeDatos? consulta = null)
        {
            var listaProductos = new List<ProductosListDto>();
            string finalQuery = string.Empty;
            string conditions = string.Empty;
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
            if (orden == Orden.Suspendido)
            {
                conditions = @" WHERE Suspendido = 1";
            }
            if (orden == Orden.Activo)
            {
                conditions = @" WHERE Suspendido = 0";
            }
            if (consulta != null)
            {
                if (orden is Orden.Suspendido || orden is Orden.Activo)
                {
                    conditions = conditions + " AND c.CategoriaId = @TipoId";
                }
                else
                {
                    conditions = " WHERE c.CategoriaId = @TipoId";
                }
            }
            finalQuery = string.Concat(selectQuery, conditions);
            var lista = conn.Query<ProductosListDto>(finalQuery, new { TipoId = consulta?.TipoId }).ToList();
            listaProductos.AddRange(lista);

            if (filter != null)
            {
                listaProductos = listaProductos.Where(filter).ToList();
            }
            return listaProductos.Count;
        }

        public int GetCantidad(SqlConnection conn, Func<Productos, bool>? filter = null)
        {
            var listaProductos = new List<Productos>();
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
            var lista = conn.Query<Productos>(selectQuery).ToList();
            listaProductos.AddRange(lista);

            if (filter != null)
            {
                listaProductos = listaProductos.Where(filter).ToList();
            }
            return listaProductos.Count;
        }

        public List<ProductosListDto>? GetLista(SqlConnection conn, int currentPage, int pageSize, Orden orden, Func<ProductosListDto, bool>? filter = null, TiposDeDatos? consulta = null)
        {
            var listaProductos = new List<ProductosListDto>();
            string ordenQuery = string.Empty;
            string conditions = string.Empty;
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
            if (orden == Orden.Ninguno)
            {
                ordenQuery = @" ORDER BY Suspendido";
            }
            if (orden == Orden.OrdenAZ)
            {
                ordenQuery = @" ORDER BY p.Nombre";
            }
            if (orden == Orden.OrdenZA)
            {
                ordenQuery = @" ORDER BY p.Nombre Desc";
            }
            if (orden == Orden.Suspendido)
            {
                conditions = @" WHERE Suspendido = 1";
            }
            if (orden == Orden.Activo)
            {
                conditions = @" WHERE Suspendido = 0";
            }
            if (consulta != null)
            {
                if (orden is Orden.Suspendido || orden is Orden.Activo)
                {
                    conditions = conditions + " AND c.CategoriaId = @TipoId";
                }
                else
                {
                    conditions = " WHERE c.CategoriaId = @TipoId";
                }
            }
            finalQuery = string.Concat(selectQuery, conditions, ordenQuery);
            var lista = conn.Query<ProductosListDto>(finalQuery, new { TipoId = consulta?.TipoId }).ToList();
            listaProductos.AddRange(lista);
            if (filter != null)
            {
                listaProductos = listaProductos.Where(filter).ToList();
            }
            return listaProductos.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
        }

        public List<Productos>? GetListaCombo(SqlConnection conn, Func<Productos, bool>? filter)
        {
            var listaProductos = new List<Productos>();
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

            var lista = conn.Query<Productos>(selectQuery).ToList();
            listaProductos.AddRange(lista);
            if (filter != null)
            {
                listaProductos = listaProductos.Where(filter).ToList();
            }
            return listaProductos;
        }

        public List<Productos>? GetListaProductos(SqlConnection conn, TipoProducto tipoProducto)
        {
            var listaProductos = new List<Productos>();
            if (tipoProducto is TipoProducto.Productos)
            {
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

                                LEFT JOIN Categorias c on p.CategoriaId = c.CategoriaId
                            WHERE Suspendido = 0";

                var lista = conn.Query<Productos>(selectQuery).ToList();
                return lista;
            }
            else
            {
                string selectQuery = @"SELECT c.ComboId AS ProductoId, 
                                    c.Nombre AS Nombre, t.Descripcion AS Tamanio, 
                                   c.PrecioVenta, 
                                c.Stock, c.Suspendido FROM Combos c 
                                INNER JOIN Tamaños t ON t.TamanioId = c.TamanioId
                                WHERE Suspendido = 0";

                var listaCombo = conn.Query<Combo>(selectQuery).ToList();
                listaProductos.AddRange(listaCombo);
                return listaProductos;
            }
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

        public Productos? GetProductoPorId(SqlConnection conn, TipoProducto tipoProducto, int productoId)
        {
            if (tipoProducto is TipoProducto.Productos)
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
            else if (tipoProducto is TipoProducto.Combos)
            {
                string selectQuery = @"SELECT 
                           c.ComboId AS ProductoId, 
                           c.Nombre AS Nombre, 
                           c.Descripcion, 
                           c.PrecioCosto, 
                           c.PrecioVenta, 
                           c.Stock,
                           c.FechaFin,
						   c.FechaFin,
                           c.NivelDeReposicion, 
                           c.Imagen, 
                           c.Suspendido,
						   dc.DetalleComboId,
						   dc.ComboId,
						   dc.ProductoId,
						   dc.Cantidad,
						   p.ProductoId As ProductoId,
						   p.Nombre As Nombre
						   FROM Combos c
						   INNER JOIN DetallesCombos dc ON c.ComboId=dc.ComboId
						   INNER JOIN Productos p ON p.ProductoId=dc.ProductoId
						WHERE c.ComboId=@ComboId";
                var comboDictionary = new Dictionary<int, Combo>();
                var resultado = conn.Query<Combo, DetallesCombos, Productos, Combo>(
                    selectQuery, (combo, detalle, producto) =>
                    {
                        if (!comboDictionary.TryGetValue(combo.ProductoId, out var comboEntry))
                        {
                            comboEntry = combo;
                            comboEntry.DetallesCombos = new List<DetallesCombos>();
                            comboDictionary.Add(combo.ProductoId, comboEntry);
                        };
                        detalle.Producto = producto;
                        comboEntry.DetallesCombos.Add(detalle);
                        return comboEntry;
                    }, new { @ComboId = productoId },
                    splitOn: "DetalleComboId,ProductoId");
                return comboDictionary.Values.FirstOrDefault();
            }
            return null;
        }
    }
}
