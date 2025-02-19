using Kevin2024.Entidades.Enumeraciones;

namespace Kevin2024.Windows.Formularios
{
    public partial class frmFiltro : Form
    {
        private string textoFiltro = string.Empty;
        private Archivo archivo = Archivo.Ninguno;
        public frmFiltro(Archivo archivo)
        {
            InitializeComponent();
            this.archivo = archivo;
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
            panelTiposTelefonos.Visible = false;
            panelTiposDirecciones.Visible = false;
        }

        private void frmFiltro_Load(object sender, EventArgs e)
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
            if (archivo == Archivo.Direccion)
            {
                panelTiposDirecciones.Visible = true;
            }
            if (archivo == Archivo.Telefono)
            {
                panelTiposTelefonos.Visible = true;
            }
            if (archivo == Archivo.Ninguno)
            {
                PanelBusqueda.Visible = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (archivo == Archivo.Categoria)
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
            if (archivo == Archivo.Marcas)
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
            if (archivo == Archivo.Tamanio)
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
            if (archivo == Archivo.Genero)
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
            if (archivo == Archivo.Telefono)
            {
                if (!string.IsNullOrEmpty(txtTelefono.Text.Trim()))
                {
                    textoFiltro = txtTelefono.Text;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    errorProvider1.SetError(txtTamanios, Text = "Ingrese al menos un caracter");
                }
            }
            if (archivo == Archivo.Direccion)
            {
                if (!string.IsNullOrEmpty(txtDireccion.Text.Trim()))
                {
                    textoFiltro = txtDireccion.Text;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    errorProvider1.SetError(txtTamanios, Text = "Ingrese al menos un caracter");
                }
            }
            if (archivo == Archivo.Ninguno)
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
