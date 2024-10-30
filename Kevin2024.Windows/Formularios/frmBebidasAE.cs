using Kevin2024.Entidades;
using Kevin2024.Windows.Helpers;


namespace Kevin2024.Windows.Formularios
{
    public partial class frmBebidasAE : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private Productos? producto;
        public frmBebidasAE(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void frmBebidasAE_Load(object sender, EventArgs e)
        {
            CombosHelper.CargarComboMarcas(ref cboMarca, _serviceProvider);
            CombosHelper.CargarComboTamanios(ref cboTamanio, _serviceProvider);
            CombosHelper.CargarComboCategorias(ref cboCategorias, _serviceProvider); 
            cboCategorias.SelectedIndex = 1;
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (producto is null)
                {
                    producto = new Productos();
                }

                producto.MarcaId = (int)cboMarca.SelectedValue!;
                producto.Sabor = txtSabor.Text;
                producto.CodBarras = decimal.Parse(txtCodigoBarras.Text);
                producto.CategoriaId = (int)cboCategorias.SelectedValue!;
                producto.PrecioCosto = nupPrecioCosto.Value;
                producto.PrecioVenta = nupPrecioVenta.Value;
                producto.TamanioId = (int)cboTamanio.SelectedValue!;
                producto.Suspendido = checkBox1.Checked;
                producto.Stock = (int)nupStock.Value;
                producto.NivelDeReposicion = (int)nupNivelReposicion.Value;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            bool valido = true;
            decimal resultado;
            if (cboMarca.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(cboMarca, "Debe seleccionar una Marca");
            }
            if (string.IsNullOrEmpty(txtSabor.Text))
            {
                valido = false;
                errorProvider1.SetError(txtSabor, "Ingrese un sabor!");
            }
            if (cboTamanio.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(cboTamanio, "Ingrese el tamaño del producto");
            }
            if (!decimal.TryParse(txtCodigoBarras.Text, out resultado))
            {
                valido = false;
                errorProvider1.SetError(txtCodigoBarras, "Ingrese un codigo valido");
            }
            return valido;
        }

        public Productos? GetProducto()
        {
            return producto;
        }

        public void SetProducto(Productos producto)
        {
            this.producto = producto;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (producto != null)
            {
                cboMarca.SelectedIndex = (int)producto.MarcaId;
                txtSabor.Text = producto.Sabor;
                cboCategorias.SelectedIndex = (int)producto.CategoriaId;
                txtCodigoBarras.Text = producto.CodBarras.ToString();
                cboTamanio.SelectedIndex = (int)producto.TamanioId!;
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
    }
}
