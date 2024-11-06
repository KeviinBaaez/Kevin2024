using Dapper;
using Kevin2024.Datos.Interfaces;
using Kevin2024.Entidades;
using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;

namespace Kevin2024.Datos.Repositorios
{
    public class RepositorioEmpleados : IRepositorioEmpleados
    {
        public void Agregar(SqlConnection conn, Empleados empleado, SqlTransaction tran)
        {
            string insertQuery = @"INSERT INTO EMpleados (Nombre, Apellido, Dni, FechaNac, FechaContrato, Salario, Suspendido) 
                                VALUES (@Nombre, @Apellido, @Dni, @FechaNac, @FechaContrato, @Salario, @Suspendido);
                                SELECT CAST(SCOPE_IDENTITY() AS INT)";
            int primarykey = conn.QuerySingle<int>(insertQuery, new
            {
                EmpleadoId = empleado.EmpleadoId,
                Nombre = empleado.Nombre,
                Apellido = empleado.Apellido,
                Dni = empleado.Dni,
                FechaNac = empleado.FechaNac,
                FechaContrato= empleado.FechaContrato,
                Salario =empleado.Salario,
                Suspendido = empleado.Suspendido
            }, tran);
            if (primarykey > 0)
            {
                empleado.EmpleadoId = primarykey;
                return;
            }
            throw new Exception("No se pudo agregar el Empleado");
        }

        public void Borrar(SqlConnection conn, int empleadoId, SqlTransaction tran)
        {
            string deleteQuery = @"DELETE FROM Empleados WHERE EmpleadoId=@EmpleadoId";
            int registrosAfectados = conn.Execute(deleteQuery, new { empleadoId }, tran);
            if (registrosAfectados == 0)
            {
                throw new Exception("No se pudo elimar el Empleado");
            }
        }

        public void Editar(SqlConnection conn, Empleados empleado, SqlTransaction tran)
        {
            string updateQuery = @"UPDATE Empleados SET Nombre=@Nombre, 
                                                    Apellido = @Apellido, 
                                                    Dni = @Dni, 
                                                    FechaNac = @FechaNac,
                                                    FechaContrato = @FechaContrato, 
                                                    Salario = @Salario, 
                                                    Suspendido = @Suspendido
                                    WHERE EmpleadoId=@EmpleadoId";
            int registrosAfectados = conn.Execute(updateQuery, new
            {
               empleado.EmpleadoId,
               empleado.Nombre,
               empleado.Apellido,
               empleado.Dni,
               empleado.FechaNac,
               empleado.FechaContrato,
               empleado.Salario,
               empleado.Suspendido
            }, tran);
            if (registrosAfectados == 0)
            {
                throw new Exception("No se pudo editar los datos del Empleado");
            }
        }

        public bool Existe(SqlConnection conn, Empleados empleado)
        {
            string selectQuery = @"SELECT COUNT(*) FROM Empleados";
            string finalQuery = string.Empty;
            string conditional = string.Empty;
            if (empleado.EmpleadoId == 0)
            {
                conditional = " WHERE Dni = @Dni";
            }
            else
            {
                conditional = " WHERE Dni = @Dni AND EmpleadoId<> @EmpleadoId";
            }
            finalQuery = string.Concat(selectQuery, conditional);
            return conn.QuerySingle<int>(finalQuery, empleado) > 0;
        }

        public int GetCantidad(SqlConnection conn, Func<EmpleadosListDto, bool>? filter)
        {
            var lista = new List<EmpleadosListDto>();
            string selectQuery = @"SELECT EmpleadoId, Nombre, Apellido, Dni, Salario, Suspendido FROM Empleados";
            var listaEmpleados = conn.Query<EmpleadosListDto>(selectQuery).ToList();
            lista.AddRange(listaEmpleados);
            if (filter != null)
            {
                lista = lista.Where(filter).ToList();
            }
            return lista.Count;
        }

        public Empleados? GetEmpleadoPorId(SqlConnection conn, int empleadoId)
        {
            string selectQuery = @"SELECT EmpleadoId, Nombre, Apellido, Dni, FechaNac, 
                                FechaContrato, Salario, Suspendido FROM Empleados
                                                 WHERE EmpleadoId=@EmpleadoId";
            return conn.QuerySingleOrDefault<Empleados>(selectQuery, new { @EmpleadoId = empleadoId });
        }

        public List<EmpleadosListDto>? GetLista(SqlConnection conn, int currentPage, int pageSize, Orden orden, Func<EmpleadosListDto, bool>? filter)
        {
            var lista = new List<EmpleadosListDto>();
            var finalQuery = string.Empty;
            var ordenQuery = string.Empty;
            string selectQuery = @"SELECT EmpleadoId, CONCAT(Nombre,' ', Apellido) AS Nombre , Apellido, Dni, 
                            Salario, Suspendido FROM Empleados";

            if(orden == Orden.Ninguno)
            {
                ordenQuery = @" ORDER BY Nombre";
            }
            if (orden == Orden.OrdenAZ)
            {
                ordenQuery = @" ORDER BY Nombre";
            }
            if (orden == Orden.OrdenZA)
            {
                ordenQuery = @" ORDER BY Nombre Desc";
            }
            finalQuery = string.Concat(selectQuery, ordenQuery);
            var listaEmpleados = conn.Query<EmpleadosListDto>(finalQuery).ToList();
            lista.AddRange(listaEmpleados);
            if (filter != null)
            {
                lista = lista.Where(filter).ToList();
            }
            return lista.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
        }

        public int GetPaginaPorRegistro(SqlConnection conn, string? nombre, int pageSize)
        {
            string positionQuery = @"WITH EmpleadosOrdenados As (SELECT ROW_NUMBER() 
                            OVER (ORDER BY Nombre) As RowNum, Nombre FROM Empleados)
                            SELECT RowNum FROM EmpleadosOrdenados 
                                WHERE Nombre=@Nombre";
            int position = conn.ExecuteScalar<int>(positionQuery, new { Nombre = nombre });
            return (int)Math.Ceiling((decimal)position / pageSize);
        }
    }
}
