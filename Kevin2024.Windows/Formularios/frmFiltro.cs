using Kevin2024.Entidades.Enumeraciones;

namespace Kevin2024.Windows.Formularios
{
    public partial class frmFiltro : Form
    {
        private string textoFiltro = string.Empty;
        private Tipos _tipo = Tipos.Ninguno;
        public frmFiltro(Tipos tipo)
        {
            InitializeComponent();
            _tipo = tipo;
            OcultarPaneles();
        }

        public string GetTexto()
        {
            return textoFiltro;
        }

        private void OcultarPaneles()
        {
            panelCategorias.Visible = false;
            panelMarcas.Visible = false;
            panelTamanios.Visible = false;
            panelGeneros.Visible = false;
            PanelBusqueda.Visible = false;
        }

        private void frmFiltro_Load(object sender, EventArgs e)
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
            if (_tipo == Tipos.Genero)
            {
                panelGeneros.Visible = true;
            }
            if (_tipo == Tipos.Ninguno)
            {
                PanelBusqueda.Visible = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (_tipo == Tipos.Categoria)
            {
                if (!string.IsNullOrEmpty(txtCategoria.Text.Trim()))
                {
                    textoFiltro = txtCategoria.Text;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    errorProvider1.SetError(txtCategoria, Text = "Ingrese al menos un caracter");
                }
            }
            if (_tipo == Tipos.Marcas)
            {
                if (!string.IsNullOrEmpty(txtMarca.Text.Trim()))
                {
                    textoFiltro = txtMarca.Text;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    errorProvider1.SetError(txtMarca, Text = "Ingrese al menos un caracter");
                }
            }
            if (_tipo == Tipos.Tamanio)
            {
                if (!string.IsNullOrEmpty(txtTamanios.Text.Trim()))
                {
                    textoFiltro = txtTamanios.Text;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    errorProvider1.SetError(txtTamanios, Text = "Ingrese al menos un caracter");
                }
            }
            if (_tipo == Tipos.Genero)
            {
                if (!string.IsNullOrEmpty(txtGenero.Text.Trim()))
                {
                    textoFiltro = txtGenero.Text;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    errorProvider1.SetError(txtTamanios, Text = "Ingrese al menos un caracter");
                }
            }
            if (_tipo == Tipos.Ninguno)
            {
                if (!string.IsNullOrEmpty(txtBusqueda.Text.Trim()))
                {
                    textoFiltro = txtBusqueda.Text;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    errorProvider1.SetError(txtBusqueda, Text = "Ingrese al menos un caracter");
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
