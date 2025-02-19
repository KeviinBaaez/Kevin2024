using Dapper;
using Kevin2024.Datos.Interfaces;
using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Entidades;
using System.Data.SqlClient;

namespace Kevin2024.Datos.Repositorios
{
    public class RepositorioConsulta : IRepositorioConsulta
    {
        public List<ProductosListDto> GetLista(SqlConnection conn, TiposDeDatos? consulta)
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

                                LEFT JOIN Categorias c on p.CategoriaId = c.CategoriaId";
            if (consulta != null)
            {
                selectQuery += " WHERE c.CategoriaId = @TipoId";
            }
            var lista = conn.Query<ProductosListDto>(selectQuery, new { TipoId = consulta.TipoId}).ToList();
            listaProductos.AddRange(lista);
            return listaProductos.ToList();
        }
    }
}
