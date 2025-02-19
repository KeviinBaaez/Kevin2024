using Kevin2024.Entidades;
using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using Kevin2024.Servicios.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel;

namespace Kevin2024.Windows.Helpers
{
    public static class CombosHelper
    {
        private static IServiceProvider? _serviceProvider;
        private static Archivo archivo;
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
            archivo = Archivo.Marcas;
            _serviceProvider = serviceProvider;
            IServiciosArchivos? servicio = _serviceProvider!.GetService<IServiciosArchivos>();
            var lista = servicio!.GetLista(archivo);
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
            archivo = Archivo.Categoria;
            _serviceProvider = serviceProvider;
            IServiciosArchivos? servicio = _serviceProvider!.GetService<IServiciosArchivos>();
            var lista = servicio!.GetLista(archivo);
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
            archivo = Archivo.Tamanio;
            _serviceProvider = serviceProvider;
            IServiciosArchivos? servicio = _serviceProvider!.GetService<IServiciosArchivos>();
            var lista = servicio!.GetLista(archivo);
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
            archivo = Archivo.Genero;
            _serviceProvider = serviceProvider;
            IServiciosArchivos? servicio = _serviceProvider!.GetService<IServiciosArchivos>();
            var lista = servicio!.GetLista(archivo);
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

        public static void CargarComboRoles(ref ComboBox cbo, IServiceProvider? serviceProvider)
        {
            archivo = Archivo.Roles;
            _serviceProvider = serviceProvider;
            IServiciosArchivos? servicio = _serviceProvider!.GetService<IServiciosArchivos>();
            var lista = servicio!.GetLista(archivo);
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
        public static void CargarComboFormasDePago(ref ComboBox cbo, IServiceProvider? serviceProvider)
        {
            archivo = Archivo.FormasDePago;
            _serviceProvider = serviceProvider;
            IServiciosArchivos? servicio = _serviceProvider!.GetService<IServiciosArchivos>();
            var lista = servicio!.GetLista(archivo);
            var defaultTipo = new TiposDeDatos()
            {
                TipoId = 0,
                Descripcion = "Seleccione"
            };
            lista?.Insert(0, defaultTipo);
            cbo.DataSource = lista;
            cbo.DisplayMember = "Descripcion";
            cbo.ValueMember = "TipoId";
            cbo.SelectedIndex = 1;
        }

        public static void CargarComboEstadoOrden(ref DataGridViewComboBoxColumn cbo, IServiceProvider? serviceProvider)
        {
            archivo = Archivo.EstadoOrden;
            _serviceProvider = serviceProvider;
            IServiciosArchivos? servicio = _serviceProvider!.GetService<IServiciosArchivos>();
            var lista = servicio!.GetLista(archivo);
            var defaultTipo = new TiposDeDatos()
            {
                TipoId = 0,
                Descripcion = "Seleccione"
            };
            lista?.Insert(0, defaultTipo);
            cbo.DataSource = lista;
            cbo.DisplayMember = "Descripcion";
            cbo.ValueMember = "TipoId";
        }
        public static void CargarComboEstadoOrden(ref ToolStripComboBox cbo, IServiceProvider? serviceProvider)
        {
            archivo = Archivo.EstadoOrden;
            _serviceProvider = serviceProvider;
            IServiciosArchivos? servicio = _serviceProvider!.GetService<IServiciosArchivos>();
            var lista = servicio!.GetLista(archivo);
            var defaultTipo = new TiposDeDatos()
            {
                TipoId = 0,
                Descripcion = "Est. órden"
            };
            lista?.Insert(0, defaultTipo);
            cbo.Items.Clear();

            cbo.ComboBox.DisplayMember = "Descripcion";
            cbo.ComboBox.ValueMember = "TipoId";
            cbo.Items.AddRange(lista!.ToArray());
            cbo.SelectedIndex = 0;
        }

        public static void CargarComboTelefonos(ref ComboBox cbo, IServiceProvider? serviceProvider)
        {
            _serviceProvider = serviceProvider;
            IServiciosTiposDeTelefonos? servicio = _serviceProvider!.GetService<IServiciosTiposDeTelefonos>();
            var lista = servicio!.GetLista();
            var defaultTipo = new TipoTelefono()
            {
                TipoTelefonoId = 0,
                Descripcion = "Seleccione"
            };
            lista?.Insert(0, defaultTipo);
            cbo.DataSource = lista;
            cbo.DisplayMember = "Descripcion";
            cbo.ValueMember = "TipoTelefonoId";
            cbo.SelectedIndex = 0;
        }
        public static void CargarComboDirecciones(ref ComboBox cbo, IServiceProvider? serviceProvider)
        {
            _serviceProvider = serviceProvider;
            IServiciosTiposDeDirecciones? servicio = _serviceProvider!.GetService<IServiciosTiposDeDirecciones>();
            var lista = servicio!.GetLista();
            var defaultTipo = new TipoDireccion()
            {
                TipoDireccionId = 0,
                Descripcion = "Seleccione"
            };
            lista?.Insert(0, defaultTipo);
            cbo.DataSource = lista;
            cbo.DisplayMember = "Descripcion";
            cbo.ValueMember = "TipoDireccionId";
            cbo.SelectedIndex = 0;
        }

        public static void CargarComboProductos(ref ComboBox cbo, IServiceProvider? serviceProvider, Func<Productos, bool>? filter = null)
        {
            _serviceProvider = serviceProvider;
            IServiciosProductos? servicio = _serviceProvider!.GetService<IServiciosProductos>();
            var lista = servicio!.GetListaCombo(filter);
            var defaultTipo = new Productos()
            {
                ProductoId = 0,
                Nombre = "Seleccione"
            };
            lista?.Insert(0, defaultTipo);
            cbo.DataSource = lista;
            cbo.DisplayMember = "Nombre";
            cbo.ValueMember = "ProductoId";
            cbo.SelectedIndex = 0;
        }

        public static void CargarComboClientes(ref ComboBox cbo, IServiceProvider? serviceProvider)
        {
            _serviceProvider = serviceProvider;
            IServiciosClientes? servicio = _serviceProvider!.GetService<IServiciosClientes>();
            var lista = servicio!.GetListaCombo();
            var defaultCliente = new Cliente()
            { 
                ClienteId = 99999,
                Apellido = "Consumidor",
                Nombres = "Final"
            };
            lista?.Insert(0, defaultCliente);
            cbo.DataSource = lista;
            cbo.DisplayMember = "NombreCompleto";
            cbo.ValueMember = "ClienteId";
            cbo.SelectedIndex = 0;
        }
    }
}
