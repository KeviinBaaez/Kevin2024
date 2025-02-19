using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using Kevin2024.Servicios.Interfaces;
using Kevin2024.Windows.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace Kevin2024.Windows.Formularios
{
    public partial class frmClientes : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private readonly IServiciosClientes? _servicios;
        private List<ClienteListDto>? lista;
        //Paginación
        private int currentPage = 1;
        private int totalPages = 0;
        private int pageSize = 10;
        private int totalRecords = 0;

        //Filtro
        private Func<ClienteListDto, bool>? filter = null;
        private TiposDeDatos? generoFiltro = null;

        //Orden 
        Orden orden = Orden.Ninguno;

        public frmClientes(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _servicios = _serviceProvider?.GetService<IServiciosClientes>() ??
                throw new ApplicationException("Dependencias no cargadas!!");
        }
        private void frmClientes_Load(object sender, EventArgs e)
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
        private void LoadData(Func<ClienteListDto, bool>? filter = null)
        {
            try
            {
                lista = _servicios!.GetLista(currentPage, pageSize, orden, filter);
                if (lista!.Count > 0)
                {
                    
                    GridHelper.MostrarDatosEnGrilla<ClienteListDto>(lista, dgvDatos);
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
            frmClienteAE frm = new frmClienteAE(_serviceProvider);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            try
            {
                Cliente? cliente = frm.GetCliente();
                if (cliente is null)
                {
                    return;
                }
                if (!_servicios!.Existe(cliente))
                {
                    _servicios.Guardar(cliente);
                    totalRecords = _servicios!.GetCantidad(filter);
                    totalPages = (int)Math.Ceiling((decimal)totalRecords / pageSize);
                    currentPage = _servicios.GetPaginaPorRegistro(cliente.Nombres, pageSize);
                    LoadData(filter);

                    MessageBox.Show("Registro agregado",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Registro existente\nAlta denegada",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            }
        }
        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0) return;
            var r = dgvDatos.SelectedRows[0];
            if (r.Tag == null) return;
            ClienteListDto clienteDto = (ClienteListDto)r.Tag;
            Cliente? cliente = _servicios!.GetClientePorId(clienteDto.ClienteId);
            if (cliente is null) return;
            frmClienteAE frm = new frmClienteAE(_serviceProvider) { Text = "Editar datos del Cliente" };
            frm.SetCliente(cliente);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            cliente = frm.GetCliente();
            if (cliente is null) return;
            try
            {
                if (!_servicios!.Existe(cliente))
                {
                    _servicios!.Guardar(cliente);
                    currentPage = _servicios!.GetPaginaPorRegistro(cliente.Nombres, pageSize);
                    LoadData();
                    int row = GridHelper.ObtenerRowIndex(dgvDatos, cliente.ClienteId);
                    GridHelper.MarcarRow(dgvDatos, row);
                    MessageBox.Show("Registro modificado satisfactoriamente!",
                            "Mensaje",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Registro existente\nEdición denegada",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0) return;
            var r = dgvDatos.SelectedRows[0];
            if (r.Tag == null) return;
            ClienteListDto clienteDto = (ClienteListDto)r.Tag;
            DialogResult dr = MessageBox.Show($"¿Deseas dar de baja el siguiente Cliente?\n Nombre y Apellido: {clienteDto.NombreCompleto}\n Dni: {clienteDto.Documento}",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                return;
            }

            _servicios!.Borrar(clienteDto.ClienteId);
            totalRecords = _servicios!.GetCantidad(filter);
            totalPages = (int)Math.Ceiling((decimal)totalRecords / pageSize);
            if (currentPage > totalPages)
            {
                currentPage = totalPages;
            }
            LoadData();
            MessageBox.Show("Registro eliminado satisfactoriamente",
                    "Mensaje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            filter = null;
            generoFiltro = null;
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
                filter = c => (c.NombreCompleto!.ToUpper().Contains(textoFiltro.ToUpper()))
                || (c.Documento!.ToString().Contains(textoFiltro.ToString()));
                totalRecords = _servicios!.GetCantidad(filter, generoFiltro);
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
    }
}
