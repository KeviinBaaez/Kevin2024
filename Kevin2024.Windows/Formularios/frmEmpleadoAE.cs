using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using Kevin2024.Servicios.Interfaces;
using Kevin2024.Windows.Helpers;
using Microsoft.Extensions.DependencyInjection;
using System.Drawing.Printing;
using System.Text.RegularExpressions;

namespace Kevin2024.Windows.Formularios
{
    public partial class frmEmpleadoAE : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private readonly IServiciosEmpleados? _serviciosEmpleados;
        private Empleados? empleado;

        private List<Telefonos>? telefonos;

        private string imagenNoDisponible = Environment.CurrentDirectory + @"\Imágenes\SinImagenDisponible.jpg";
        private string archivoNoEncontrado = Environment.CurrentDirectory + @"\Imágenes\ArchivoNoEncontrado.jpg";
        private string? archivoImagen = string.Empty;
        private string carpetaImagen = Environment.CurrentDirectory + @"\Imágenes\";
        public frmEmpleadoAE(IServiceProvider? serviceProvider, IServiciosEmpleados? serviciosEmpleados)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _serviciosEmpleados = serviceProvider?.GetService<IServiciosEmpleados>() ??
                throw new ApplicationException("Dependencias no cargadas");
        }

        public Empleados? GetEmpleado()
        {
            return empleado;
        }

        public void SetEmpleado(Empleados empleado)
        {
            this.empleado = empleado;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (empleado is null)
                {
                    empleado = new Empleados();
                }

                empleado.Nombre = txtNombre.Text;
                empleado.Apellido = txtApellido.Text;
                empleado.Dni = txtDni.Text;
                empleado.FechaNac = dtFechaNac.Value;
                empleado.FechaContrato = dtFechaContrato.Value;
                empleado.Salario = (double)nupSalario.Value;
                empleado.GeneroId = (int)cboGeneros.SelectedValue!;
                empleado.Suspendido = checkBox1.Checked;

                empleado.Imagen = archivoImagen;

                if (!string.IsNullOrWhiteSpace(empleado.Imagen))
                {
                    if (!File.Exists($"{carpetaImagen}{empleado.Imagen}"))
                    {
                        picImagen.Image = Image.FromFile(archivoNoEncontrado);
                    }
                    else
                    {
                        picImagen.Image = Image.FromFile($"{carpetaImagen}{empleado.Imagen}");
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
            errorProvider1.Clear();
            bool valido = true;
            Regex regex = new Regex(@"^[0-9]{1,2}\.[0-9]{3}\.[0-9]{3}$");
            Regex regex2 = new Regex(@"^[0-9]{8}$");
            DateTime fechaActual = DateTime.Today;
            int años = fechaActual.Year - dtFechaNac.Value.Year;
            int meses = fechaActual.Month - dtFechaNac.Value.Month;
            int dias = fechaActual.Day - dtFechaNac.Value.Day;

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                valido = false;
                errorProvider1.SetError(txtNombre, "Ingrese el nombre");
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                valido = false;
                errorProvider1.SetError(txtApellido, "Ingrese el apellido");
            }
            if (!(regex2.IsMatch(txtDni.Text)))
            {
                if (!regex.IsMatch(txtDni.Text))
                {
                    valido = false;
                    errorProvider1.SetError(txtDni, "Ingrese el número de documento");
                }
            }
            if (años < 18)
            {
                valido = false;
                errorProvider1.SetError(dtFechaNac, "El empledo es menor de edad");
            }
            else if (meses < 0)
            {

                valido = false;
                errorProvider1.SetError(dtFechaNac, "El empledo es menor de edad");

            }
            else if (dias < 0)
            {
                valido = false;
                errorProvider1.SetError(dtFechaNac, "El empledo es menor de edad");
            }
            if (dtFechaContrato.Value > DateTime.Now)
            {
                valido = false;
                errorProvider1.SetError(dtFechaContrato, "Ingrese una fecha coherente");
            }
            if (cboGeneros.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(cboGeneros, "Seleccione el genero");
            }

            return valido;
        }

        private void frmEmpleadosAE_Load(object sender, EventArgs e)
        {
            CombosHelper.CargarComboGeneros(ref cboGeneros, _serviceProvider);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (empleado != null)
            {
                txtNombre.Text = empleado.Nombre;
                txtApellido.Text = empleado.Apellido;
                txtDni.Text = empleado.Dni;
                dtFechaNac.Value = empleado.FechaNac;
                dtFechaContrato.Value = empleado.FechaContrato;
                nupSalario.Value = (decimal)empleado.Salario;
                cboGeneros.SelectedIndex = (int)empleado.GeneroId;
                checkBox1.Checked = empleado.Suspendido;
                if (empleado.Imagen != string.Empty)
                {
                    if (!File.Exists($"{carpetaImagen}{empleado.Imagen}"))
                    {
                        picImagen.Image = Image.FromFile(archivoNoEncontrado);
                    }
                    else
                    {
                        picImagen.Image = Image.FromFile($"{carpetaImagen}{empleado.Imagen}");
                        archivoImagen = empleado.Imagen;
                    }
                }
                else
                {
                    picImagen.Image = Image.FromFile(imagenNoDisponible);
                }
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
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

        private void btnAgregarT_Click(object sender, EventArgs e)
        {
            
        }
    }
}
