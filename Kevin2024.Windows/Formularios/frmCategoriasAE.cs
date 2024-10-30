using Kevin2024.Entidades.Entidades;

namespace Kevin2024.Windows.Formularios
{
    public partial class frmCategoriasAE : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private Categorias? categoria;
        public frmCategoriasAE(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }



        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDaros())
            {
                if (categoria is null)
                {
                    categoria = new Categorias();
                }
                categoria.Descripcion = txtCategoria.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDaros()
        {
            errorProvider1.Clear();
            bool valido = true;
            if (string.IsNullOrEmpty(txtCategoria.Text))
            {
                valido = false;
                errorProvider1.SetError(txtCategoria, "Ingrese el nombre de la categoria");
            }
            return valido;
        }

        private void frmCategoriasAE_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public Categorias? GetCategoria()
        {
            return categoria;
        }
        public void SetCategoria(Categorias categoria)
        {
            this.categoria = categoria;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (categoria != null)
            {
                txtCategoria.Text = categoria.Descripcion;
            }
        }
    }
}
