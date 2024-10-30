using Kevin2024.Servicios.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Kevin2024.Windows.Formularios
{
    public partial class frmUsuario : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private readonly IServiciosLogin? _servicio;
        public frmUsuario(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _servicio = _serviceProvider?.GetService<IServiciosLogin>();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {


            if (ValidarDatos())
            {
                string usuario = txtUsuario.Text;
                string clave = txtPassword.Text;


                if (_servicio!.Conectar(usuario, clave))
                {
                    //MessageBox.Show("BIENVENIDO",
                    //    "Inicio Perfecto",
                    //    MessageBoxButtons.OK,
                    //    MessageBoxIcon.Information);
                    frmBebidas frm = new frmBebidas(_serviceProvider);
                    frm.ShowDialog(this);
                }
                else
                {
                    MessageBox.Show("Error",
                        "Error de Inicio",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    txtPassword.Clear();
                } 
            }
        }

        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            bool valido = true;
            if(string.IsNullOrEmpty(txtUsuario.Text))
            {
                valido = false;
                errorProvider1.SetError(txtUsuario, "Debes ingresar tu nombre de usuario");
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                valido = false;
                errorProvider1.SetError(txtPassword, "Ingrese su contraseña");
            }
            return valido;
        }
    }
}
