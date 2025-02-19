using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.ViewModels;
using Kevin2024.Servicios.Interfaces;
using Kevin2024.Windows.Helpers;
using Microsoft.Extensions.DependencyInjection;
using System.Text.RegularExpressions;


namespace Kevin2024.Windows.Formularios
{
    public partial class frmClienteAE : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private readonly IServiciosClientes? _servicios;
        private readonly IServiciosTiposDeDirecciones? _serviciosTiposDirecciones;
        private readonly IServiciosTiposDeTelefonos? _serviciosTiposTelefonos;

        private List<TelefonoConTipoVm> telefonos = new();
        private List<DireccionConTipoVm> direcciones = new();

        private Cliente? cliente;
        public frmClienteAE(IServiceProvider? serviceProvider, IServiciosClientes? servicios = null)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _servicios = _serviceProvider?.GetService<IServiciosClientes>() ??
            throw new ApplicationException("Dependencias no cargadas!!");
            _serviciosTiposDirecciones = _serviceProvider?.GetService<IServiciosTiposDeDirecciones>() ??
            throw new ApplicationException("Dependencias no cargadas!!");
            _serviciosTiposTelefonos = _serviceProvider?.GetService<IServiciosTiposDeTelefonos>() ??
            throw new ApplicationException("Dependencias no cargadas!!");
        }

        public Cliente? GetCliente()
        {
            return cliente;
        }

        public void SetCliente(Cliente cliente)
        {
            this.cliente = cliente;
        }

        private void frmClienteAE_Load(object sender, EventArgs e)
        {
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (cliente == null)
                {
                    cliente = new Cliente();
                }
                cliente.Documento = int.Parse(txtDocumento.Text);
                cliente.Apellido = txtApellido.Text;
                cliente.Nombres = txtNombre.Text;
                cliente.ClienteDirecciones = direcciones.Select(d => new ClienteDireccion
                {
                    TipoDireccionId = d.TipoDireccion?.TipoDireccionId ?? 0,
                    Direccion = d.Direccion!,
                    TipoDireccion = d.TipoDireccion!
                }).ToList();
                cliente.ClienteTelefonos = telefonos.Select(d => new ClienteTelefono
                {
                    TipoTelefonoId = d.TipoTelefono?.TipoTelefonoId ?? 0,
                    Telefono = d.Telefono,
                    TipoTelefono = d.TipoTelefono!
                }).ToList();
            }
            DialogResult = DialogResult.OK;
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!Regex.IsMatch(txtDocumento.Text, @"^\d{8}$"))
            {
                valido = false;
                errorProvider1.SetError(txtDocumento, "Documento debe tener exactamente 8 caracteres numéricos.");
            }
            if (string.IsNullOrEmpty(txtApellido.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(txtApellido, "Apellido es requerido");
            }
            if (string.IsNullOrEmpty(txtNombre.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(txtApellido, "Nombre es requerido");
            }

            return valido;
        }

        private void btnAgregarDireccion_Click(object sender, EventArgs e)
        {
            frmDireccionAE frm = new frmDireccionAE(_serviceProvider);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            DireccionConTipoVm? direccionConTipoVm = frm.GetDireccion();
            if (direccionConTipoVm is null) return;
            if (direccionConTipoVm.Direccion == null) return;
            if (direcciones.Any(dt => dt.Direccion!.Calle == direccionConTipoVm.Direccion.Calle &&
            dt.Direccion.Altura == direccionConTipoVm.Direccion.Altura))
            {
                MessageBox.Show("La dirección ya existe en la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            direcciones.Add(direccionConTipoVm);
            GridHelper.MostrarDatosEnGrilla<DireccionConTipoVm>(direcciones, dgvDirecciones);
        }
        private void btnEditarDireccion_Click(object sender, EventArgs e)
        {
            if (dgvDirecciones.SelectedRows.Count == 0) return;
            var r = dgvDirecciones.SelectedRows[0];
            if (r.Tag is null) return;
            DireccionConTipoVm? direccionConTipoVm = (DireccionConTipoVm)r.Tag;
            frmDireccionAE frm = new frmDireccionAE(_serviceProvider);
            frm.SetDireccionTipoVm(direccionConTipoVm);
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.Cancel) return;
            direcciones.Remove(direccionConTipoVm);
            direccionConTipoVm = frm.GetDireccion();
            if (direccionConTipoVm is null) return;
            try
            {
                if (direccionConTipoVm.Direccion is null) return;
                if (direcciones.Any(dt => dt.Direccion!.Calle == direccionConTipoVm.Direccion.Calle &&
                dt.Direccion.Altura == direccionConTipoVm.Direccion.Altura))
                {
                    MessageBox.Show("La dirección ya existe en la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                direcciones.Add(direccionConTipoVm);
                GridHelper.SetearFila(r, direccionConTipoVm);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
        private void btnBorrarDireccion_Click(object sender, EventArgs e)
        {
            if (dgvDirecciones.SelectedRows.Count == 0) return;
            var r = dgvDirecciones.SelectedRows[0];
            if (r.Tag is null) return;
            DireccionConTipoVm? direccionConTipoVm = (DireccionConTipoVm)r.Tag;
            DialogResult dr = MessageBox.Show($"¿Deseas eliminar esta dirección:\n {direccionConTipoVm.Direccion!.ToString()}?",
                "Mensaje",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) return;
            direcciones.Remove(direccionConTipoVm);
            GridHelper.QuitarFila(r, dgvDirecciones);
        }

        private void btnAgregarTelefono_Click(object sender, EventArgs e)
        {
            frmTelefonos frm = new frmTelefonos(_serviceProvider);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            TelefonoConTipoVm? telefonoConTipoVm = frm.GetTelefonoCliente();
            if (telefonoConTipoVm is null) return;
            if (telefonos.Any(t => t.Telefono.Numero == telefonoConTipoVm.Telefono.Numero))
            {
                MessageBox.Show("El teléfono ya existe en la lista.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            telefonos.Add(telefonoConTipoVm);
            GridHelper.MostrarDatosEnGrilla<TelefonoConTipoVm>(telefonos, dgvTelefonos);
        }
        private void btnEditarTelefono_Click(object sender, EventArgs e)
        {
            if (dgvTelefonos.SelectedRows.Count == 0) return;
            var r = dgvTelefonos.SelectedRows[0];
            if (r.Tag is null) return;
            TelefonoConTipoVm? telefonoConTipoVm = (TelefonoConTipoVm)r.Tag;
            frmTelefonos frm = new frmTelefonos(_serviceProvider);
            frm.SetTelefono(telefonoConTipoVm);
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.Cancel) return;
            telefonos.Remove(telefonoConTipoVm);
            telefonoConTipoVm = frm.GetTelefonoCliente();
            if (telefonoConTipoVm is null) return;
            try
            {
                if (telefonos.Any(t => t.Telefono.Numero == telefonoConTipoVm.Telefono.Numero))
                {
                    MessageBox.Show("El teléfono ya existe en la lista.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                telefonos.Add(telefonoConTipoVm);
                GridHelper.SetearFila(r, telefonoConTipoVm);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
        private void btnBorrarTelefono_Click(object sender, EventArgs e)
        {
            if (dgvTelefonos.SelectedRows.Count == 0) return;
            var r = dgvTelefonos.SelectedRows[0];
            if (r.Tag is null) return;
            TelefonoConTipoVm? telefonoConTipoVm = (TelefonoConTipoVm)r.Tag;
            DialogResult dr = MessageBox.Show($"¿Deseas eliminar este Télefono:\n {telefonoConTipoVm.Telefono.Numero}?",
                "Mensaje",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) return;
            telefonos.Remove(telefonoConTipoVm);
            GridHelper.QuitarFila(r, dgvTelefonos);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (cliente != null)
            {
                txtDocumento.Text = cliente.Documento.ToString();
                txtApellido.Text = cliente.Apellido;
                txtNombre.Text = cliente.Nombres;
                if (cliente.ClienteDirecciones.Count > 0)
                {
                    foreach (var item in cliente.ClienteDirecciones)
                    {
                        Direccion? direccion = new Direccion();
                        direccion = _servicios!.GetDireccionPorId(item.DireccionId);
                        TipoDireccion tipoDireccion = new TipoDireccion();
                        tipoDireccion = _serviciosTiposDirecciones!.GetTipoDireccionPorId(item.TipoDireccionId);
                        DireccionConTipoVm vm = new DireccionConTipoVm(direccion!, tipoDireccion);
                        direcciones.Add(vm);
                    }
                    GridHelper.MostrarDatosEnGrilla<DireccionConTipoVm>(direcciones, dgvDirecciones);
                }
                if (cliente.ClienteTelefonos.Count > 0)
                {
                    foreach (var item in cliente.ClienteTelefonos)
                    {
                        Telefonos telefono = new Telefonos();
                        telefono = _servicios!.GetTelefonoPorId(item.TelefonoId);
                        TipoTelefono tipoTelefono = new TipoTelefono();
                        tipoTelefono = _serviciosTiposTelefonos!.GetTipoTelefonoPorId(item.TipoTelefonoId);
                        TelefonoConTipoVm vm = new TelefonoConTipoVm(telefono, tipoTelefono);
                        telefonos.Add(vm);
                    }
                    GridHelper.MostrarDatosEnGrilla<TelefonoConTipoVm>(telefonos, dgvTelefonos);
                }

            }
        }
    }
}
