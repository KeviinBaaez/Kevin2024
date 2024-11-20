using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using Kevin2024.Servicios.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Kevin2024.Windows.Helpers
{
    public static class CombosHelper
    {
        private static IServiceProvider? _serviceProvider;
        private static Tipos tipo;
        public static void CargarComboPaginas(ref ComboBox cbo, int totalPages)
        {
            cbo.Items.Clear();
            for (int i = 1; i <= totalPages; i++)
            {
                cbo.Items.Add(i.ToString());
            }
        }

        public static void CargarComboMarcas(ref ComboBox cbo,  IServiceProvider? serviceProvider)
        {
            tipo = Tipos.Marcas;
            _serviceProvider = serviceProvider;
            IServiciosTipos? servicio = _serviceProvider!.GetService<IServiciosTipos>();
            var lista = servicio!.GetLista(tipo);
            var defaultTipo = new TiposDeDatos()
            {
                TipoId = 0,
                Descripcion = "Seleccione"
            };
            lista?.Insert(0, defaultTipo);
            cbo.DataSource = lista;
            cbo.DisplayMember = "Descripcion";
            cbo.ValueMember = "TipoId";
            cbo.SelectedIndex = 0;
        }

        public static void CargarComboCategorias(ref ComboBox cbo, IServiceProvider? serviceProvider)
        {
            tipo = Tipos.Categoria;
            _serviceProvider = serviceProvider;
            IServiciosTipos? servicio = _serviceProvider!.GetService<IServiciosTipos>();
            var lista = servicio!.GetLista(tipo);
            var defaultTipo = new TiposDeDatos()
            {
                TipoId = 0,
                Descripcion = "Seleccione"
            };
            lista?.Insert(0, defaultTipo);
            cbo.DataSource = lista;
            cbo.DisplayMember = "Descripcion";
            cbo.ValueMember = "TipoId";
            cbo.SelectedIndex = 0;
        }

        public static void CargarComboTamanios(ref ComboBox cbo, IServiceProvider? serviceProvider)
        {
            tipo = Tipos.Tamanio;
            _serviceProvider = serviceProvider;
            IServiciosTipos? servicio = _serviceProvider!.GetService<IServiciosTipos>();
            var lista = servicio!.GetLista(tipo);
            var defaultTipo = new TiposDeDatos()
            {
                TipoId = 0,
                Descripcion = "Seleccione"
            };
            lista?.Insert(0, defaultTipo);
            cbo.DataSource = lista;
            cbo.DisplayMember = "Descripcion";
            cbo.ValueMember = "TipoId";
            cbo.SelectedIndex = 0;
        }
        public static void CargarComboGeneros(ref ComboBox cbo, IServiceProvider? serviceProvider)
        {
            tipo = Tipos.Genero;
            _serviceProvider = serviceProvider;
            IServiciosTipos? servicio = _serviceProvider!.GetService<IServiciosTipos>();
            var lista = servicio!.GetLista(tipo);
            var defaultTipo = new TiposDeDatos()
            {
                TipoId = 0,
                Descripcion = "Seleccione"
            };
            lista?.Insert(0, defaultTipo);
            cbo.DataSource = lista;
            cbo.DisplayMember = "Descripcion";
            cbo.ValueMember = "TipoId";
            cbo.SelectedIndex = 0;
        }
    }
}
