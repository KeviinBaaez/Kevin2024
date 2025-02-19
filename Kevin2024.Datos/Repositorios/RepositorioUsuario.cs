using Dapper;
using Kevin2024.Datos.Interfaces;
using Kevin2024.Entidades;
using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using System.Data.SqlClient;
using System.Linq;

namespace Kevin2024.Datos.Repositorios
{
    public class RepositorioUsuario : IRepositorioUsuario
    {
        public void Agregar(SqlConnection conn, Usuario usuario, SqlTransaction tran)
        {
            string insertQuery = @"INSERT INTO Usuarios (NombreUsuario, Clave, RolId, Activo, Imagen) 
                    VALUES(@NombreUsuario, @Clave, @RolId, @Activo, @Imagen);
                    SELECT CAST(SCOPE_IDENTITY() AS Int)";
            int primaryKey = conn.QuerySingle<int>(insertQuery, new
            {
                UsuarioId = usuario.UsuarioId,
                NombreUsuario = usuario.NombreUsuario,
                Clave = usuario.Clave,
                RolId = usuario.RolId,
                Activo = usuario.Activo,
                Imagen = usuario.Imagen
            }, tran);
            if (primaryKey > 0)
            {
                usuario.UsuarioId = primaryKey;
                return;
            }
            throw new Exception("No se pudo agregar el usuario");
        }
        public void Borrar(SqlConnection conn, int usuarioId, SqlTransaction tran)
        {
            string deleteQuery = @"DETELE FROM Usuarios 
                                    WHERE UsuarioId = @UsuarioId";
            int registrosAfectados = conn.Execute(deleteQuery, new {usuarioId}, tran);
            if(registrosAfectados == 0)
            {
                throw new Exception("No se puedo eliminar el usuario");
            }
        }

        public void Editar(SqlConnection conn, Usuario usuario, SqlTransaction tran)
        {
            string updateQuery = @"Update Usuarios SET NombreUsuario = @NombreUsuario, 
                                    Clave = @Clave, RolId = RolId, Activo = @Activo, Imagen = @Imagen
                                    WHERE UsuarioId = @UsuarioId";
            int registrosAfectados = conn.Execute(updateQuery, new 
            {
                usuario.UsuarioId,
                usuario.NombreUsuario,
                usuario.Clave,
                usuario.RolId,
                usuario.Activo,
                usuario.Imagen
            }, tran);
            if (registrosAfectados == 0)
            {
                throw new Exception("No se puedo eliminar el usuario");
            }
        }

        public bool Existe(SqlConnection conn, Usuario usuario)
        {
            string selectQuery = @"SELECT COUNT(*) FROM Usuarios";
            string finalQuery = string.Empty;
            string conditional = string.Empty;
            if (usuario.UsuarioId == 0)
            {
                conditional = " WHERE NombreUsuario = @NombreUsuario";
            }
            else
            {
                conditional = " WHERE NombreUsuario = @NombreUsuario AND UsuarioId<>@UsuarioId";
            }
            finalQuery = string.Concat(selectQuery, conditional);
            return conn.QuerySingle<int>(finalQuery, usuario) > 0;
        }

        public int GetCantidad(SqlConnection conn, Func<Usuario, bool>? filter)
        {
            var lista = new List<Usuario>();
            var conditions = string.Empty;
            var finalQuery = string.Empty;
            string selectQuery = @"SELECT u.UsuarioId, u.NombreUsuario, u.Clave, u.RolId,  r.Nombre As Nombre, u.Activo, u.Imagen
                                    FROM Usuarios u 
                                INNER JOIN Roles r on r.RolId = u.RolId";
            var listaUsuarios = conn.Query<Usuario>(selectQuery).ToList();
            lista.AddRange(listaUsuarios);
            if (filter != null)
            {
                lista = lista.Where(filter).ToList();
            }
            return lista.Count;
        }

        public List<Usuario>? GetLista(SqlConnection conn, int currentPage, int pageSize, Orden orden, Func<Usuario, bool>? filter)
        {
            var lista = new List<Usuario>();
            var finalQuery = string.Empty;
            var ordenQuery = string.Empty;
            var conditions = string.Empty;
            string selectQuery = @"SELECT u.UsuarioId, u.NombreUsuario, u.Clave, u.RolId, r.RolId, r.Nombre, u.Activo, u.Imagen
                                    FROM Usuarios u 
                                INNER JOIN Roles r on r.RolId = u.RolId";
            if (orden == Orden.Ninguno)
            {
                ordenQuery = @" ORDER BY UsuarioId";
            }
            if (orden == Orden.OrdenAZ)
            {
                ordenQuery = @" ORDER BY NombreUsuario";
            }
            if (orden == Orden.OrdenZA)
            {
                ordenQuery = @" ORDER BY NombreUsuario Desc";
            }


            finalQuery = string.Concat(selectQuery, conditions, ordenQuery);
            var listaUsuarios = conn.Query<Usuario>(finalQuery).ToList();
            lista.AddRange(listaUsuarios);
            if (filter != null)
            {
                lista = lista.Where(filter).ToList();
            }
            return lista.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
        }

    }
}
