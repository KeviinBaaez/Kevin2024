using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kevin2024.Datos.Interfaces
{
    public interface IRepositorioMarcas
    {
        void Agregar(SqlConnection conn, Marcas marca, SqlTransaction tran);
        void Borrar(SqlConnection conn, int marcaId, SqlTransaction tran);
        void Editar(SqlConnection conn, Marcas marca, SqlTransaction tran);
        bool EstaRelacionado(SqlConnection conn, int marcaId);
        bool Existe(SqlConnection conn, Marcas marca);
        int GetCantidad(SqlConnection conn, Func<Marcas, bool>? filter);
        List<Marcas>? GetLista(SqlConnection conn, int currentPage, int pageSize, Orden orden, Func<Marcas, bool>? filter);
        List<Marcas>? GetLista(SqlConnection conn);
        int GetPaginaPorRegistro(SqlConnection conn, string nombre, int pageSize);
    }
}
