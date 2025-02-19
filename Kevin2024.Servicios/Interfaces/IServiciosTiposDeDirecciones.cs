using Kevin2024.Entidades.Entidades;

namespace Kevin2024.Servicios.Interfaces
{
    public interface IServiciosTiposDeDirecciones
    {
        List<TipoDireccion> GetLista();
        TipoDireccion GetTipoDireccionPorId(int tipoDireccionId);
    }
}
