using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using Kevin2024.Servicios.Interfaces;
using Kevin2024.Windows.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace Kevin2024.Windows.Formularios
{
    public partial class frmCategoria : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private readonly IServiciosArchivos? _servicios;
        private List<TiposDeDatos>? lista;

        //Paginación
        private int currentPage = 1;//pagina actual
        private int totalPages = 0;//total de paginas
        private int pageSize = 10;//registros por página
        private int totalRecords = 0;//cantidad de registros


        //Filtro
        private Func<TiposDeDatos, bool>? filter = null;

        //Orden
        private Orden orden = Orden.Ninguno;

        //Tipo para busqueda
        Archivo archivo = Archivo.Categoria;

        public frmCategoria(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _servicios = _serviceProvider?.GetService<IServiciosArchivos>() ??
                throw new ApplicationException("Dependencias no cargadas!!");
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            RecargarGrilla();
        }
        private void RecargarGrilla()
        {
            try
            {
                totalRecords = _servicios!.GetCantidad(archivo, filter);
                totalPages = (int)Math.Ceiling((decimal)totalRecords / pageSize);
                LoadData(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void LoadData(Func<TiposDeDatos, bool>? filter = null)
        {
            try
            {
                lista = _servicios!.GetLista(archivo, currentPage, pageSize, orden, filter);
                if (lista!.Count > 0)
                {
                    GridHelper.MostrarDatosEnGrilla<TiposDeDatos>(lista, dgvDatos);
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
            frmNuevoTipoAE frm = new frmNuevoTipoAE(_serviceProvider, archivo) { Text = "Nueva Categoria" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            try
            {
                TiposDeDatos? categoria = frm.GetTipoDeDato();
                if (categoria is null) return;
                if (!_servicios!.Existe(archivo, categoria))
                {
                    _servicios.Guardar(archivo, categoria);
                    totalRecords = _servicios!.GetCantidad(archivo, filter);
                    totalPages = (int)Math.Ceiling((decimal)totalRecords / pageSize);
                    currentPage = _servicios.GetPaginaPorRegistro(archivo, categoria.Descripcion, pageSize);
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
        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0) return;
            var r = dgvDatos.SelectedRows[0];
            if (r.Tag is null) return;
            TiposDeDatos? categoria = (TiposDeDatos)r.Tag;
            frmNuevoTipoAE frm = new frmNuevoTipoAE(_serviceProvider, archivo) { Text = "Editar Categoría" };
            frm.SetTipoDeDato(categoria);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            categoria = frm.GetTipoDeDato();
            if (categoria is null) return;
            try
            {
                if (!_servicios!.Existe(archivo, categoria))
                {
                    _servicios.Guardar(archivo, categoria);
                    GridHelper.SetearFila(r, categoria);
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
            TiposDeDatos categoria = (TiposDeDatos)r.Tag;
            DialogResult dr = MessageBox.Show($"¿Deseas dar de baja la categoria: {categoria.Descripcion}?",
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
                if (!_servicios!.EstaRelacionado(archivo, categoria.TipoId))
                {
                    _servicios!.Borrar(archivo, categoria.TipoId);
                    totalRecords = _servicios!.GetCantidad(archivo, filter);
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
            frmFiltro frm = new frmFiltro(archivo) { Text = "Ingresar texto para buscar..." };
            DialogResult dr = frm.ShowDialog(this);
            try
            {
                var textoFiltro = frm.GetTexto();
                if (textoFiltro is null || textoFiltro == string.Empty) return;
                filter = b => b.Descripcion!.ToUpper().Contains(textoFiltro.ToUpper());
                totalRecords = _servicios!.GetCantidad(archivo, filter);
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
            if (cboPaginas.SelectedIndex >= 0)
            {
                currentPage = int.Parse(cboPaginas.Text);
                LoadData(filter);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0) return;
            var r = dgvDatos.SelectedRows[0];
            if (r.Tag == null) return;
            TiposDeDatos consulta = (TiposDeDatos)r.Tag;
            frmProductos frm = new frmProductos(_serviceProvider);
            frm.SetConsulta(consulta);
            frm.ShowDialog();
        }


    }
}
