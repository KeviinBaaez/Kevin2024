using Kevin2024.Entidades;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Windows.Helpers;

namespace Kevin2024.Windows.Formularios
{
    public partial class frmPostresAE : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private Productos? producto;
        public frmPostresAE(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }
        private void frmPostresAE_Load(object sender, EventArgs e)
        {
            CombosHelper.CargarComboMarcas(ref cboMarca, _serviceProvider);
            CombosHelper.CargarComboTamanios(ref cboTamanio, _serviceProvider);
            CombosHelper.CargarComboCategorias(ref cboCategorias, _serviceProvider);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (producto is null)
                {
                    producto = new Productos();
                }

                producto.Nombre = txtNombre.Text;
                producto.Descripcion = txtDescripcion.Text;
                producto.MarcaId = (int)cboMarca.SelectedValue!;
                if(producto.MarcaId == 0)
                {
                    producto.MarcaId = null;
                }
                producto.Sabor = txtSabor.Text;
                producto.CodBarras = decimal.Parse(txtCodigoBarras.Text);
                producto.TamanioId = (int)cboTamanio.SelectedValue!;
                producto.CategoriaId = (int)cboCategorias.SelectedValue!;
                producto.PrecioCosto = nupPrecioCosto.Value;
                producto.PrecioVenta = nupPrecioVenta.Value;
                producto.Stock = (int)nupStock.Value;
                producto.NivelDeReposicion = (int)nupNivelReposicion.Value;
                //Falta img
                producto.Suspendido = checkBox1.Checked;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            bool valido = true;
            decimal resultado;

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                valido = false;
                errorProvider1.SetError(txtNombre, "Ingrese un Nombre");
            }
            if (!decimal.TryParse(txtCodigoBarras.Text, out resultado))
            {
                valido = false;
                errorProvider1.SetError(txtCodigoBarras, "Ingrese un codigo valido");
            }
            if(cboTamanio.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(cboTamanio, "Ingrese el tamaño del producto");
            }
            if(cboCategorias.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(cboCategorias, "Ingrese la categoria del producto");
            }
            if(nupPrecioCosto.Value == 0)
            {
                MessageBox.Show("El precio costo es Cero, ¿Deseas dejarlo así?",
                    "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                
            }
            return valido;
        }

        public Productos? GetProducto()
        {
            return producto;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (producto != null)
            {
                txtNombre.Text = producto.Nombre;
                txtDescripcion.Text = producto.Descripcion;
                cboMarca.SelectedIndex = (int)producto.MarcaId!;
                txtSabor.Text = producto.Sabor;
                txtCodigoBarras.Text = producto.CodBarras.ToString();
                cboTamanio.SelectedIndex = (int)producto.TamanioId!;
                cboCategorias.SelectedIndex = (int)producto.CategoriaId!;
                nupPrecioCosto.Value = producto.PrecioCosto;
                nupPrecioVenta.Value = producto.PrecioVenta;
                nupStock.Value = producto.Stock;
                nupNivelReposicion.Value = producto.NivelDeReposicion;
                checkBox1.Checked = producto.Suspendido;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }



        public void SetPostre(Productos producto)
        {
            this.producto = producto;
        }
    }
}
