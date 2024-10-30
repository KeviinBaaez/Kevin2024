using Kevin2024.Entidades;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Servicios.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Kevin2024.Windows.Helpers
{
    public static class CombosHelper
    {
        private static IServiceProvider? _serviceProvider;

        public static void CargarComboPaginas(ref ComboBox cbo, int totalPages)
        {
            cbo.Items.Clear();
            for (int i = 1; i <= totalPages; i++)
            {
                cbo.Items.Add(i.ToString());
            }
        }

        public static void CargarComboMarcas(ref ComboBox cbo, IServiceProvider? serviceProvider)
        {
            _serviceProvider = serviceProvider;
            IServiciosMarcas? servicio = _serviceProvider!.GetService<IServiciosMarcas>();
            var lista = servicio!.GetLista();
            var defaultTipo = new Marcas()
            {
                MarcaId = 0,
                Nombre = "Seleccione"
            };
            lista?.Insert(0, defaultTipo);
            cbo.DataSource = lista;
            cbo.DisplayMember = "Nombre";
            cbo.ValueMember = "MarcaId";
            cbo.SelectedIndex = 0;
        }

        public static void CargarComboCategorias(ref ComboBox cbo, IServiceProvider? serviceProvider)
        {
            _serviceProvider = serviceProvider;
            IServiciosCategorias? servicio = _serviceProvider!.GetService<IServiciosCategorias>();
            var lista = servicio!.GetLista();
            var defaultTipo = new Categorias()
            {
                CategoriaId = 0,
                Descripcion = "Seleccione"
            };
            lista?.Insert(0, defaultTipo);
            cbo.DataSource = lista;
            cbo.DisplayMember = "Descripcion";
            cbo.ValueMember = "CategoriaId";
            cbo.SelectedIndex = 0;
        }

        public static void CargarComboTamanios(ref ComboBox cbo, IServiceProvider? serviceProvider)
        {
            _serviceProvider = serviceProvider;
            IServiciosTamanios? servicio = _serviceProvider!.GetService<IServiciosTamanios>();
            var lista = servicio!.GetLista();
            var defaultTipo = new Tamanio()
            {
                TamanioId = 0,
                Descripcion = "Seleccione"
            };
            lista?.Insert(0, defaultTipo);
            cbo.DataSource = lista;
            cbo.DisplayMember = "Descripcion";
            cbo.ValueMember = "TamanioId";
            cbo.SelectedIndex = 0;
        }
    }
}
