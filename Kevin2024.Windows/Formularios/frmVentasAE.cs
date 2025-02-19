using Kevin2024.Entidades;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using Kevin2024.Servicios.Interfaces;
using Kevin2024.Windows.Helpers;
using Kevin2024.Windows.UsersControls;
using Microsoft.Extensions.DependencyInjection;
using System.Text;

namespace Kevin2024.Windows.Formularios
{
    public partial class frmVentasAE : Form
    {

        private readonly IServiceProvider? _serviceProvider;
        private readonly IServiciosProductos? _serviciosProductos;
        private List<Productos>? lista;
        private TipoProducto tipoProducto = TipoProducto.Productos;
        private OrdenPedido? orden;

        public frmVentasAE(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _serviciosProductos = _serviceProvider?.GetService<IServiciosProductos>();
        }

        private void frmVentasAE_Load(object sender, EventArgs e)
        {
            orden = new OrdenPedido();
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            lista = _serviciosProductos!.GetListaProductos(tipoProducto);
            fmlProductos.Controls.Clear();
            foreach (var producto in lista!)
            {
                ucProducto ucProducto = new ucProducto();
                SetUcControl(ucProducto, producto);
                AgregarUcControl(ucProducto);
            }
        }

        private void AgregarUcControl(ucProducto ucProducto)
        {
            fmlProductos.Controls.Add(ucProducto);
        }

        private void SetUcControl(ucProducto ucProducto, Productos producto)
        {
            ucProducto.ProductoId = producto.ProductoId;
            ucProducto.ImagenProducto = producto.Imagen;
            ucProducto.NombreProducto = producto.Nombre;
            ucProducto.PrecioProducto = producto.PrecioVenta;
            ucProducto.btnAgregar.Tag = producto;
            ucProducto.btnAgregar.Click += BtnAgregar_Click;
        }

        private void BtnAgregar_Click(object? sender, EventArgs e)
        {
            if (sender is not null)
            {
                Button button = (Button)sender;
                Productos productos = (Productos)button.Tag!;
                DetalleOrden detalleOrden = new DetalleOrden
                {
                    ProductoId = productos is Productos ? productos.ProductoId : null,
                    ComboId = productos is Combo ? productos.ProductoId : null,
                    Productos = productos is Productos produc ? produc : null,
                    Combo = productos is Combo comb ? comb : null,
                    Precio = productos.PrecioVenta,
                    Cantidad = ObternerCantidad()
                };
                if(orden is null)
                {
                    orden = new OrdenPedido();
                }
                orden!.AgregarDetalleOrden(detalleOrden);
                GridHelper.MostrarDatosEnGrilla<DetalleOrden>(orden.Detalles, dgvDatos);
                MostrarTotal();
            }
        }

        private int ObternerCantidad()
        {
            var cantidad = int.Parse(lblCantidadPor.Text);
            return cantidad;
        }

        private void MostrarTotal()
        {
            lblTotal.Text = orden!.GetTotal().ToString();
            lblCantidad.Text = orden!.GetCantidad().ToString();
            lblCantidadPor.Text = 1.ToString();
        }

        private void btnCombos_Click(object sender, EventArgs e)
        {
            tipoProducto = TipoProducto.Combos;
            RecargarGrilla();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            tipoProducto = TipoProducto.Productos;
            RecargarGrilla();
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            frmCantidad frm = new frmCantidad();
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            var cantidad = frm.GetCantidad();
            lblCantidadPor.Text = cantidad.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                frmTomarOrden frm = new frmTomarOrden(_serviceProvider) { Text = "Seleccionar Cliente" };
                frm.SetTotal(lblTotal.Text);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                Cliente? cliente = frm.GetCliente();
                orden!.ClienteId = cliente!.ClienteId != 99999 ? cliente.ClienteId : null;
                orden.Cliente = cliente;
                orden.FechaOrden = DateTime.Now;
                orden.Regalo = frm.GetRegalo();
                orden.Total = orden!.GetTotal();

                TipoOrden? tipoOrden = frm.GetTipoOrden();
                orden.TipoOrdenId = tipoOrden!.TipoOrdenId;
                EstadoOrden? estadoOrden = frm.GetEstadoOrden();
                orden.EstadoOrdenId = estadoOrden!.EstadoOrdenId;
                EstadoPago? estadoPago = frm.GetEstadoPago();
                orden.EstadoPagoId = estadoPago!.EstadoPagoId;

                frmOrdenes frmOrdenes = new frmOrdenes(_serviceProvider);
                frmOrdenes.NuevaOrden(orden);
                LimpiarOrden();

            }
        }

        private void LimpiarOrden()
        {
            dgvDatos.Rows.Clear();
            lblCantidad.Text = "0";
            lblTotal.Text = "$0";
            orden = new OrdenPedido();
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (orden!.GetCantidad() == 0)
            {
                valido = false;
                errorProvider1.SetError(dgvDatos, "Ingresar al menos un ítem");
            }
            return valido;
        }

        public OrdenPedido? GetOrden()
        {
            return orden;
        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            Close();
            frmOrdenes frm = new frmOrdenes(_serviceProvider);
            frm.ShowDialog();
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var filaSeleccionada = e.RowIndex;
                var r = dgvDatos.Rows[filaSeleccionada];
                DetalleOrden dt = (DetalleOrden)r.Tag!;
                DialogResult dr = MessageBox.Show("¿Anula el item seleccionado?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No) return;

                var tipoProducto = dt.ProductoId is null ? TipoProducto.Combos : TipoProducto.Productos;
                var productoId = dt.ProductoId ?? dt.ComboId;
                var productoEnPedido = _serviciosProductos!.GetProductoPorId(tipoProducto, productoId!.Value);
                productoEnPedido!.EnPedido -= dt.Cantidad;
                _serviciosProductos.Guardar(productoEnPedido);

                orden!.Borrar(dt);
                GridHelper.QuitarFila(r, dgvDatos);
                MostrarTotal();
            }
            if (e.ColumnIndex == 6)
            {
                var filaSeleccionada = e.RowIndex;
                var r = dgvDatos.Rows[filaSeleccionada];
                DetalleOrden dt = (DetalleOrden)r.Tag!;
                frmCantidad frm = new frmCantidad();
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel) return;
                int cantidadVendida = frm.GetCantidad();
                lblCantidadPor.Text = cantidadVendida.ToString();

                var tipoProducto = dt.ProductoId is null ? TipoProducto.Combos : TipoProducto.Productos;
                var productoId = dt.ProductoId ?? dt.ComboId;
                var productoEnPedido = _serviciosProductos!.GetProductoPorId(tipoProducto, productoId!.Value);
                productoEnPedido!.EnPedido = productoEnPedido.EnPedido + cantidadVendida - dt.Cantidad;

                if (cantidadVendida <= productoEnPedido.Stock)
                {
                    _serviciosProductos.Guardar(productoEnPedido);

                    dt.Cantidad = cantidadVendida;
                    GridHelper.SetearFila(r, dt);
                    MostrarTotal();

                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("Stock Insuficiente" + Environment.NewLine);
                    sb.AppendFormat($"Stock disponible: {productoEnPedido.Stock}");
                    MessageBox.Show(sb.ToString(), "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
        }
    }
}
