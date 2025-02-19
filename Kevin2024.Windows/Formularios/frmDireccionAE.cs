using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.ViewModels;
using Kevin2024.Windows.Helpers;

namespace Kevin2024.Windows.Formularios
{
    public partial class frmDireccionAE : Form
    {
        private readonly IServiceProvider? _serviceProvider;

        private DireccionConTipoVm? direccionTipoVm;
        private Direccion? direccion;

        private TipoDireccion? tipoDireccion;
        public frmDireccionAE(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void frmDireccionAE_Load(object sender, EventArgs e)
        {
            CombosHelper.CargarComboDirecciones(ref cboTipoDireccion, _serviceProvider);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (direccion is null)
                {
                    direccion = new Direccion();
                }

                direccion.Calle = txtCalle.Text;
                direccion.Altura = txtAltura.Text;
                direccion.Entre1 = txtEntre1.Text;
                direccion.Entre2 = txtEntre2.Text;
                direccion.Piso = string.IsNullOrEmpty(txtPiso.Text) ? null : int.Parse(txtPiso.Text);
                direccion.Depto = txtDepto.Text;


                var tipoDireccion = (TipoDireccion?)cboTipoDireccion.SelectedItem;


                direccionTipoVm = new DireccionConTipoVm(direccion, tipoDireccion);
                DialogResult = DialogResult.OK;

            }
        }

        public void SimularClick()
        {
            if (ValidarDatos())
            {
                if (direccion is null)
                {
                    direccion = new Direccion();
                }

                direccion.Calle = txtCalle.Text.Trim();
                direccion.Altura = txtAltura.Text.Trim();
                direccion.Entre1 = txtEntre1.Text;
                direccion.Entre2 = txtEntre2.Text;
                direccion.Piso = string.IsNullOrEmpty(txtPiso.Text) ? null : int.Parse(txtPiso.Text);
                direccion.Depto = txtDepto.Text;


                var tipoDireccion = (TipoDireccion?)cboTipoDireccion.SelectedItem;


                direccionTipoVm = new DireccionConTipoVm(direccion, tipoDireccion);
                DialogResult = DialogResult.OK;

            }
        }
        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (cboTipoDireccion.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(cboTipoDireccion, "Debe seleccionar tipo de dirección");
            }
            if (string.IsNullOrEmpty(txtCalle.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(txtCalle, "Calle es requerido");
            }
            if (string.IsNullOrEmpty(txtAltura.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(txtCalle, "Altura requerida");
            }

            return valido;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public DireccionConTipoVm? GetDireccion()
        {
            return direccionTipoVm;
        }

        private void cboTipoDireccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoDireccion = cboTipoDireccion.SelectedIndex > 0 ?
                (TipoDireccion?)cboTipoDireccion.SelectedItem : null;
        }

        public void SetDireccion(Direccion direccion)
        {
            this.direccion = direccion;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (direccionTipoVm != null)
            {
                cboTipoDireccion.SelectedValue = (int)direccionTipoVm.TipoDireccion!.TipoDireccionId;
                txtCalle.Text = direccionTipoVm.Direccion!.Calle;
                txtAltura.Text = direccionTipoVm.Direccion.Altura;
                txtEntre1.Text = direccionTipoVm.Direccion.Entre1;
                txtEntre2.Text = direccionTipoVm.Direccion.Entre2;
                txtPiso.Text = direccionTipoVm.Direccion.Piso.ToString();
                txtDepto.Text = direccionTipoVm.Direccion.Depto;
            }

        }

        public void SetDireccionTipoVm(DireccionConTipoVm direccionConTipoVm)
        {
            this.direccionTipoVm = direccionConTipoVm;
        }
    }
}
