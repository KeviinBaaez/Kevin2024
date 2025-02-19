using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;

namespace Kevin2024.Servicios.Interfaces
{
    public interface IServiciosArchivos
    {
        void Borrar(Archivo archivo, int tipoId);
        bool EstaRelacionado(Archivo tipo, int tipoId);
        bool Existe(Archivo archivo, TiposDeDatos tiposDeDatos);
        public int GetCantidad(Archivo archivo, Func<TiposDeDatos, bool>? filter);

        public List<TiposDeDatos>? GetLista(Archivo archivo, int currentPage, int pageSize, Orden orden, Func<TiposDeDatos, bool>? filter);
        public List<TiposDeDatos>? GetLista(Archivo archivo);
        int GetPaginaPorRegistro(Archivo archivo, string? descripcion, int pageSize);
        void Guardar(Archivo archivo, TiposDeDatos tiposDeDatos);
    }
}
