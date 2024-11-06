using Kevin2024.Entidades;
using Kevin2024.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kevin2024.Windows.Formularios
{
    public partial class frmEmpleadosAE : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private Empleados? empleado;
        public frmEmpleadosAE(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
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
                empleado.Dni = decimal.Parse(txtDni.Text);
                empleado.FechaNac = dtFechaNac.Value;
                empleado.FechaContrato = dtFechaContrato.Value;
                empleado.Salario = (double)nupSalario.Value;
                empleado.Suspendido = checkBox1.Checked;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            bool valido = true;
            decimal resultado;

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
            if (!decimal.TryParse(txtDni.Text, out resultado))
            {
                valido = false;
                errorProvider1.SetError(txtDni, "Un nro. de dno no puede contener caracteres especiales");
            }
            if (dtFechaNac.Value >= DateTime.Now)
            {
                valido = false;
                errorProvider1.SetError(dtFechaNac, "Ingrese una fecha coherente");
            }
            if (dtFechaContrato.Value > DateTime.Now)
            {
                valido = false;
                errorProvider1.SetError(dtFechaContrato, "Ingrese una fecha coherente");
            }

            return valido;
        }

        private void frmEmpleadosAE_Load(object sender, EventArgs e)
        {

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
                txtDni.Text = empleado.Dni.ToString();
                dtFechaNac.Value = empleado.FechaNac;
                dtFechaContrato.Value = empleado.FechaContrato;
                nupSalario.Value = (decimal)empleado.Salario;
                checkBox1.Checked = empleado.Suspendido; 
            }

        }
    }
}
