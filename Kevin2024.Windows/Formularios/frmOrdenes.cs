using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using Kevin2024.Servicios.Interfaces;
using Kevin2024.Windows.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace Kevin2024.Windows.Formularios
{
    public partial class frmOrdenes : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private readonly IServiciosOrden? _servicios;
        private List<OrdenListDto>? lista;
        //Paginación
        private int currentPage = 1;
        private int totalPages = 0;
        private int pageSize = 10;
        private int totalRecords = 0;

        //Filtro
        private Func<OrdenListDto, bool>? filter = null;

        //Orden 
        Orden orden = Orden.Ninguno;

        public frmOrdenes(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _servicios = _serviceProvider?.GetService<IServiciosOrden>() ??
                throw new ApplicationException("Dependencias no cargadas!!");
        }

        private void frmOrdenes_Load(object sender, EventArgs e)
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
        private void LoadData(Func<OrdenListDto, bool>? filter = null)
        {
            try
            {
                lista = _servicios!.GetLista(currentPage, pageSize, orden, filter);
                if (lista!.Count > 0)
                {
                    GridHelper.MostrarDatosEnGrilla<OrdenListDto>(lista, dgvDatos);
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
            frmVentasAE frm = new frmVentasAE(_serviceProvider);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            try
            {
                OrdenPedido? orden = frm.GetOrden();
                if (orden is null) return;
                _servicios!.Guardar(orden);
                totalRecords = _servicios!.GetCantidad(null);
                totalPages = (int)Math.Ceiling((decimal)totalRecords / pageSize);
                currentPage = totalPages;
                LoadData();

                MessageBox.Show("Orden realizada con exito",
                    "Mensaje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,
                    "Mensaje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public void NuevaOrden(OrdenPedido orden)
        {
            try
            {
                if (orden is null) return;
                _servicios!.Guardar(orden);
                totalRecords = _servicios!.GetCantidad(null);
                totalPages = (int)Math.Ceiling((decimal)totalRecords / pageSize);
                currentPage = totalPages;
                LoadData();

                MessageBox.Show("Orden realizada con exito",
                    "Mensaje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,
                    "Mensaje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0) return;
            var r = dgvDatos.SelectedRows[0];
            if (r.Tag == null) return;
            OrdenListDto ordenDto = (OrdenListDto)r.Tag;
            DialogResult dr = MessageBox.Show($"¿Deseas dar de baja la siguiente venta?\n Venta: {ordenDto.OrdenId} - {ordenDto.FechaOrden}\n Total: {ordenDto.Total}",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                return;
            }

            _servicios!.Borrar(ordenDto.OrdenId);
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
                filter = o => (o.OrdenId.ToString().Contains(textoFiltro));
                //filter = v => (v.Cliente!.ToUpper().Contains(textoFiltro.ToUpper()) ||
                //v.TipoDeOrden  .ToString().ToUpper().Contains(textoFiltro.ToUpper()));
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
            OrdenListDto ordenDto = (OrdenListDto)r.Tag!;
            OrdenPedido? orden = _servicios!.GetOrdenPorId(ordenDto.OrdenId);
            frmDetallesOrden frm = new frmDetallesOrden();
            frm.SetOrden(orden);
            frm.ShowDialog(this);
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                var filaSeleccioanda = e.RowIndex;
                var r = dgvDatos.Rows[filaSeleccioanda];
                OrdenListDto ordenDto = (OrdenListDto)r.Tag!;
                if (ordenDto.EstadoOrdenId == 4) return;
                OrdenPedido? orden = _servicios!.GetOrdenPorId(ordenDto.OrdenId);
                if (orden is null) return;
                frmEstadoOrdenAE frm = new frmEstadoOrdenAE(_serviceProvider);
                frm.SetOrden(orden);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel) return;
                LoadData();
            }
            if (e.ColumnIndex == 7)
            {
                var filaSeleccioanda = e.RowIndex;
                var r = dgvDatos.Rows[filaSeleccioanda];
                OrdenListDto ordenDto = (OrdenListDto)r.Tag!;
                if (ordenDto.EstadoPagoId == 1) return;
                OrdenPedido? orden = _servicios!.GetOrdenPorId(ordenDto.OrdenId);
                if (orden is null) return;
                frmEstadoPago frm = new frmEstadoPago(_serviceProvider);
                frm.SetOrden(orden);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel) return;
                LoadData();
            }
        }

        private void cboEstadoOrdenFiltro_Click(object sender, EventArgs e)
        {
            if (cboEstadoOrdenFiltro.SelectedIndex == 1)
            {
                filter = o => (o.EstadoOrdenId == 1);
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
            if (cboEstadoOrdenFiltro.SelectedIndex == 2)
            {
                filter = o => (o.EstadoOrdenId == 2);
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
            if (cboEstadoOrdenFiltro.SelectedIndex == 3)
            {
                filter = o => (o.EstadoOrdenId == 3);
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
            if (cboEstadoOrdenFiltro.SelectedIndex == 4)
            {
                filter = o => (o.EstadoOrdenId == 4);
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
        }

        private void tsbFiltrar_Click(object sender, EventArgs e)
        {
            CombosHelper.CargarComboEstadoOrden(ref cboEstadoOrdenFiltro, _serviceProvider);
        }
    }
}
