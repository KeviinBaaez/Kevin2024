using Dapper;
using Kevin2024.Datos.Interfaces;
using Kevin2024.Entidades;
using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using System.Data.SqlClient;

namespace Kevin2024.Datos.Repositorios
{
    public class RepositorioCombos : IRepositorioCombos
    {
        public RepositorioCombos()
        {
            
        }

        public void Agregar(SqlConnection conn, Combo combo, SqlTransaction tran)
        {
            string insertQuery = @"INSERT INTO Combos (Nombre, Descripcion, TamanioId, 
                        PrecioCosto, PrecioVenta, Stock, NivelDeReposicion, Imagen, Suspendido)
                
                                VALUES(@Nombre, @Descripcion, @TamanioId, 
                       @PrecioCosto, @PrecioVenta, @Stock, @NivelDeReposicion, @Imagen, @Suspendido);
                        SELECT CAST(SCOPE_IDENTITY() AS Int)";
            int primaryKey = conn.QuerySingle<int>(insertQuery, new
            {
                Nombre = combo.Nombre,
                Descripcion = combo.Descripcion,
                TamanioId = combo.TamanioId,
                PrecioCosto = combo.PrecioCosto,
                PrecioVenta = combo.PrecioVenta,
                Stock = combo.Stock,
                NivelDeReposicion = combo.NivelDeReposicion,
                Imagen = combo.Imagen,
                Suspendido = combo.Suspendido
            }, tran);
            if(primaryKey > 0)
            {
                combo.ProductoId = primaryKey;
                return;
            }
            throw new Exception("No se pudo agregar el Combo");
        }

        public void Borrar(SqlConnection conn, int productoId, SqlTransaction tran)
        {
            string deleteQuery = @"DELETE FROM Combos
                                    WHERE ComboId = @ProductoId";
            int registrosAfectados = conn.Execute(deleteQuery, new { productoId }, tran);
            if(registrosAfectados == 0)
            {
                throw new Exception("No se pudo eliminar el Combo");
            }
        }

        public void Editar(SqlConnection conn, Combo combo, SqlTransaction tran)
        {
            string updateQuery = @"UPDATE Combos SET 
                             Nombre = @Nombre, Descripcion = @Descripcion, 
                             TamanioId= @TamanioId, PrecioCosto = @PrecioCosto,
                             PrecioVenta = @PrecioVenta, Stock = @Stock, 
                             NivelDeReposicion = @NivelDeReposicion, Imagen = @Imagen, 
                             Suspendido = @Suspendido 
                             WHERE ComboId = @ProductoId";
            int registrosAfectados = conn.Execute(updateQuery, new
            {
                combo.ProductoId,
                combo.Nombre,
                combo.Descripcion,
                combo.TamanioId,
                combo.PrecioCosto,
                combo.PrecioVenta,
                combo.Stock,
                combo.NivelDeReposicion,
                combo.Imagen,
                combo.Suspendido
            }, tran);
            if(registrosAfectados == 0)
            {
                throw new Exception("No se pudo editar el Combo");
            }
        }

        public bool EstaRelacionado(SqlConnection conn, int productoId)
        {
            var selectQuery = @"SELECT COUNT(*) FROM DetallesCombos WHERE ComboId = @ComboId";
            return conn.QuerySingle<int>(selectQuery, new { @ComboId = productoId }) > 0;
        }

        public bool Existe(SqlConnection conn, Combo combo)
        {
            string selectQuery = @"SELECT COUNT(*) FROM Combos";
            string finalQuery = string.Empty;
            string conditional = string.Empty;
            if(combo.ProductoId == 0)
            {
                conditional = " WHERE Nombre = @Nombre";
            }
            else
            {
                conditional = " WHERE Nombre = @Nombre AND ComboId <> @ProductoId";
            }
            finalQuery = string.Concat(selectQuery, conditional);
            return conn.QuerySingle<int>(finalQuery, combo) > 0;
        }

        public int GetCantidad(SqlConnection conn, Func<ComboListDto, bool>? filter)
        {
            var listaCombo = new List<ComboListDto>();
            string selectQuery = @"SELECT c.ComboId, c.Nombre As Nombre, t.Descripcion AS Tamanio, 
                        c.PrecioVenta, 
                                c.Stock, c.Suspendido FROM Combos c 
                                INNER JOIN Tamaños t ON t.TamanioId = c.TamanioId";
            var lista = conn.Query<ComboListDto>(selectQuery).ToList();
            listaCombo.AddRange(lista);
            if (filter != null)
            {
                listaCombo = listaCombo.Where(filter).ToList();
            }
            return listaCombo.Count();
        }

        public List<ComboListDto>? GetLista(SqlConnection conn, int currentPage, int pageSize, Orden orden, Func<ComboListDto, bool>? filter)
        {
            var listaCombo = new List<ComboListDto>();
            string ordenQuery = string.Empty;
            string finalQUery = string.Empty;
            string selectQuery = @"SELECT c.ComboId AS ComboId, c.Nombre, t.Descripcion AS Tamanio, 
                                   c.PrecioVenta, 
                                c.Stock, c.Suspendido FROM Combos c 
                                INNER JOIN Tamaños t ON t.TamanioId = c.TamanioId";
            if(orden == Orden.OrdenAZ)
            {
                ordenQuery = " ORDER BY Nombre";
            }else if(orden == Orden.OrdenZA)
            {
                ordenQuery = " ORDER BY Nombre Desc";
            }
            finalQUery = string.Concat(selectQuery, ordenQuery);
            var lista = conn.Query<ComboListDto>(finalQUery).ToList();
            listaCombo.AddRange(lista);
            if(filter != null)
            {
                listaCombo = listaCombo.Where(filter).ToList();  
            }
            return listaCombo.Skip((currentPage-1) * pageSize).Take(pageSize).ToList();
        }

        public int GetPaginaPorRegistro(SqlConnection conn, string nombre, int pageSize)
        {
            string positionQuery = @"WITH CombosOrdenados As (SELECT ROW_NUMBER() 
                                   OVER (ORDER BY Nombre) As RowNum, Nombre 
                                  FROM Combos)
                              SELECT RowNum From CombosOrdenados 
                              WHERE Nombre = @Nombre";
            int position = conn.ExecuteScalar<int>(positionQuery, new { Nombre = nombre });
            return (int)Math.Ceiling((decimal)position / pageSize);
        }

        public Combo GetProductoPorId(SqlConnection conn, int productoId)
        {
            string selectQuery = @"SELECT 
		                            c.ComboId AS ProductoId, 
		                            c.Nombre AS Nombre,
		                            c.Descripcion, 
                                    c.TamanioId,
		                            c.PrecioCosto, 
		                            c.PrecioVenta AS Precio, 
		                            c.Stock, 
		                            c.NivelDeReposicion,
		                            c.Imagen, 
		                            c.Suspendido,
		                            dc.DetalleComboId,
		                            dc.ComboId,
		                            dc.ProductoId,
		                            dc.Cantidad,
		                            p.ProductoId AS ProductoId,
		                            p.Nombre AS Nombre

		                            FROM Combos c
		                            INNER JOIN  DetallesCombos dc on dc.ComboId = c.ComboId
		                            INNER JOIN Productos p on p.ProductoId = dc.ProductoId
		                            WHERE c.ComboId=@ComboId";
            var comboDictionary = new Dictionary<int, Combo>();
            var resultado = conn.Query<Combo, DetallesCombos, Productos, Combo>(selectQuery,
                (combo, detalle, producto) =>
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
                splitOn: "DetalleComboId, ProductoId");
            return comboDictionary.Values.FirstOrDefault()!;
        }
    }
}
