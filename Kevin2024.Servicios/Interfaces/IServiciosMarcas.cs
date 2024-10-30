using Kevin2024.Entidades;
using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kevin2024.Servicios.Interfaces
{
    public interface IServiciosMarcas
    {
        void Borrar(int marcaId);
        bool EstaRelacionado(int marcaId);
        bool Existe(Marcas marca);
        int GetCantidad(Func<Marcas, bool>? filter);
        List<Marcas>? GetLista(int currentPage, int pageSize, Orden orden, Func<Marcas, bool>? filter);
        List<Marcas>? GetLista();
        int GetPaginaPorRegistro(string nombre, int pageSize);
        void Guardar(Marcas marca);
    }
}
