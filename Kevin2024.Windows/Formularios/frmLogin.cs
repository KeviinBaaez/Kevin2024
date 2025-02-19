using Kevin2024.Entidades.Entidades;
using Kevin2024.Servicios.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Kevin2024.Windows.Formularios
{
    public partial class frmLogin : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private readonly IServiciosLogin? _servicio;
        private Usuario? usuario;
        public frmLogin(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _servicio = _serviceProvider?.GetService<IServiciosLogin>();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                string user = txtUsuario.Text;
                string clave = txtPassword.Text;
                usuario = _servicio!.GetUsuario(user, clave);

                if (usuario != null)
                {
                    Hide();
                    frmPrincipal frm = new frmPrincipal(_serviceProvider);
                    frm.FormClosing += Frm_FormClosing;
                    frm.SetUsuario(usuario);
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Ingrese un nombre de usuario y contraseña correctos.\nTenga en cuenta que ambos campos pueden distinguir\nentre mayúsculas y minúsculas",
                        "Error de Inicio",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtPassword.Clear();
                }
            }
        }

        private void Frm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            this.Show();
            LimpiarTextos();
        }

        private void LimpiarTextos()
        {
            txtUsuario.Clear();
            txtPassword.Clear();
            txtUsuario.Focus();
        }

        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            bool valido = true;
            if (string.IsNullOrEmpty(txtUsuario.Text))
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtPassword.Clear();
            txtUsuario.Focus();
        }
    }
}
