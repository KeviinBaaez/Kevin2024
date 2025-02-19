using Kevin2024.Entidades;
using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using Kevin2024.Servicios.Interfaces;
using Kevin2024.Windows.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace Kevin2024.Windows.Formularios
{
    public partial class frmAgregarProductos : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private readonly IServiciosProductos? _servicios;
        private DetallesCombos? detallesCombos;
        private Productos? producto;

        private Func<Productos, bool>? filter = null;
        Archivo archivo = Archivo.Ninguno;
        public frmAgregarProductos(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _servicios = _serviceProvider?.GetService<IServiciosProductos>();
        }

        private void frmAgregarProductos_Load(object sender, EventArgs e)
        {
            CombosHelper.CargarComboProductos(ref cboProductos, _serviceProvider, filter);
        }


        private void btnFiltroMarca_Click(object sender, EventArgs e)
        {
            archivo = Archivo.Marcas;
            frmFiltro frm = new frmFiltro(archivo) { Text = "Filtrar por Marca" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            try
            {
                var textoFiltro = frm.GetTexto();
                if (textoFiltro == null || string.IsNullOrEmpty(textoFiltro)) return;
                filter = p => p.Marca!.ToUpper().Contains(textoFiltro.ToUpper());
                var cantidad = _servicios!.GetCantidad(filter);
                if (cantidad > 0)
                {
                    CombosHelper.CargarComboProductos(ref cboProductos, _serviceProvider, filter);
                    cboProductos.SelectedIndex = 1;
                }
                else
                {
                    MessageBox.Show("No se encontraron registros!",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        private void btnFiltroTamanio_Click(object sender, EventArgs e)
        {
            archivo = Archivo.Tamanio;
            frmFiltro frm = new frmFiltro(archivo) { Text = "Filtrar por Tamaño" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            try
            {
                var textoFiltro = frm.GetTexto();
                if (textoFiltro == null || string.IsNullOrEmpty(textoFiltro)) return;
                filter = p => p.Tamanio!.ToUpper().Contains(textoFiltro.ToUpper());
                var cantidad = _servicios!.GetCantidad(filter);
                if (cantidad > 0)
                {
                    CombosHelper.CargarComboProductos(ref cboProductos, _serviceProvider, filter);
                }
                else
                {
                    MessageBox.Show("No se encontraron registros!",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        private void btnFiltroCategoria_Click(object sender, EventArgs e)
        {
            archivo = Archivo.Categoria;
            frmFiltro frm = new frmFiltro(archivo) { Text = "Filtrar por Marca" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            try
            {
                var textoFiltro = frm.GetTexto();
                if (textoFiltro == null || string.IsNullOrEmpty(textoFiltro)) return;
                filter = p => p.Categoria!.ToUpper().Contains(textoFiltro.ToUpper());
                var cantidad = _servicios!.GetCantidad(filter);
                if (cantidad > 0)
                {
                    CombosHelper.CargarComboProductos(ref cboProductos, _serviceProvider, filter);
                }
                else
                {
                    MessageBox.Show("No se encontraron registros!",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            filter = null;
            CombosHelper.CargarComboProductos(ref cboProductos, _serviceProvider, filter);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (detallesCombos is null)
                {
                    detallesCombos = new DetallesCombos();
                }
                detallesCombos.Producto = producto;

                detallesCombos.ProductoId = producto!.ProductoId;
                detallesCombos.Cantidad = (int)nupCantidad.Value;
                producto = detallesCombos.Producto;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            bool valido = true;

            if (cboProductos.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(cboProductos, "Seleccione un producto");
            }
            if (nupCantidad.Value == 0)
            {
                valido = false;
                errorProvider1.SetError(nupCantidad, "Al menos debes agregar una unidad");
            }
            return valido;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


        private void cboProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            producto = cboProductos.SelectedIndex > 0 ? (Productos)cboProductos.SelectedItem! : null;
        }

        public DetallesCombos? GetDetalleCombo()
        {
            return detallesCombos;
        }

        public void SetDetalle(DetallesCombos detalle)
        {
            detallesCombos = detalle;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if(detallesCombos != null)
            {
                cboProductos.SelectedValue = detallesCombos.ProductoId;
                nupCantidad.Value = detallesCombos.Cantidad;
            }
        }
    }
}
