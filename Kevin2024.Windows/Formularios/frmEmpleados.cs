using Kevin2024.Entidades;
using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using Kevin2024.Servicios.Interfaces;
using Kevin2024.Windows.Helpers;
using Microsoft.Extensions.DependencyInjection;
using System.Security.Principal;

namespace Kevin2024.Windows.Formularios
{
    public partial class frmEmpleados : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private readonly IServiciosEmpleados? _servicios;
        private List<EmpleadosListDto>? lista;
        //Paginación
        private int currentPage = 1;
        private int totalPages = 0;
        private int pageSize = 10;
        private int totalRecords = 0;

        //Filtro
        private Func<EmpleadosListDto, bool>? filter = null;

        //Orden 
        Orden orden = Orden.Ninguno;

        public frmEmpleados(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _servicios = _serviceProvider?.GetService<IServiciosEmpleados>() ??
                throw new ApplicationException("Dependencias no cargadas!!");
        }

        private void frmPostre_Load(object sender, EventArgs e)
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
        private void LoadData(Func<EmpleadosListDto, bool>? filter = null)
        {
            try
            {
                lista = _servicios!.GetLista(currentPage, pageSize, orden, filter);
                if (lista!.Count > 0)
                {
                    GridHelper.MostrarDatosEnGrilla<EmpleadosListDto>(lista, dgvDatos);
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
            frmEmpleadosAE frm = new frmEmpleadosAE(_serviceProvider);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            try
            {
                Empleados? empleado = frm.GetEmpleado();
                if (empleado is null)
                {
                    return;
                }
                if (!_servicios!.Existe(empleado))
                {
                    _servicios.Guardar(empleado);
                    totalRecords = _servicios!.GetCantidad(filter);
                    totalPages = (int)Math.Ceiling((decimal)totalRecords / pageSize);
                    currentPage = _servicios.GetPaginaPorRegistro(empleado.Nombre, pageSize);
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
            EmpleadosListDto empleadoDto = (EmpleadosListDto)r.Tag;
            Empleados empleado = _servicios!.GetEmpleadoPorId(empleadoDto.EmpleadoId);
            if (empleado is null) return;
            frmEmpleadosAE frm = new frmEmpleadosAE(_serviceProvider) { Text = "Editar datos del Empleado" };
            frm.SetEmpleado((Empleados)empleado);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            empleado = frm.GetEmpleado();
            if (empleado is null) return;
            try
            {
                if (!_servicios!.Existe(empleado))
                {
                    _servicios!.Guardar(empleado);
                    currentPage = _servicios!.GetPaginaPorRegistro(empleado.Nombre, pageSize);
                    LoadData();
                    int row = GridHelper.ObtenerRowIndex(dgvDatos, empleado.EmpleadoId);
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
            EmpleadosListDto empleadoDto = (EmpleadosListDto)r.Tag;
            //ACOMOAR EL MESSAGE BOX!!!!
            DialogResult dr = MessageBox.Show($"¿Deseas dar de baja el siguiente Empleado?\n Nombre y Apellido: {empleadoDto.Nombre}\n Dni: {empleadoDto.Dni}",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                return;
            }

            _servicios!.Borrar(empleadoDto.EmpleadoId);
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
        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Close();
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

        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            filter = null;
            orden = Orden.Ninguno;
            currentPage = 1;
            tsbFiltrar.Enabled = true;
            RecargarGrilla();
        }

        private void busquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFiltro frm = new frmFiltro(Tipos.Ninguno) { Text = "Escriba para buscar"};
            DialogResult dr = frm.ShowDialog(this);
            try
            {
                var textoFiltro = frm.GetTexto();
                if (string.IsNullOrEmpty(textoFiltro)) return;
                filter = e => (e.Nombre!.ToUpper().Contains(textoFiltro.ToUpper()))
                ||(e.Apellido!.ToUpper().Contains(textoFiltro.ToUpper())) 
                ||(e.Dni!.ToString().Contains(textoFiltro.ToString()));
                totalRecords = _servicios!.GetCantidad(filter);
                currentPage = 1;
                if(totalRecords > 0)
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
    }
}
