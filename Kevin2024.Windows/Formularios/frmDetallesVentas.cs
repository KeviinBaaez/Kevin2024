using Kevin2024.Entidades.Entidades;
using Kevin2024.Windows.Helpers;

namespace Kevin2024.Windows.Formularios
{
    public partial class frmDetallesVentas : Form
    {

        private Venta? venta;
        public frmDetallesVentas()
        {
            InitializeComponent();
        }

        public void SetVenta(Venta? venta)
        {
            this.venta = venta;
        }

        private void frmDetalleVenta_Load(object sender, EventArgs e)
        {
            MostrarVenta();
            GridHelper.MostrarDatosEnGrilla<DetalleVenta>(venta!.Detalles, dgvDatos);
        }

        private void MostrarVenta()
        {
            txtCliente.Text = $"{venta!.Cliente!.Nombres} {venta.Cliente.Apellido}";
            txtFecha.Text = $"{venta.FechaVenta.ToShortDateString()}";
            txtVentaNro.Text = $"{venta.VentaId}";
            txtTotal.Text = $"{venta.Total}";
            txtEstado.Text = $"{venta.EstadoPago!.Descripcion}";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
