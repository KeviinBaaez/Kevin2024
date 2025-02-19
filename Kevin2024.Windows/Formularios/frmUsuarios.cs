using Kevin2024.Entidades.Entidades;
using Kevin2024.Servicios.Interfaces;
using Kevin2024.Windows.Helpers;
using Microsoft.Extensions.DependencyInjection;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Kevin2024.Windows.Formularios
{
    public partial class frmUsuarios : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private readonly IServiciosUsuarios? _servicio;
        private bool btn = true;
        private Usuario? usuario;


        private string imagenNoDisponible = Environment.CurrentDirectory + @"\ImágenesUsuarios\SinImagenDisponible.jpg";
        private string archivoNoEncontrado = Environment.CurrentDirectory + @"\ImágenesUsuarios\ArchivoNoEncontrado.jpg";
        private string? archivoImagen = string.Empty;
        private string carpetaImagen = Environment.CurrentDirectory + @"\ImágenesUsuarios\";

        public frmUsuarios(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _servicio = _serviceProvider?.GetService<IServiciosUsuarios>() ??
                throw new ApplicationException("Dependencias no cargadas");
            CombosHelper.CargarComboRoles(ref cboRoles, _serviceProvider);
            checkBox1.Checked = true;
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            CombosHelper.CargarComboRoles(ref cboRoles, _serviceProvider);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if(usuario  == null)
                {
                    usuario = new Usuario();
                    usuario.NombreUsuario = txtNombreUsuario.Text;
                    usuario.Clave = txtContraseña.Text.Trim();
                    usuario.RolId = (int)cboRoles.SelectedValue!;
                    usuario.Activo = checkBox1.Checked;
                    usuario.Imagen = archivoImagen;

                    if (!string.IsNullOrWhiteSpace(usuario.Imagen))
                    {
                        if (!File.Exists($"{carpetaImagen}{usuario.Imagen}"))
                        {
                            picImagen.Image = Image.FromFile(archivoNoEncontrado);
                        }
                        else
                        {
                            picImagen.Image = Image.FromFile($"{carpetaImagen}{usuario.Imagen}");
                        }
                    }
                    else
                    {
                        picImagen.Image = Image.FromFile(imagenNoDisponible);
                    }
                    if (!_servicio!.Existe(usuario))
                    {
                        _servicio.GuardarUsuario(usuario);

                        MessageBox.Show("Usuario registrado correctamente",
                            "Mensaje",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        txtNombreUsuario.Clear();
                        txtContraseña.Clear();
                        txtRepitContraseña.Clear();
                        cboRoles.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("Usuario existente\nAlta denegada",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                }
                usuario.NombreUsuario = txtNombreUsuario.Text;
                usuario.Clave = txtContraseña.Text.Trim();
                usuario.RolId = (int)cboRoles.SelectedValue!;
                usuario.Activo = checkBox1.Checked;
                usuario.Imagen = archivoImagen;

                if (!string.IsNullOrWhiteSpace(usuario.Imagen))
                {
                    if (!File.Exists($"{carpetaImagen}{usuario.Imagen}"))
                    {
                        picImagen.Image = Image.FromFile(archivoNoEncontrado);
                    }
                    else
                    {
                        picImagen.Image = Image.FromFile($"{carpetaImagen}{usuario.Imagen}");
                    }
                }
                else
                {
                    picImagen.Image = Image.FromFile(imagenNoDisponible);
                }
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtNombreUsuario.Text))
            {
                valido = false;
                errorProvider1.SetError(txtNombreUsuario, "Ingrese un nombre de usuiario");
            }
            Regex regex = new Regex(@"^(?=.*[A-Z]).*$");
            if (!regex.IsMatch(txtContraseña.Text))
            {
                valido = false;
                errorProvider1.SetError(txtContraseña, "Verifique que su contraseña\n al menos tenga una lectra mayúscula");
            }
            if (txtContraseña.Text != txtRepitContraseña.Text)
            {
                valido = false;
                errorProvider1.SetError(txtRepitContraseña, "La contraseñas no coinciden");
            }
            if (cboRoles.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(cboRoles, "Debes seleccionar un rol");
            }
            return valido;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btn)
            {
                txtContraseña.UseSystemPasswordChar = false;
                txtRepitContraseña.UseSystemPasswordChar = false;
                btn = false;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
                txtRepitContraseña.UseSystemPasswordChar = true;
                btn = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void SetUsuario(Usuario usuario)
        {
            this.usuario = usuario;
        }

        public Usuario? GetUsuario()
        {
            return usuario;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsers frm = new frmUsers(_serviceProvider);
            frm.ShowDialog();
        }

        private void btnBuscarImg_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory + @"Todos los archivos (.)|.|Archivos PNG (.png)|.png|Archivos JFIF (.jfif)|.jfif|Archivos JPG (.jpg)|.jpg";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            DialogResult dr = openFileDialog1.ShowDialog(this);

            if (dr == DialogResult.OK)
            {
                if (openFileDialog1.FileName == null)
                {
                    return;
                }
                picImagen.Image = Image.FromFile(openFileDialog1.FileName);
                archivoImagen = openFileDialog1.SafeFileName;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            if(usuario != null)
            {
                txtNombreUsuario.Text = usuario.NombreUsuario;
                txtContraseña.Text = usuario.Clave;
                txtRepitContraseña.Text = usuario.Clave;
                checkBox1.Checked = usuario.Activo;
                cboRoles.SelectedIndex = usuario.RolId;
                if (usuario.Imagen != string.Empty)
                {
                    if (!File.Exists($"{carpetaImagen}{usuario.Imagen}"))
                    {
                        picImagen.Image = Image.FromFile(archivoNoEncontrado);
                    }
                    else
                    {
                        picImagen.Image = Image.FromFile($"{carpetaImagen}{usuario.Imagen}");
                        archivoImagen = usuario.Imagen;
                    }
                }
                else
                {
                    picImagen.Image = Image.FromFile(imagenNoDisponible);
                }
            }
        }
    }
}
