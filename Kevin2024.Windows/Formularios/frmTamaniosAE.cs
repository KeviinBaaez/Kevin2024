using Kevin2024.Entidades.Entidades;

namespace Kevin2024.Windows.Formularios
{
    public partial class frmTamaniosAE : Form
    {
        private readonly IServiceProvider? _servicePrvider;
        private Tamanio? tamanio;
        public frmTamaniosAE(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            _servicePrvider = serviceProvider;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDaros())
            {
                if (tamanio is null)
                {
                    tamanio = new Tamanio();
                }
                tamanio.Descripcion = txtTamanio.Text;
                tamanio.Cantidad = (int)NudCantidad.Value;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDaros()
        {
            errorProvider1.Clear();
            bool valido = true;
            if (string.IsNullOrEmpty(txtTamanio.Text))
            {
                valido = false;
                errorProvider1.SetError(txtTamanio, "Ingrese la descripcion delTamaño");
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

        public Tamanio? GetTamanio()
        {
            return tamanio;
        }
        public void SetTamanio(Tamanio tamanio)
        {
            this.tamanio = tamanio;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (tamanio != null)
            {
                txtTamanio.Text = tamanio.Descripcion;
                NudCantidad.Value = tamanio.Cantidad;
            }
        }
    }
}
