using Kevin2024.Entidades;
using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Windows.Helpers;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Kevin2024.Windows.Formularios
{
    public partial class frmCombosAE : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private Combo? combo;

        private string imagenNoDisponible = Environment.CurrentDirectory + @"\Imágenes\SinImagenDisponible.jpg";
        private string archivoNoEncontrado = Environment.CurrentDirectory + @"\Imágenes\ArchivoNoEncontrado.jpg";
        private string? archivoImagen = string.Empty;
        private string carpetaImagen = Environment.CurrentDirectory + @"\Imágenes\";
        public frmCombosAE(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        public Combo? GetCombo()
        {
            return combo;
        }

        public void SetCombo(Combo combo)
        {
            this.combo = combo;
        }

        private void frmCombosAE_Load(object sender, EventArgs e)
        {
            CombosHelper.CargarComboTamanios(ref cboTamanio, _serviceProvider);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (combo is null)
                {
                    combo = new Combo();
                }

                combo.Nombre = txtNombre.Text;
                combo.Descripcion = txtDescripcion.Text;
                combo.TamanioId = (int)cboTamanio.SelectedValue!;
                combo.PrecioCosto = nupPrecioCosto.Value;
                combo.PrecioVenta = nupPrecioVenta.Value;
                combo.Stock = (int)nupStock.Value;
                combo.NivelDeReposicion = (int)nupNivelReposicion.Value;
                combo.Suspendido = checkBox1.Checked;

                combo.Imagen = archivoImagen;

                if (!string.IsNullOrWhiteSpace(combo.Imagen))
                {
                    if (!File.Exists($"{carpetaImagen}{combo.Imagen}"))
                    {
                        picImagen.Image = Image.FromFile(archivoNoEncontrado);
                    }
                    else
                    {
                        picImagen.Image = Image.FromFile($"{carpetaImagen}{combo.Imagen}");
                    }
                }
                else
                {
                    picImagen.Image = Image.FromFile(imagenNoDisponible);
                }
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            bool valido = true;

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                valido = false;
                errorProvider1.SetError(txtNombre, "Ingrese un Nombre");
            }
            if (cboTamanio.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(cboTamanio, "Ingrese el tamaño del producto");
            }
            if (nupPrecioCosto.Value == 0)
            {
                DialogResult dr = MessageBox.Show("El precio costo es Cero, ¿Deseas dejarlo así?",
                    "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    valido = false;
                }
            }
            return valido;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarProductos frm = new frmAgregarProductos(_serviceProvider);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            try
            {
                DetallesCombos? detallesCombos = frm.GetDetalleCombo();
                if (detallesCombos is null) return;
                if (combo!.Existe(detallesCombos))
                {
                    DialogResult drDetalle = MessageBox.Show($"¿Deseas agregar el producto: {detallesCombos.Producto?.Nombre}?",
                "Producto Existente",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
                    if (drDetalle == DialogResult.No) return;
                    combo!.Agregar(detallesCombos);
                }
                else
                {
                    combo!.Agregar(detallesCombos);
                }

                GridHelper.MostrarDatosEnGrilla<DetallesCombos>(combo.DetallesCombos, dgvDatos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (combo != null)
            {
                txtNombre.Text = combo.Nombre;
                txtDescripcion.Text = combo.Descripcion;
                nupPrecioCosto.Value = combo.PrecioCosto;
                nupPrecioVenta.Value = combo.PrecioVenta;
                cboTamanio.SelectedValue = (int)combo.TamanioId!;
                nupStock.Value = combo.Stock;
                nupNivelReposicion.Value = combo.NivelDeReposicion;
                checkBox1.Checked = combo.Suspendido;
                if (combo.Imagen != string.Empty)
                {
                    if (!File.Exists($"{carpetaImagen}{combo.Imagen}"))
                    {
                        picImagen.Image = Image.FromFile(archivoNoEncontrado);
                    }
                    else
                    {
                        picImagen.Image = Image.FromFile($"{carpetaImagen}{combo.Imagen}");
                        archivoImagen = combo.Imagen;
                    }
                }
                else
                {
                    picImagen.Image = Image.FromFile(imagenNoDisponible);
                }
                GridHelper.MostrarDatosEnGrilla<DetallesCombos>(combo.DetallesCombos, dgvDatos);
            }
            else
            {
                combo = new Combo();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0) return;
            var r = dgvDatos.SelectedRows[0];
            if (r.Tag is null) return;
            DetallesCombos detalle = (DetallesCombos)r.Tag;
            DialogResult dr = MessageBox.Show($"¿Deseas elimar el producto {detalle.Producto!.Nombre}?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) return;
            combo!.Eliminar(detalle);
            GridHelper.QuitarFila(r, dgvDatos);
            MessageBox.Show("Item eliminado!!", "Mensaje",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0) return;
            var r = dgvDatos.SelectedRows[0];
            if (r.Tag is null) return;
            DetallesCombos? detalle = (DetallesCombos)r.Tag;
            frmAgregarProductos frm = new frmAgregarProductos(_serviceProvider) { Text = "Editar Producto" };
            frm.SetDetalle(detalle);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            detalle = frm.GetDetalleCombo();
            if (detalle is null) return;
            GridHelper.SetearFila(r, detalle);
            MessageBox.Show("Item editado!!", "Mensaje",
    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory + @"Todos los archivos (.)|.|Archivos PNG (.png)|.png|Archivos JFIF (.jfif)|.jfif|Archivos JPG (.jpg)|.jpg";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            DialogResult dr = openFileDialog1.ShowDialog(this);

            if (dr == DialogResult.OK)
            {
                if (openFileDialog1.FileName == null)
                {
                    return;
                }
                picImagen.Image = Image.FromFile(openFileDialog1.FileName);
                archivoImagen = openFileDialog1.SafeFileName;
            }
        }
    }
}
