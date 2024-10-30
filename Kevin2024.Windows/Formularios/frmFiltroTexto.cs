namespace Kevin2024.Windows.Formularios
{
    public partial class frmFiltroTexto : Form
    {
        private string textoBusqueda = string.Empty;
        public frmFiltroTexto()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtTexto.Text.Trim()))
            {
                textoBusqueda = txtTexto.Text.Trim();
            }
            DialogResult = DialogResult.OK;
        }

        public string GetTexto()
        {
            return textoBusqueda;
        }
    }
}
