using Kevin2024.Entidades;
using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Enumeraciones;
using Kevin2024.Servicios.Interfaces;
using Kevin2024.Windows.Helpers;
using System.Drawing.Printing;

namespace Kevin2024.Windows.Formularios
{
    public partial class frmProductosAE : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private Productos? producto;

        private string imagenNoDisponible = Environment.CurrentDirectory + @"\Imágenes\SinImagenDisponible.jpg";
        private string archivoNoEncontrado = Environment.CurrentDirectory + @"\Imágenes\ArchivoNoEncontrado.jpg";
        private string? archivoImagen = string.Empty;
        private string carpetaImagen = Environment.CurrentDirectory + @"\Imágenes\";
        public frmProductosAE(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }
        private void frmPostresAE_Load(object sender, EventArgs e)
        {
            CombosHelper.CargarComboMarcas(ref cboMarca, _serviceProvider);
            CombosHelper.CargarComboTamanios(ref cboTamanio, _serviceProvider);
            CombosHelper.CargarComboCategorias(ref cboCategorias, _serviceProvider);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (producto is null)
                {
                    producto = new Productos();
                }

                producto.Nombre = txtNombre.Text;
                producto.Descripcion = txtDescripcion.Text;
                producto.MarcaId = (int)cboMarca.SelectedValue!;
                if (producto.MarcaId == 0)
                {
                    producto.MarcaId = null;
                }
                producto.Sabor = txtSabor.Text;
                producto.CodBarras = decimal.Parse(txtCodigoBarras.Text);
                producto.TamanioId = (int)cboTamanio.SelectedValue!;
                producto.CategoriaId = (int)cboCategorias.SelectedValue!;
                producto.PrecioCosto = nupPrecioCosto.Value;
                producto.PrecioVenta = nupPrecioVenta.Value;
                producto.Stock = (int)nupStock.Value;
                producto.NivelDeReposicion = (int)nupNivelReposicion.Value;
                producto.Suspendido = checkBox1.Checked;

                producto.Imagen = archivoImagen;

                if (!string.IsNullOrWhiteSpace(producto.Imagen))
                {
                    if (!File.Exists($"{carpetaImagen}{producto.Imagen}"))
                    {
                        picImagen.Image = Image.FromFile(archivoNoEncontrado);
                    }
                    else
                    {
                        picImagen.Image = Image.FromFile($"{carpetaImagen}{producto.Imagen}");
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
            decimal resultado;

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                valido = false;
                errorProvider1.SetError(txtNombre, "Ingrese un Nombre");
            }
            if (!decimal.TryParse(txtCodigoBarras.Text, out resultado))
            {
                valido = false;
                errorProvider1.SetError(txtCodigoBarras, "Ingrese un codigo valido");
            }
            if (cboTamanio.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(cboTamanio, "Ingrese el tamaño del producto");
            }
            if (cboCategorias.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(cboCategorias, "Ingrese la categoria del producto");
            }
            if (cboMarca.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(cboMarca, "Ingrese la marca del producto");
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

        public Productos? GetProducto()
        {
            return producto;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (producto != null)
            {
                txtNombre.Text = producto.Nombre;
                txtDescripcion.Text = producto.Descripcion;
                cboMarca.SelectedValue = (int)producto.MarcaId!;
                txtSabor.Text = producto.Sabor;
                txtCodigoBarras.Text = producto.CodBarras.ToString();
                cboTamanio.SelectedValue = (int)producto.TamanioId!;
                cboCategorias.SelectedValue = (int)producto.CategoriaId!;
                nupPrecioCosto.Value = producto.PrecioCosto;
                nupPrecioVenta.Value = producto.PrecioVenta;
                nupStock.Value = producto.Stock;
                nupNivelReposicion.Value = producto.NivelDeReposicion;
                checkBox1.Checked = producto.Suspendido;

                if (producto.Imagen != string.Empty)
                {
                    if (!File.Exists($"{carpetaImagen}{producto.Imagen}"))
                    {
                        picImagen.Image = Image.FromFile(archivoNoEncontrado);
                    }
                    else
                    {
                        picImagen.Image = Image.FromFile($"{carpetaImagen}{producto.Imagen}");
                        archivoImagen = producto.Imagen;
                    }
                }
                else
                {
                    picImagen.Image = Image.FromFile(imagenNoDisponible);
                }

                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }



        public void SetProducto(Productos producto)
        {
            this.producto = producto;
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
