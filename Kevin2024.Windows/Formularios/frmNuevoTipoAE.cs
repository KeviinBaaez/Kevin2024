using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;

namespace Kevin2024.Windows.Formularios
{
    public partial class frmNuevoTipoAE : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private TiposDeDatos? tiposDeDatos;

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
            panelGeneros.Visible = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (_tipo == Tipos.Categoria)
                {
                    if (tiposDeDatos is null)
                    {
                        tiposDeDatos = new TiposDeDatos();
                    }
                    tiposDeDatos.Descripcion = txtCategoria.Text;
                }
                if (_tipo == Tipos.Marcas)
                {
                    if (tiposDeDatos is null)
                    {
                        tiposDeDatos = new TiposDeDatos();
                    }
                    tiposDeDatos.Descripcion = txtMarca.Text;
                }
                if (_tipo == Tipos.Tamanio)
                {
                    if (tiposDeDatos is null)
                    {
                        tiposDeDatos = new TiposDeDatos();
                    }
                    tiposDeDatos.Descripcion = txtTamanio.Text;
                }
                if(_tipo == Tipos.Genero)
                {
                    if(tiposDeDatos is null)
                    {
                        tiposDeDatos = new TiposDeDatos();
                    }
                    tiposDeDatos.Descripcion = txtGenero.Text;
                }
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            bool valido = true;
            if (_tipo == Tipos.Marcas)
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
                if (string.IsNullOrEmpty(txtTamanio.Text))
                {
                    valido = false;
                    errorProvider1.SetError(txtTamanio, "Ingrese el nombre del Tamaño");
                }
            }
            if(_tipo == Tipos.Genero)
            {
                if(string.IsNullOrEmpty(txtGenero.Text))
                {
                    valido = false;
                    errorProvider1.SetError(txtTamanio, "Ingrese el nombre del genero");
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
            if(_tipo == Tipos.Genero)
            {
                panelGeneros.Visible = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public TiposDeDatos? GetTipoDeDato()
        {

            return tiposDeDatos;

        }
        public void SetTipoDeDato(TiposDeDatos tiposDeDato)
        {
            tiposDeDatos = tiposDeDato;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (_tipo == Tipos.Categoria)
            {
                if (tiposDeDatos != null)
                {
                    txtCategoria.Text = tiposDeDatos.Descripcion;
                }
            }
            if (_tipo == Tipos.Marcas)
            {
                if (tiposDeDatos != null)
                {
                    txtMarca.Text = tiposDeDatos.Descripcion;
                }
            }
            if (_tipo == Tipos.Tamanio)
            {
                if (tiposDeDatos != null)
                {
                    txtTamanio.Text = tiposDeDatos.Descripcion;
                }
            }
            if(_tipo == Tipos.Genero)
            {
                if(tiposDeDatos != null)
                {
                    txtGenero.Text = tiposDeDatos.Descripcion;
                }
            }
        }
    }
}
