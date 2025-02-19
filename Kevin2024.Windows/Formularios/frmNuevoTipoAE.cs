using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;

namespace Kevin2024.Windows.Formularios
{
    public partial class frmNuevoTipoAE : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private TiposDeDatos? tiposDeDatos;

        private Archivo archivo = Archivo.Ninguno;
        public frmNuevoTipoAE(IServiceProvider? serviceProvider, Archivo archivo)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            this.archivo = archivo;
            OcultarPaneles();
        }

        private void OcultarPaneles()
        {
            panelCategorias.Visible = false;
            panelMarcas.Visible = false;
            panelTamanios.Visible = false;
            panelGeneros.Visible = false;
            panelTipotelefono.Visible = false;
            panelTipoDireccion.Visible = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (archivo == Archivo.Categoria)
                {
                    if (tiposDeDatos is null)
                    {
                        tiposDeDatos = new TiposDeDatos();
                    }
                    tiposDeDatos.Descripcion = txtCategoria.Text;
                }
                if (archivo == Archivo.Marcas)
                {
                    if (tiposDeDatos is null)
                    {
                        tiposDeDatos = new TiposDeDatos();
                    }
                    tiposDeDatos.Descripcion = txtMarca.Text;
                }
                if (archivo == Archivo.Tamanio)
                {
                    if (tiposDeDatos is null)
                    {
                        tiposDeDatos = new TiposDeDatos();
                    }
                    tiposDeDatos.Descripcion = txtTamanio.Text;
                }
                if (archivo == Archivo.Genero)
                {
                    if (tiposDeDatos is null)
                    {
                        tiposDeDatos = new TiposDeDatos();
                    }
                    tiposDeDatos.Descripcion = txtGenero.Text;
                }
                if (archivo == Archivo.Telefono)
                {
                    if (tiposDeDatos is null)
                    {
                        tiposDeDatos = new TiposDeDatos();
                    }
                    tiposDeDatos.Descripcion = txtTelefono.Text;
                }
                if (archivo == Archivo.Direccion)
                {
                    if (tiposDeDatos is null)
                    {
                        tiposDeDatos = new TiposDeDatos();
                    }
                    tiposDeDatos.Descripcion = txtDireccion.Text;
                }
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            bool valido = true;
            if (archivo == Archivo.Marcas)
            {
                if (string.IsNullOrEmpty(txtMarca.Text))
                {
                    valido = false;
                    errorProvider1.SetError(txtMarca, "Ingrese el nombre de la marca");
                }
            }
            if (archivo == Archivo.Categoria)
            {
                if (string.IsNullOrEmpty(txtCategoria.Text))
                {
                    valido = false;
                    errorProvider1.SetError(txtCategoria, "Ingrese el nombre de la categoría");
                }
            }
            if (archivo == Archivo.Tamanio)
            {
                if (string.IsNullOrEmpty(txtTamanio.Text))
                {
                    valido = false;
                    errorProvider1.SetError(txtTamanio, "Ingrese el nombre del Tamaño");
                }
            }
            if (archivo == Archivo.Genero)
            {
                if (string.IsNullOrEmpty(txtGenero.Text))
                {
                    valido = false;
                    errorProvider1.SetError(txtTamanio, "Ingrese el nombre del genero");
                }
            }
            if (archivo == Archivo.Telefono)
            {
                if (string.IsNullOrEmpty(txtTelefono.Text))
                {
                    valido = false;
                    errorProvider1.SetError(txtTelefono, "Ingrese la descripcion del tipo de teléfono");
                }
            }
            if (archivo == Archivo.Direccion)
            {
                if (string.IsNullOrEmpty(txtDireccion.Text))
                {
                    valido = false;
                    errorProvider1.SetError(txtDireccion, "Ingrese la descripcion del tipo de dirección");
                }
            }
            return valido;
        }

        private void frmMarcasAE_Load(object sender, EventArgs e)
        {
            if (archivo == Archivo.Categoria)
            {
                panelCategorias.Visible = true;
            }
            if (archivo == Archivo.Marcas)
            {
                panelMarcas.Visible = true;
            }
            if (archivo == Archivo.Tamanio)
            {
                panelTamanios.Visible = true;
            }
            if (archivo == Archivo.Genero)
            {
                panelGeneros.Visible = true;
            }
            if (archivo == Archivo.Telefono)
            {
                panelTipotelefono.Visible = true;
            }
            if (archivo == Archivo.Direccion)
            {
                panelTipoDireccion.Visible = true;
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

            if (archivo == Archivo.Categoria)
            {
                if (tiposDeDatos != null)
                {
                    txtCategoria.Text = tiposDeDatos.Descripcion;
                }
            }
            if (archivo == Archivo.Marcas)
            {
                if (tiposDeDatos != null)
                {
                    txtMarca.Text = tiposDeDatos.Descripcion;
                }
            }
            if (archivo == Archivo.Tamanio)
            {
                if (tiposDeDatos != null)
                {
                    txtTamanio.Text = tiposDeDatos.Descripcion;
                }
            }
            if (archivo == Archivo.Genero)
            {
                if (tiposDeDatos != null)
                {
                    txtGenero.Text = tiposDeDatos.Descripcion;
                }
            }
            if(archivo == Archivo.Telefono)
            {
                if(tiposDeDatos != null)
                {
                    txtTelefono.Text = tiposDeDatos.Descripcion;
                }
            }
            if (archivo == Archivo.Direccion)
            {
                if (tiposDeDatos != null)
                {
                    txtDireccion.Text = tiposDeDatos.Descripcion;
                }
            }
        }


    }
}
