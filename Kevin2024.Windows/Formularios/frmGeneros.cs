using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using Kevin2024.Servicios.Interfaces;
using Kevin2024.Windows.Helpers;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Forms;

namespace Kevin2024.Windows.Formularios
{
    public partial class frmGeneros : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private readonly IServiciosTipos? _servicios;
        private List<TiposDeDatos>? lista;

        //Paginación
        private int currentPage = 1;
        private int pageSize = 10;
        private int totalPages = 0;
        private int totalRecords = 0;

        //Tipo
        private Tipos tipo = Tipos.Genero;

        //Filtro
        private Func<TiposDeDatos, bool>? filter = null;

        //Órden
        private Orden orden = Orden.Ninguno;

        public frmGeneros(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _servicios = _serviceProvider?.GetService<IServiciosTipos>() ?? throw new ArgumentException("Dependencias No Cargadas!!!");
        }

        private void frmGeneros_Load(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            try
            {
                totalRecords = _servicios!.GetCantidad(tipo, filter);
                totalPages = (int)Math.Ceiling((decimal)totalRecords / pageSize);
                currentPage = totalPages;
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
                lista = _servicios!.GetLista(tipo, currentPage, pageSize, orden, filter);
                if (lista!.Count > 0)
                {
                    GridHelper.MostrarDatosEnGrilla<TiposDeDatos>(lista, dgvDatos);
                    if (cboPaginas.Items.Count != totalPages)
                    {
                        CombosHelper.CargarComboPaginas(ref cboPaginas, totalPages);
                    }
                    txtPaginas.Text = totalPages.ToString();
                    cboPaginas.SelectedIndexChanged -= cboPaginas_SelectedIndexChanged!;
                    cboPaginas.SelectedIndex = currentPage == 1 ? 0 : currentPage - 1;
                    cboPaginas.SelectedIndexChanged += cboPaginas_SelectedIndexChanged!;
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
            frmNuevoTipoAE frm = new frmNuevoTipoAE(_serviceProvider, tipo) { Text = "Nuevo Género" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            try
            {
                TiposDeDatos? tiposDeDatos = frm.GetTipoDeDato();
                if (tiposDeDatos is null) return;
                if (!_servicios!.Existe(tipo, tiposDeDatos))
                {
                    _servicios.Guardar(tipo, tiposDeDatos);
                    totalRecords = _servicios!.GetCantidad(tipo, filter);
                    totalPages = (int)Math.Ceiling((decimal)totalRecords / pageSize);
                    currentPage = _servicios.GetPaginaPorRegistro(tipo, tiposDeDatos.Descripcion, pageSize);
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
            TiposDeDatos tiposDeDato = (TiposDeDatos)r.Tag;
            frmNuevoTipoAE frm = new frmNuevoTipoAE(_serviceProvider, tipo) { Text = "Editar Genero" };
            frm.SetTipoDeDato(tiposDeDato);
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.Cancel) return;
            tiposDeDato = frm.GetTipoDeDato();
            try
            {
                if (!_servicios!.Existe(tipo, tiposDeDato))
                {
                    _servicios!.Guardar(tipo, tiposDeDato);
                    GridHelper.SetearFila(r, tiposDeDato);
                    MessageBox.Show("Registro modificado satisfactoriamente",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("¡Registro Existente!\n Alta denegada",
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
                throw;
            }
        }
        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0) return;
            var r = dgvDatos.SelectedRows[0];
            if (r.Tag is null) return;
            TiposDeDatos tiposDeDato = (TiposDeDatos)r.Tag;
            DialogResult dr = MessageBox.Show($"¿Deseas dar de baja el genero: {tiposDeDato.Descripcion}?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dr == DialogResult.Cancel) return;
            try
            {
                if (!_servicios!.EstaRelacionado(tipo, tiposDeDato.TipoId))
                {
                    _servicios.Borrar(tipo, tiposDeDato.TipoId);
                    totalRecords = _servicios!.GetCantidad(tipo, filter);
                    totalPages = (int)Math.Ceiling((decimal)totalRecords / pageSize);
                    if (currentPage > totalPages)
                    {
                        currentPage = totalPages;
                    }
                    LoadData(filter);
                    MessageBox.Show("¡Registro eliminado satisfactoriamente!",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("¡Registro relacionado!\n Alta denegada!",
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


        private void tsbFiltrar_Click(object sender, EventArgs e)
        {
            frmFiltro frm = new frmFiltro(tipo) { Text = "Ingresar texto para buscar..." };
            DialogResult dr = frm.ShowDialog(this);
            try
            {
                var textoFiltro = frm.GetTexto();
                if (textoFiltro is null || textoFiltro == string.Empty) return;
                filter = b => b.Descripcion!.ToUpper().Contains(textoFiltro.ToUpper());
                totalRecords = _servicios!.GetCantidad(tipo, filter);
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
            LoadData();
        }
        private void ordenZAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orden = Orden.OrdenZA;
            LoadData();
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
        private void cboPaginas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPaginas.SelectedIndex >= 0)
            {
                currentPage = int.Parse(cboPaginas.Text);
                LoadData();
            }
        }
    }
}
