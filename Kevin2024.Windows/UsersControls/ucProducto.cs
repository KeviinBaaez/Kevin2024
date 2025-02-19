using Kevin2024.Entidades;

namespace Kevin2024.Windows.UsersControls
{
    public partial class ucProducto : UserControl
    {
        private string imagenNoDisponible = Environment.CurrentDirectory + @"\Imágenes\SinImagenDisponible.jpg";
        private string archivoNoEncontrado = Environment.CurrentDirectory + @"\Imágenes\ArchivoNoEncontrado.jpg";
        private string? archivoImagen = string.Empty;
        private string carpetaImagen = Environment.CurrentDirectory + @"\Imágenes\";
        public ucProducto()
        {
            InitializeComponent();
        }
        public int ProductoId { get; set; }
        public string? NombreProducto { set => lblNombreProducto.Text = value; }
        public decimal PrecioProducto { set => lblPrecioProducto.Text = value.ToString(); }
        public string? ImagenProducto
        {
            set
            {
                if (value != string.Empty)
                {
                    if (!File.Exists($"{carpetaImagen}{value}"))
                    {
                        picImagenProducto.Image = Image.FromFile(archivoNoEncontrado);
                    }
                    else
                    {
                        picImagenProducto.Image = Image.FromFile($"{carpetaImagen}{value}");
                        archivoImagen = value;
                    }
                }
                else
                {
                    picImagenProducto.Image = Image.FromFile(imagenNoDisponible);
                }
            }
        }
    }
}
