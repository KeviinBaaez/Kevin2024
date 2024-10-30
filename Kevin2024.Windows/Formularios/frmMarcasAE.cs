using Kevin2024.Entidades.Entidades;

namespace Kevin2024.Windows.Formularios
{
    public partial class frmMarcasAE : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private Marcas? marca;
        public frmMarcasAE(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }



        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDaros())
            {
                if (marca is null)
                {
                    marca = new Marcas();
                }
                marca.Nombre = txtMarca.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDaros()
        {
            errorProvider1.Clear();
            bool valido = true;
            if (string.IsNullOrEmpty(txtMarca.Text))
            {
                valido = false;
                errorProvider1.SetError(txtMarca, "Ingrese el nombre de la marca");
            }
            return valido;
        }

        private void frmMarcasAE_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public Marcas? GetMarca()
        {
            return marca;
        }
        public void SetMarca(Marcas marca)
        {
            this.marca = marca;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if(marca != null)
            {
                txtMarca.Text = marca.Nombre;
            }
        }
    }
}
