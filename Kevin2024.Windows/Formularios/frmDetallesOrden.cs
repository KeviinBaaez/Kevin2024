using Kevin2024.Entidades.Entidades;
using Kevin2024.Windows.Helpers;

namespace Kevin2024.Windows.Formularios
{
    public partial class frmDetallesOrden : Form
    {
        private OrdenPedido? orden;
        public frmDetallesOrden()
        {
            InitializeComponent();
        }

        public void SetOrden(OrdenPedido? orden)
        {
            if (orden != null)
            {
                this.orden = orden;
                MostrarOrden();
                GridHelper.MostrarDatosEnGrilla<DetalleOrden>(orden!.Detalles, dgvDatos);
            }
            else
            {
                MessageBox.Show("Sucedio un error inesperado!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void frmDetalleVenta_Load(object sender, EventArgs e)
        {
            MostrarOrden();
            GridHelper.MostrarDatosEnGrilla<DetalleOrden>(orden!.Detalles, dgvDatos);
        }

        private void MostrarOrden()
        {
            txtOrdenNro.Text = $"{orden!.OrdenId}";
            txtTipoOrden.Text = $"{orden.TipoOrden!.Descripcion}";
            txtCliente.Text = $"{orden.Cliente!.Nombres} {orden.Cliente.Apellido}";
            txtFecha.Text = $"{orden.FechaOrden.ToShortDateString()}";
            txtEstado.Text = $"{orden.EstadoPago!.Descripcion}";
            txtTotal.Text = $"{orden.Total}";
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
