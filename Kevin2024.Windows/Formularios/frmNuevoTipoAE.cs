using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;

namespace Kevin2024.Windows.Formularios
{
    public partial class frmNuevoTipoAE : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private Marcas? marca;
        private Categorias? categoria;
        private Tamanio? tamanio;

        private Tipos _tipo = Tipos.Ninguno;
        public frmNuevoTipoAE(IServiceProvider? serviceProvider, Tipos tipo)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _tipo = tipo;
            OcultarPaneles();
        }

        private void OcultarPaneles()
        {
            panelCategorias.Visible = false;
            panelMarcas.Visible = false;
            panelTamanios.Visible = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDaros())
            {
                if (_tipo == Tipos.Categoria)
                {
                    if (categoria is null)
                    {
                        categoria = new Categorias();
                    }
                    categoria.Descripcion = txtCategoria.Text;
                }
                if (_tipo == Tipos.Marcas)
                {
                    if (marca is null)
                    {
                        marca = new Marcas();
                    }
                    marca.Nombre = txtMarca.Text;
                }
                if (_tipo == Tipos.Tamanio)
                {
                    if (tamanio is null)
                    {
                        tamanio = new Tamanio();
                    }
                    tamanio.Descripcion = txtTamanio.Text;
                }
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDaros()
        {
            errorProvider1.Clear();
            bool valido = true;
            if(_tipo == Tipos.Marcas)
            {
                if (string.IsNullOrEmpty(txtMarca.Text))
                {
                    valido = false;
                    errorProvider1.SetError(txtMarca, "Ingrese el nombre de la marca");
                }
            }
            if (_tipo == Tipos.Categoria)
            {
                if (string.IsNullOrEmpty(txtCategoria.Text))
                {
                    valido = false;
                    errorProvider1.SetError(txtCategoria, "Ingrese el nombre de la categoría");
                }
            }
            if (_tipo == Tipos.Tamanio)
            {
                if(string.IsNullOrEmpty(txtTamanio.Text))
                {
                    valido = false;
                    errorProvider1.SetError(txtTamanio, "Ingrese el nombre del Tamaño");
                }
            }
            return valido;
        }

        private void frmMarcasAE_Load(object sender, EventArgs e)
        {
            if (_tipo == Tipos.Categoria)
            {
                panelCategorias.Visible = true;
            }
            if (_tipo == Tipos.Marcas)
            {
                panelMarcas.Visible = true;
            }
            if (_tipo == Tipos.Tamanio)
            {
                panelTamanios.Visible = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public Marcas? GetMarca()
        {
            return marca;
        }

        public Categorias? GetCategoria()
        {
            return categoria;
        }

        public Tamanio? GetTamanio()
        {
            return tamanio;
        }
        public void SetMarca(Marcas marca)
        {
            this.marca = marca;
        }
        public void SetCategoria(Categorias categoria)
        {
            this.categoria = categoria;
        }
        public void SetTamanio(Tamanio tamanio)
        {
            this.tamanio = tamanio;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (_tipo == Tipos.Categoria)
            {
                if (categoria != null)
                {
                    txtCategoria.Text = categoria.Descripcion ;
                }
            }
            if (_tipo == Tipos.Marcas)
            {
                if (marca != null)
                {
                    txtMarca.Text = marca.Nombre;
                }
            }
            if (_tipo == Tipos.Tamanio)
            {
                if (tamanio != null)
                {
                    txtTamanio.Text = tamanio.Descripcion;
                }
            }
        }
    }
}
