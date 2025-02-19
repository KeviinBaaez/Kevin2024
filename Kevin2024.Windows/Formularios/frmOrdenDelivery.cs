using Kevin2024.Entidades.ViewModels;

namespace Kevin2024.Windows.Formularios
{
    public partial class frmOrdenDelivery : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private DireccionConTipoVm? direccionTipoVm;
        private TelefonoConTipoVm? telefonoTipoVm;

        frmDireccionAE frmDireccion;
        frmTelefonos frmTelefono;
        public frmOrdenDelivery(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            frmDireccion = new frmDireccionAE(serviceProvider);
            frmTelefono = new frmTelefonos(serviceProvider);
        }

        private void frmOrdenDelivery_Load(object sender, EventArgs e)
        {
            AbrirFormularioDireccion(frmDireccion);
            AbrirFormularioTelefono(frmTelefono);
        }
        private void AbrirFormularioDireccion(Form formulario)
        {
            formulario.TopLevel = false;//El formulario no va a ser de nivel superior, se comportara como un control
            formulario.FormBorderStyle = FormBorderStyle.None;//Quitamos el borde del formulario
            formulario.Dock = DockStyle.Fill;//Formulario se acople a todo el panel
            panelDireccion.Controls.Add(formulario);//Agregamos el formulario al panel 
            panelDireccion.Tag = formulario;//Asociamos el formulario con el panel
            formulario.Show();
        }
        private void AbrirFormularioTelefono(Form formulario)
        {
            formulario.TopLevel = false;//El formulario no va a ser de nivel superior, se comportara como un control
            formulario.FormBorderStyle = FormBorderStyle.None;//Quitamos el borde del formulario
            formulario.Dock = DockStyle.Fill;//Formulario se acople a todo el panel
            panelTelefono.Controls.Add(formulario);//Agregamos el formulario al panel 
            panelTelefono.Tag = formulario;//Asociamos el formulario con el panel
            formulario.Show();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            frmDireccion.SimularClick();
            direccionTipoVm = frmDireccion.GetDireccion();
            if (direccionTipoVm == null) return;

            frmTelefono.SimularClick();
            telefonoTipoVm = frmTelefono.GetTelefonoCliente();
            if (telefonoTipoVm == null) return;
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public DireccionConTipoVm? GetDireccion()
        {
            return direccionTipoVm;
        }

        public TelefonoConTipoVm? GetTelefono()
        {
            return telefonoTipoVm;
        }
    }
}
