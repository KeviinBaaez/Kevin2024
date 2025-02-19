using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Entidades;

namespace Kevin2024.Servicios.Interfaces
{
    public interface IServicioConsulta
    {
        List<ProductosListDto> GetLista(TiposDeDatos? consulta);
    }
}
