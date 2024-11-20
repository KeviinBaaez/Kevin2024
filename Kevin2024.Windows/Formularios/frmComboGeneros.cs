using Kevin2024.Entidades.Entidades;
using Kevin2024.Windows.Helpers;

namespace Kevin2024.Windows.Formularios
{
    public partial class frmComboGeneros : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private TiposDeDatos? generoSeleccionado;
        public frmComboGeneros(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        public TiposDeDatos? GetGenero()
        {
            return generoSeleccionado;
        }

        private void frmComboGeneros_Load(object sender, EventArgs e)
        {

            CombosHelper.CargarComboGeneros(ref cboGeneros, _serviceProvider);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (generoSeleccionado == null)
            {
                generoSeleccionado = new TiposDeDatos();
            }
            generoSeleccionado.TipoId = (int)cboGeneros.SelectedValue!;
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
