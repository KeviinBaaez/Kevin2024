﻿using Kevin2024.Datos.Interfaces;
using System.Data.SqlClient;
using Dapper;
using Kevin2024.Entidades.Entidades;

namespace Kevin2024.Datos.Repositorios
{
    public class RepositorioLogin : IRepositorioLogin
    {
        public RepositorioLogin()
        {

        }
        public bool Conectar(SqlConnection conn, string usuario, string clave)
        {
            string selectQuery = @"SELECT COUNT(*) 
                FROM Usuarios WHERE NombreUsuario = @Usuario 
                AND CLAVE = @Clave";
            return conn.QuerySingle<int>(selectQuery,new { usuario, clave } ) > 0;
        }

        public Usuario? GetUsuario(SqlConnection conn, string usuario, string clave)
        {
                var selectQuery = @"
       SELECT u.UsuarioId, u.NombreUsuario, u.Clave, u.RolId, u.Activo, u.Imagen, 
               r.RolId, r.Nombre, 
               pr.PermisoRolId, pr.RolId, pr.PermisoId, 
               p.PermisoId, p.Menu
        FROM Usuarios u
        INNER JOIN Roles r ON u.RolId = r.RolId
        INNER JOIN PermisosRoles pr ON pr.RolId = r.RolId
        INNER JOIN Permisos p ON p.PermisoId = pr.PermisoId
        WHERE u.NombreUsuario = @Usuario AND u.Clave =@Clave AND u.Activo = 1";

                var usuarioDictionary = new Dictionary<int, Usuario>();

                var resultado = conn.Query<Usuario, Rol, PermisoRol, Permiso, Usuario>(
                    selectQuery,
                    (usuario, rol, permisoRol, permiso) =>
                    {
                        // Verificar si el usuario ya existe en el diccionario
                        if (!usuarioDictionary.TryGetValue(usuario.UsuarioId, out var usuarioEntry))
                        {
                            // Crear una nueva instancia de usuario si no está en el diccionario
                            usuarioEntry = usuario;
                            usuarioEntry.Rol = rol;
                            usuarioEntry.Rol.Permisos = new List<PermisoRol>(); // Inicializamos la lista de permisos
                            usuarioDictionary.Add(usuario.UsuarioId, usuarioEntry);
                        }

                        // Verificar si el permisoRol ya existe en la lista de permisos del rol
                        if (!usuarioEntry.Rol!.Permisos.Any(p => p.PermisoRolId == permisoRol.PermisoRolId))
                        {
                            // Asociar el permiso correspondiente al PermisoRol
                            permisoRol.Permiso = permiso;
                            // Agregar el PermisoRol al Rol
                            usuarioEntry.Rol.Permisos.Add(permisoRol);
                        }

                        return usuarioEntry; // Devolver siempre la referencia actualizada del usuario
                    },
                    new { Usuario = usuario, Clave = clave },
                    splitOn: "RolId, PermisoRolId, PermisoId");//Campos donde se hacen los cortes

                // Retornar el primer usuario encontrado o null si no se encontró ninguno
                return usuarioDictionary.Values.FirstOrDefault();
        }
    }
}
