using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Servicios.Interfaces;
using Kevin2024.Windows.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace Kevin2024.Windows.Formularios
{
    public partial class frmTelefonos : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private readonly IServiciosEmpleados? _servicios;
        Telefonos? telefono;
        
        public frmTelefonos(IServiceProvider? serviceProvider, IServiciosEmpleados? servicios)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _servicios = serviceProvider?.GetService<IServiciosEmpleados>() ?? 
                throw new ApplicationException("Dependencias no cargadas!!");
        }

        public Telefonos? GetTelefono()
        {
            return telefono;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if(telefono is null)
                {
                    telefono = new Telefonos();
                }
                telefono.TipoTelefono = txtTipo.Text;
                telefono.Numero = txtNumero.Text;

            }

        }

        private bool ValidarDatos()
        {
            bool valido = true;
            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                valido = false;
                errorProvider1.SetError(txtNumero, "Ingrese un numero válido");
            }
            if (string.IsNullOrEmpty(txtTipo.Text))
            {
                valido = false;
                errorProvider1.SetError(txtTipo, "Ingrese el tipo de télefono");
            }
            return valido;
        }
    }
}
