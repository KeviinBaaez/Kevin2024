using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using Kevin2024.Servicios.Interfaces;
using Kevin2024.Windows.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace Kevin2024.Windows.Formularios
{
    public partial class frmTamanios : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private readonly IServiciosTamanios? _servicios;
        private List<Tamanio>? lista;
        //Paginación
        private int currentPage = 1;
        private int totalPages = 0;
        private int pageSize = 10;
        private int totalRecords = 0;

        //Filtro
        private Func<Tamanio, bool>? filter = null;

        //Orden 
        private Orden orden = Orden.Ninguno;

        //Tipo para busqueda
        Tipos tipo = Tipos.Tamanio;
        public frmTamanios(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _servicios = _serviceProvider?.GetService<IServiciosTamanios>() ??
                throw new ApplicationException("Dependencias no cargadas!!");
        }

        private void frmTamanios_Load(object sender, EventArgs e)
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

        private void LoadData(Func<Tamanio, bool>? filter)
        {
            try
            {
                lista = _servicios!.GetLista(currentPage, pageSize, orden, filter);
                if (lista!.Count > 0)
                {
                    GridHelper.MostrarDatosEnGrilla<Tamanio>(lista, dgvDatos);
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
            frmNuevoTipoAE frm = new frmNuevoTipoAE(_serviceProvider, tipo) { Text = "Nuevo Tamaño" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            try
            {
                Tamanio? tamanio = frm.GetTamanio();
                if (tamanio is null) return;
                if (!_servicios!.Existe(tamanio))
                {
                    _servicios.Guardar(tamanio);
                    totalRecords = _servicios!.GetCantidad(filter);
                    totalPages = (int)Math.Ceiling((decimal)totalRecords / pageSize);
                    currentPage = _servicios.GetPaginaPorRegistro(tamanio.Descripcion, pageSize);
                    LoadData(filter);

                    MessageBox.Show("Registro agregado",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("¡Registro Existente!\nAlta denegada",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatos.SelectedRows[0];
            if (r.Tag is null)
            {
                return;
            }
            Tamanio tamanio = (Tamanio)r.Tag;
            DialogResult dr = MessageBox.Show($"¿Deseas dar de baja el tamaño: {tamanio.Descripcion}?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                return;
            }
            try
            {
                if (!_servicios!.EstaRelacionado(tamanio.TamanioId))
                {
                    _servicios!.Borrar(tamanio.TamanioId);
                    totalRecords = _servicios!.GetCantidad(filter);
                    totalPages = (int)Math.Ceiling((decimal)totalRecords / pageSize);
                    if (currentPage > totalPages)
                    {
                        currentPage = totalPages;
                    }
                    LoadData(filter);
                    MessageBox.Show("Registro eliminado satisfactoriamente",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("¡Registro relacionado!",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0) return;
            var r = dgvDatos.SelectedRows[0];
            if (r.Tag is null) return;
            Tamanio? tamanio = (Tamanio)r.Tag;
            frmNuevoTipoAE frm = new frmNuevoTipoAE(_serviceProvider, tipo) { Text = "Editar Tamanio" };
            frm.SetTamanio(tamanio);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            tamanio = frm.GetTamanio();
            try
            {
                if (tamanio is null) return;
                if (!_servicios!.Existe(tamanio))
                {
                    _servicios.Guardar(tamanio);
                    GridHelper.SetearFila(r, tamanio);
                    MessageBox.Show("Registro modificado satisfactoriamente",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("¡Registro Existente!\nEdicion denegada",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                throw;
            }
        }
        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void CboPaginas_SelectedIndexChanged(object? sender, EventArgs e)
        {
            currentPage = int.Parse(cboPaginas.Text);
            LoadData(filter);
        }

        private void busquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFiltro frm = new frmFiltro(tipo) { Text = "Ingresar texto para buscar..." };
            DialogResult dr = frm.ShowDialog(this);
            try
            {
                var textoFiltro = frm.GetTexto();
                if (textoFiltro is null || textoFiltro == string.Empty) return;
                filter = t => t.Descripcion.ToUpper().Contains(textoFiltro.ToUpper());
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

        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            filter = null;
            orden = Orden.Ninguno;
            currentPage = 1;
            tsbFiltrar.Enabled = true;
            RecargarGrilla();
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
    }
}
