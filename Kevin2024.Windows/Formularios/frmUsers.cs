using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using Kevin2024.Servicios.Interfaces;
using Kevin2024.Windows.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace Kevin2024.Windows.Formularios
{
    public partial class frmUsers : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private readonly IServiciosUsuarios? _servicios;
        private List<Usuario>? lista;

        //Paginación
        private int currentPage = 1;
        private int pageSize = 10;
        private int totalPages = 0;
        private int totalRecords = 0;

        //Filtro
        private Func<Usuario, bool>? filter = null;

        //Órden
        private Orden orden = Orden.Ninguno;

        private Archivo archivo = Archivo.Ninguno;

        public frmUsers(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _servicios = _serviceProvider?.GetService<IServiciosUsuarios>() ??
                throw new ArgumentException("Dependencias No Cargadas!!!");
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            try
            {
                totalRecords = _servicios!.GetCantidad(filter);
                totalPages = (int)Math.Ceiling((decimal)totalRecords / pageSize);
                currentPage = totalPages;
                LoadData(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void LoadData(Func<Usuario, bool>? filter = null)
        {
            try
            {
                lista = _servicios!.GetLista(currentPage, pageSize, orden, filter);
                if (lista!.Count > 0)
                {
                    GridHelper.MostrarDatosEnGrilla<Usuario>(lista, dgvDatos);
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
        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0) return;
            var r = dgvDatos.SelectedRows[0];
            if (r.Tag is null) return;
            Usuario? usuario = (Usuario)r.Tag;
            frmUsuarios frm = new frmUsuarios(_serviceProvider) { Text = "Editar Usuario" };
            frm.SetUsuario(usuario);
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.Cancel) return;
            usuario = frm.GetUsuario();
            if (usuario is null) return;
            try
            {
                if (!_servicios!.Existe(usuario))
                {
                    _servicios!.GuardarUsuario(usuario);
                    GridHelper.SetearFila(r, usuario);
                    MessageBox.Show("Usuario modificado satisfactoriamente",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("¡Usuario Existente!\n Alta denegada",
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
            Usuario usuario = (Usuario)r.Tag;
            DialogResult dr = MessageBox.Show($"¿Deseas dar de baja el usuario: {usuario.NombreUsuario}?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dr == DialogResult.Cancel) return;
            try
            {
                _servicios!.Borrar(usuario.UsuarioId);
                totalRecords = _servicios!.GetCantidad(filter);
                totalPages = (int)Math.Ceiling((decimal)totalRecords / pageSize);
                if (currentPage > totalPages)
                {
                    currentPage = totalPages;
                }
                LoadData(filter);
                MessageBox.Show("¡Usuario eliminado satisfactoriamente!",
                    "Mensaje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
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
            frmFiltro frm = new frmFiltro(archivo) { Text = "Ingresar texto para buscar..." };
            DialogResult dr = frm.ShowDialog(this);
            try
            {
                var textoFiltro = frm.GetTexto();
                if (textoFiltro is null || textoFiltro == string.Empty) return;
                filter = b => b.NombreUsuario!.ToUpper().Contains(textoFiltro.ToUpper());
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
