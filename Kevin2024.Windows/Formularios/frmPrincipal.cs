namespace Kevin2024.Windows.Formularios
{
    public partial class frmPrincipal : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        public frmPrincipal(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            PersonalizarInicio();
            _serviceProvider = serviceProvider;

        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void PersonalizarInicio()
        {
            panelDespegable.Visible = false;
            panelAplegar.Visible = false;
            panel1.Size = new Size(60, 634);
            toolStrip3.Visible = false;
            panelFormularios.Visible = false;
            btnVentas.Enabled = false;
            btnClientes.Enabled = false;
            toolStrip1.Enabled= false;
            btnUsuario.Enabled = false;
        }

        //private void OcultarMenuDespegable()
        //{
        //    if (panelDespegable.Visible == true)
        //    {
        //        panelDespegable.Visible = false;
        //    }
        //}

        private void MostrarMenu(Panel menu)
        {
            if (menu.Visible == false)
            {
                // OcultarMenuDespegable();
                menu.Visible = true;
            }
            else
            {
                menu.Visible = false;
            }
        }
        private void OcultarTsb()
        {

            if (toolStrip3.Visible == true)
            {
                toolStrip3.Visible = false;
            }
        }
        private void MostrarTsb(ToolStrip tsb)
        {
            if (tsb.Visible == false)
            {
                OcultarTsb();
                tsb.Visible = true;
                panelFormularios.Visible = false;
                flowLayoutPanel1.Size = new Size(1036, 271);
            }
            else
            {
                tsb.Visible = false;
                flowLayoutPanel1.Size = new Size(1036, 75);
                if (FormularioAbierto == null)
                {
                    return;
                }
                else
                {
                    panelFormularios.Visible = true;
                }
            }
        }

        private void btnDesplegar_Click(object sender, EventArgs e)
        {
            MostrarMenu(panelDespegable);
            panelDesplegar.Visible = false;
            panelAplegar.Visible = true;
            panel1.Size = new Size(282, 634);
            panel2.Size = new Size(814, 634);
        }

        private void btnAplegar_Click(object sender, EventArgs e)
        {
            MostrarMenu(panelDespegable);
            panelAplegar.Visible = false;
            panelDesplegar.Visible = true;
            panel1.Size = new Size(60, 634);
            panel2.Size = new Size(1036, 634);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new frmProductos(_serviceProvider));
        }

        private Form FormularioAbierto = null;
        private void AbrirFormularios(Form formulario)
        {
            if (FormularioAbierto != null)
            {//Si hay un formulario abierto 
                flowLayoutPanel1.Size = new Size(1036, 75);
                FormularioAbierto.Close(); //lo cerramos
                FormularioAbierto = formulario;//Formulario abiero sera el nuevo formulario
                formulario.TopLevel = false;//El formulario no va a ser de nivel superior, se comportara como un control
                formulario.FormBorderStyle = FormBorderStyle.None;//Quitamos el borde del formulario
                formulario.Dock = DockStyle.Fill;//Formulario se acople a todo el panel
                panelFormularios.Controls.Add(formulario);//Agregamos el formulario al panel 
                panelFormularios.Tag = formulario;//Asociamos el formulario con el panel
                formulario.Show();
            }
            else
            {
                flowLayoutPanel1.Size = new Size(1036, 75);
                FormularioAbierto = formulario;//Formulario abiero sera el nuevo formulario
                formulario.TopLevel = false;//El formulario no va a ser de nivel superior, se comportara como un control
                formulario.FormBorderStyle = FormBorderStyle.None;//Quitamos el borde del formulario
                formulario.Dock = DockStyle.Fill;//Formulario se acople a todo el panel
                panelFormularios.Controls.Add(formulario);//Agregamos el formulario al panel 
                panelFormularios.Tag = formulario;//Asociamos el formulario con el panel
                formulario.Show();
            }
            OcultarTsb();
            panelFormularios.Visible = true;

        }

        private void btnOtros_Click(object sender, EventArgs e)
        {
            MostrarTsb(toolStrip3);
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new frmMarcas(_serviceProvider));
        }

        private void btnTamanio_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new frmTamanios(_serviceProvider));
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new frmCategoria(_serviceProvider));
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new frmEmpleados(_serviceProvider));
        }
    }
}
