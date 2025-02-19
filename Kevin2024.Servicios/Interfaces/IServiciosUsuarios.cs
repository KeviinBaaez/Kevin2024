using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;

namespace Kevin2024.Servicios.Interfaces
{
    public interface IServiciosUsuarios
    {
        void Borrar(int usuarioId);
        bool Existe(Usuario usuario);
        int GetCantidad(Func<Usuario, bool>? filter);
        List<Usuario>? GetLista(int currentPage, int pageSize, Orden orden, Func<Usuario, bool>? filter);
        void GuardarUsuario(Usuario usuario);
    }
}
