using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kevin2024.Servicios.Interfaces
{
    public interface IServiciosCategorias
    {
        void Borrar(int categoriaId);
        bool EstaRelacionado(int categoriaId);
        bool Existe(Categorias categoria);
        int GetCantidad(Func<Categorias, bool>? filter);
        List<Categorias>? GetLista(int currentPage, int pageSize, Orden orden, Func<Categorias, bool>? filter);
        List<Categorias>? GetLista();
        int GetPaginaPorRegistro(string descripcion, int pageSize);
        void Guardar(Categorias categoria);
    }
}
