using Kevin2024.Entidades.Entidades;

namespace Kevin2024.Servicios.Interfaces
{
    public interface IServiciosLogin
    {
        bool Conectar(string usuario, string clave);
        Usuario? GetUsuario(string usuario, string clave);
    }
}