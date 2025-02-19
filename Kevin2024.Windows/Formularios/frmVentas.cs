using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using Kevin2024.Servicios.Interfaces;
using Kevin2024.Windows.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace Kevin2024.Windows.Formularios
{
    public partial class frmVentas : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private readonly IServiciosVentas? _servicios;
        private List<VentaListDto>? lista;
        //Paginación
        private int currentPage = 1;
        private int totalPages = 0;
        private int pageSize = 10;
        private int totalRecords = 0;

        //Filtro
        private Func<VentaListDto, bool>? filter = null;

        //Orden 
        Orden orden = Orden.Ninguno;

        public frmVentas(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _servicios = _serviceProvider?.GetService<IServiciosVentas>() ??
                throw new ApplicationException("Dependencias no cargadas!!");
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            RecargarGrilla();
        }
        private void RecargarGrilla()
        {
            try
            {
                totalRecords = _servicios!.GetCantidad(filter);
                totalPages = (int)Math.Ceiling((decimal)totalRecords / pageSize);
                LoadData(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void LoadData(Func<VentaListDto, bool>? filter = null)
        {
            try
            {
                lista = _servicios!.GetLista(currentPage, pageSize, orden, filter);
                if (lista!.Count > 0)
                {
                    GridHelper.MostrarDatosEnGrilla<VentaListDto>(lista, dgvDatos);
                    if (cboPaginas.Items.Count != totalPages)
                    {
                        CombosHelper.CargarComboPaginas(ref cboPaginas, totalPages);
                    }
                    txtPaginas.Text = totalPages.ToString();
                    cboPaginas.SelectedIndexChanged -= CboPaginas_SelectedIndexChanged!;
                    cboPaginas.SelectedIndex = currentPage == 1 ? 0 : currentPage - 1;
                    cboPaginas.SelectedIndexChanged += CboPaginas_SelectedIndexChanged!;
                }
                else
                {
                    MessageBox.Show("No se encontraron registros..",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    currentPage = 1;
                    filter = null;
                    tsbFiltrar.Enabled = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            //frmVentasAE frm = new frmVentasAE(_serviceProvider);
            //DialogResult dr = frm.ShowDialog(this);
            //if (dr == DialogResult.Cancel) return;
            //try
            //{
            //    Venta? venta = frm.GetVenta();
            //    if (venta is null) return;
            //    _servicios!.Guardar(venta);
            //    totalRecords = _servicios!.GetCantidad(null);
            //    totalPages = (int)Math.Ceiling((decimal)totalRecords / pageSize);
            //    currentPage = totalPages;
            //    LoadData();

            //    MessageBox.Show("Venta realizada con exito",
            //        "Mensaje",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Information);

            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message,
            //        "Mensaje",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Error);
            //}
        }
        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0) return;
            var r = dgvDatos.SelectedRows[0];
            if (r.Tag == null) return;
            VentaListDto ventaDto = (VentaListDto)r.Tag;
            DialogResult dr = MessageBox.Show($"¿Deseas dar de baja la siguiente venta?\n Venta: {ventaDto.VentaId} - {ventaDto.FechaVenta}\n Total: {ventaDto.Total}",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                return;
            }

            _servicios!.Borrar(ventaDto.VentaId);
            totalRecords = _servicios!.GetCantidad(filter);
            totalPages = (int)Math.Ceiling((decimal)totalRecords / pageSize);
            if (currentPage > totalPages)
            {
                currentPage = totalPages;
            }
            LoadData();
            MessageBox.Show("Venta eliminada satisfactoriamente",
                    "Mensaje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            filter = null;
            orden = Orden.Ninguno;
            currentPage = 1;
            tsbFiltrar.Enabled = true;
            RecargarGrilla();
        }
        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void busquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFiltro frm = new frmFiltro(Archivo.Ninguno) { Text = "Escriba para buscar" };
            DialogResult dr = frm.ShowDialog(this);
            try
            {
                var textoFiltro = frm.GetTexto();
                if (string.IsNullOrEmpty(textoFiltro)) return;
                filter = v => (v.Cliente!.ToUpper().Contains(textoFiltro.ToUpper()) ||
                v.TipoDeOrden!.ToString().ToUpper().Contains(textoFiltro.ToUpper()));
                totalRecords = _servicios!.GetCantidad(filter);
                currentPage = 1;
                if (totalRecords > 0)
                {
                    totalPages = (int)Math.Ceiling((decimal)totalRecords / pageSize);
                    tsbFiltrar.Enabled = false;
                    LoadData(filter);
                }
                else
                {
                    MessageBox.Show("No se encontraron registros..",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    filter = null;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        private void ordenAZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orden = Orden.OrdenAZ;
            LoadData(filter);
        }
        private void ordenZAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orden = Orden.OrdenZA;
            LoadData(filter);
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadData(filter);
        }
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadData(filter);
            }
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadData(filter);
            }
        }
        private void btnUltimo_Click(object sender, EventArgs e)
        {
            currentPage = totalPages;
            LoadData(filter);
        }
        private void CboPaginas_SelectedIndexChanged(object? sender, EventArgs e)
        {
            currentPage = int.Parse(cboPaginas.Text);
            LoadData(filter);
        }

        private void tsbdetalles_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0) return;
            var r = dgvDatos.SelectedRows[0];
            VentaListDto ventaDto = (VentaListDto)r.Tag!;
            Venta? venta = _servicios!.GetVentaPorId(ventaDto.VentaId);
            frmDetallesVentas frm = new frmDetallesVentas();
            frm.SetVenta(venta);
            frm.ShowDialog(this);
        }
    }
}
