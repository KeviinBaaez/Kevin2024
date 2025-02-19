using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.ViewModels;
using Kevin2024.Servicios.Interfaces;
using Kevin2024.Windows.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace Kevin2024.Windows.Formularios
{
    public partial class frmTelefonos : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        TelefonoConTipoVm? telefonoConTipoVm;
        TipoTelefono? tipoTelefono;
        Telefonos? telefono;

        public frmTelefonos(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }



        public TelefonoConTipoVm? GetTelefonoCliente()
        {
            return telefonoConTipoVm;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                var telefono = new Telefonos
                {
                    Numero = txtNumero.Text
                };

                var tipoTelefono = (TipoTelefono?)cboTipoTelefonos.SelectedItem;
                telefonoConTipoVm = new TelefonoConTipoVm(telefono, tipoTelefono);
                DialogResult = DialogResult.OK;
            }
        }

        public void SimularClick()
        {
            if (ValidarDatos())
            {
                var telefono = new Telefonos
                {
                    Numero = txtNumero.Text
                };

                var tipoTelefono = (TipoTelefono?)cboTipoTelefonos.SelectedItem;
                telefonoConTipoVm = new TelefonoConTipoVm(telefono, tipoTelefono);
                DialogResult = DialogResult.OK;
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
            if (cboTipoTelefonos.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(cboTipoTelefonos, "Ingrese el tipo de télefono");
            }
            return valido;
        }

        private void frmTelefonos_Load(object sender, EventArgs e)
        {
            CombosHelper.CargarComboTelefonos(ref cboTipoTelefonos, _serviceProvider);
        }

        private void cboTipoTelefonos_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoTelefono = cboTipoTelefonos.SelectedIndex > 0 ?
                (TipoTelefono?)cboTipoTelefonos.SelectedItem : null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public void SetTelefono(TelefonoConTipoVm telefonoConTipoVm)
        {
            this.telefonoConTipoVm = telefonoConTipoVm;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if(telefonoConTipoVm != null)
            {
                cboTipoTelefonos.SelectedValue = (int)telefonoConTipoVm.TipoTelefono!.TipoTelefonoId;
                txtNumero.Text = telefonoConTipoVm.Telefono.Numero;
            }
        }
    }
}
