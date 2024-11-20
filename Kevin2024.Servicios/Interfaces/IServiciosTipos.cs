using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;

namespace Kevin2024.Servicios.Interfaces
{
    public interface IServiciosTipos
    {
        void Borrar(Tipos tipo, int tipoId);
        bool EstaRelacionado(Tipos tipo, int tipoId);
        bool Existe(Tipos tipo, TiposDeDatos tiposDeDatos);
        public int GetCantidad(Tipos tipo, Func<TiposDeDatos, bool>? filter);

        public List<TiposDeDatos>? GetLista(Tipos tipo, int currentPage, int pageSize, Orden orden, Func<TiposDeDatos, bool>? filter);
        public List<TiposDeDatos> GetLista(Tipos tipo);
        int GetPaginaPorRegistro(Tipos tipo, string? descripcion, int pageSize);
        void Guardar(Tipos tipo, TiposDeDatos tiposDeDatos);
    }
}
