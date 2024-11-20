using Kevin2024.Entidades;
using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Enumeraciones;
using Kevin2024.Servicios.Interfaces;
using Kevin2024.Windows.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace Kevin2024.Windows.Formularios
{
    public partial class frmProductos : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private readonly IServiciosProductos? _servicios;
        private List<ProductosListDto>? lista;
        //Paginación
        private int currentPage = 1;
        private int totalPages = 0;
        private int pageSize = 10;
        private int totalRecords = 0;

        //Filtro
        private Func<ProductosListDto, bool>? filter = null;

        //Orden
        private Orden orden = Orden.Ninguno;

        //Tipo para busqueda
        Tipos tipo = Tipos.Ninguno;

        public frmProductos(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _servicios = _serviceProvider?.GetService<IServiciosProductos>() ??
                throw new ApplicationException("Dependencias no cargadas!!");
        }

        private void frmProductos_Load(object sender, EventArgs e)
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
        private void LoadData(Func<ProductosListDto, bool>? filter = null)
        {
            try
            {
                lista = _servicios!.GetLista(currentPage, pageSize, orden, filter);
                if (lista!.Count > 0)
                {
                    GridHelper.MostrarDatosEnGrilla<ProductosListDto>(lista, dgvDatos);
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
            frmProductosAE frm = new frmProductosAE(_serviceProvider);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            try
            {
                Productos? producto = frm.GetProducto();
                if (producto is null)
                {
                    return;
                }
                if (!_servicios!.Existe(producto))
                {
                    _servicios.Guardar(producto);
                    totalRecords = _servicios!.GetCantidad(filter);
                    totalPages = (int)Math.Ceiling((decimal)totalRecords / pageSize);
                    currentPage = _servicios.GetPaginaPorRegistro(producto.Nombre, pageSize);
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
            ProductosListDto pListDto = (ProductosListDto)r.Tag;
            Productos? producto = _servicios!.GetProductoPorId(pListDto.ProductoId);
            if (producto is null) return;
            frmProductosAE frm = new frmProductosAE(_serviceProvider) { Text = "Editar Producto" };
            frm.SetProducto(producto);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            producto = frm.GetProducto();
            if (producto is null) return;
            try
            {
                if (!_servicios!.Existe(producto))
                {
                    _servicios!.Guardar(producto);
                    currentPage = _servicios!.GetPaginaPorRegistro(producto.Nombre, pageSize);
                    LoadData();
                    int row = GridHelper.ObtenerRowIndex(dgvDatos, producto.ProductoId);
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
            ProductosListDto pListDto = (ProductosListDto)r.Tag;
            DialogResult dr = MessageBox.Show($"¿Deseas dar de baja el siguiente Producto?\n Producto: {pListDto.Nombre!}\n CobBarras: {pListDto.CodBarras}",
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
                if (!_servicios!.EstaRelacionado(pListDto.ProductoId))
                {
                    _servicios!.Borrar(pListDto.ProductoId);
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

        private void busquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tipo = Tipos.Ninguno;
            frmFiltro frm = new frmFiltro(tipo) { Text = "Ingresar texto para buscar..." };
            DialogResult dr = frm.ShowDialog(this);
            try
            {
                var textoFiltro = frm.GetTexto();
                if (textoFiltro is null || textoFiltro == string.Empty) return;

                filter = b => (b.Nombre.ToUpper().Contains(textoFiltro.ToUpper()) ||
                (b.CodBarras.ToString().Contains(textoFiltro)));
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
        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tipo = Tipos.Categoria;
            frmFiltro frm = new frmFiltro(tipo) { Text = "Ingresar texto para buscar..." };

            DialogResult dr = frm.ShowDialog(this);
            try
            {
                var textoFiltro = frm.GetTexto();
                if (textoFiltro is null || textoFiltro == string.Empty) return;
                filter = p => p.Categoria!.ToUpper().Contains(textoFiltro.ToUpper());
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
        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tipo = Tipos.Marcas;
            frmFiltro frm = new frmFiltro(tipo) { Text = "Ingresar texto para buscar..." };

            DialogResult dr = frm.ShowDialog(this);
            try
            {
                var textoFiltro = frm.GetTexto();
                if (textoFiltro is null || textoFiltro == string.Empty) return;
                filter = p => p.Marca!.ToUpper().Contains(textoFiltro.ToUpper());
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
        private void tamañoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tipo = Tipos.Tamanio;
            frmFiltro frm = new frmFiltro(tipo) { Text = "Ingresar texto para buscar..." };

            DialogResult dr = frm.ShowDialog(this);
            try
            {
                var textoFiltro = frm.GetTexto();
                if (textoFiltro is null || textoFiltro == string.Empty) return;
                filter = p => p.Tamanio!.ToUpper().Contains(textoFiltro.ToUpper());
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
