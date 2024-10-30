using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using System.Data.SqlClient;

namespace Kevin2024.Servicios.Interfaces
{
    public interface IServiciosTamanios
    {
        void Borrar(int tamanioId);
        bool EstaRelacionado(int tamanioId);
        bool Existe(Tamanio tamanio);
        int GetCantidad(Func<Tamanio, bool>? filter);
        List<Tamanio>? GetLista(int currentPage, int pageSize, Orden orden, Func<Tamanio, bool>? filter);
        List<Tamanio> GetLista();
        int GetPaginaPorRegistro(string descripcion, int pageSize);
        void Guardar(Tamanio tamanio);
    }
}
