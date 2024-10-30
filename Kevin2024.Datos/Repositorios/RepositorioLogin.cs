using Kevin2024.Datos.Interfaces;
using System.Data.SqlClient;
using Dapper;

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
    }
}
