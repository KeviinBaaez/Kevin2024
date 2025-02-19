using Kevin2024.Entidades;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Servicios.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Kevin2024.Windows.Formularios
{
    public partial class frmEstadoOrdenAE : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private readonly IServiciosOrden? _servicios;
        private readonly IServiciosVentas? _serviciosVentas;
        private OrdenPedido? orden;
        public frmEstadoOrdenAE(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _servicios = _serviceProvider!.GetService<IServiciosOrden>() ??
                throw new ApplicationException("Dependencias no cargadas!!");
            _serviciosVentas = _serviceProvider!.GetService<IServiciosVentas>() ??
                throw new ApplicationException("Dependencias no cargadas!!");
        }

        public void SetOrden(OrdenPedido orden)
        {
            this.orden = orden;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if (orden is null) return;
                _servicios!.CancelarOrden(orden.OrdenId);
                MessageBox.Show("Orden Cancelada!",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,
                    "Mensaje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnPendiente_Click(object sender, EventArgs e)
        {
            try
            {
                if (orden is null) return;
                _servicios!.OrdenPendiente(orden.OrdenId);
                MessageBox.Show("Orden Pendiente!",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,
                    "Mensaje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnEnviado_Click(object sender, EventArgs e)
        {
            try
            {
                if (orden is null) return;
                _servicios!.OrdenEnviada(orden.OrdenId);
                MessageBox.Show("Orden Enviada!",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,
                    "Mensaje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCompletado_Click(object sender, EventArgs e)
        {
            try
            {
                if (orden is null) return;
                _servicios!.OrdenCompletada(orden.OrdenId);
                MessageBox.Show("Orden Completada!",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);


                Venta venta = new Venta();
                venta.ClienteId = orden.ClienteId;
                venta.Cliente = orden.Cliente;
                venta.FechaVenta = orden.FechaOrden;
                venta.Regalo = orden.Regalo;
                venta.Total = orden.Total;
                venta.TipoVenta = orden.TipoOrden;
                venta.TipoVentaId = orden.TipoOrden!.TipoOrdenId;
                venta.EstadoPago = orden.EstadoPago;
                venta.EstadoPagoId = orden.EstadoPago!.EstadoPagoId;
                foreach (var produc in orden.Detalles)
                {
                    Productos productos = (Productos)produc.Productos!;
                    DetalleVenta detalle = new DetalleVenta
                    {
                        ProductoId = productos is Productos ? productos.ProductoId : null,
                        ComboId = productos is Combo ? productos.ProductoId : null,
                        Productos = productos is Productos producto ? producto : null,
                        Combo = productos is Combo combo ? combo : null,
                        Precio = productos.PrecioVenta,
                    };
                    venta!.AgregarDetalleVenta(detalle);
                }


                _serviciosVentas!.Guardar(venta);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,
                    "Mensaje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
