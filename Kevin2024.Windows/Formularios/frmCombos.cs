using Kevin2024.Entidades;
using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using Kevin2024.Servicios.Interfaces;
using Kevin2024.Windows.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace Kevin2024.Windows.Formularios
{
    public partial class frmCombos : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private readonly IServiciosCombos? _servicios;
        private List<ComboListDto>? lista;

        //Paginación
        private int currentPage = 1;
        private int totalPages = 0;
        private int pageSize = 10;
        private int totalRecords = 0;

        //Filtro
        private Func<ComboListDto, bool>? filter = null;
        private TiposDeDatos? consulta;

        //Orden
        private Orden orden = Orden.Ninguno;

        //Tipo para busqueda
        Archivo archivo = Archivo.Ninguno;
        public frmCombos(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _servicios = _serviceProvider?.GetService<IServiciosCombos>()
                ?? throw new ApplicationException("Dependencias No Cargadas!!");
        }

        private void frmCombos_Load(object sender, EventArgs e)
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

        private void LoadData(Func<ComboListDto, bool>? filter)
        {
            try
            {
                lista = _servicios!.GetLista(currentPage, pageSize, orden, filter);
                if (lista!.Count > 0)
                {
                    GridHelper.MostrarDatosEnGrilla<ComboListDto>(lista, dgvDatos);
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
            frmCombosAE frm = new frmCombosAE(_serviceProvider) { Text = "¡Nuevo Combo!" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            try
            {
                Combo? combo = frm.GetCombo();
                if (combo is null) return;
                if (!_servicios!.Existe(combo))
                {
                    _servicios.Guardar(combo);
                    totalRecords = _servicios!.GetCantidad(filter);
                    totalPages = (int)Math.Ceiling((decimal)totalRecords / pageSize);
                    currentPage = _servicios.GetPaginaPorRegistro(combo.Nombre, pageSize);
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

        private void cboPaginas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0) return;
            var r = dgvDatos.SelectedRows[0];
            if (r.Tag == null) return;
            ComboListDto comboListDto = (ComboListDto)r.Tag;
            Combo? combo = _servicios!.GetComboPorId(comboListDto.ComboId);
            if (combo is null) return;
            frmCombosAE frm = new frmCombosAE(_serviceProvider) { Text = "Editar Combo" };
            frm.SetCombo(combo);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            combo = frm.GetCombo();
            if (combo is null) return;
            try
            {
                if (!_servicios!.Existe(combo))
                {
                    _servicios!.Guardar(combo);
                    currentPage = _servicios!.GetPaginaPorRegistro(combo.Nombre, pageSize);
                    LoadData(null);
                    int row = GridHelper.ObtenerRowIndex(dgvDatos, combo.ProductoId);
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
            ComboListDto comboListDto = (ComboListDto)r.Tag;
            DialogResult dr = MessageBox.Show($"¿Deseas dar de baja el siguiente Producto?\n Producto: {comboListDto.Nombre!}",
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
                if (!_servicios!.EstaRelacionado(comboListDto.ComboId))
                {
                    _servicios!.Borrar(comboListDto.ComboId);
                    totalRecords = _servicios!.GetCantidad(filter);
                    totalPages = (int)Math.Ceiling((decimal)totalRecords / pageSize);
                    if (currentPage > totalPages)
                    {
                        currentPage = totalPages;
                    }
                    LoadData(null);
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

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
