using Kevin2024.Entidades.Entidades;

namespace Kevin2024.Servicios.Interfaces
{
    public interface IServiciosTiposDeTelefonos
    {
        List<TipoTelefono> GetLista();
        TipoTelefono GetTipoTelefonoPorId(int tipoTelefonoId);
    }
}
