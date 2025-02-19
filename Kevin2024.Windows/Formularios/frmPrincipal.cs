using Kevin2024.Entidades.Entidades;
using System.Windows.Forms;

namespace Kevin2024.Windows.Formularios
{
    public partial class frmPrincipal : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private Form? FormularioAbierto = null;
        private Usuario? usuario;

        private string imagenNoDisponible = Environment.CurrentDirectory + @"\ImágenesUsuarios\SinImagenDisponible.jpg";
        private string archivoNoEncontrado = Environment.CurrentDirectory + @"\ImágenesUsuarios\ArchivoNoEncontrado.jpg";
        private string? archivoImagen = string.Empty;
        private string carpetaImagen = Environment.CurrentDirectory + @"\ImágenesUsuarios\";

        public frmPrincipal(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            PersonalizarInicio();
            _serviceProvider = serviceProvider;

        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblNombreusuario.Text = usuario!.NombreUsuario;
            if (usuario.Imagen != string.Empty)
            {
                if (!File.Exists($"{carpetaImagen}{usuario.Imagen}"))
                {
                    picImgUsuario.Image = Image.FromFile(archivoNoEncontrado);
                }
                else
                {
                    picImgUsuario.Image = Image.FromFile($"{carpetaImagen}{usuario.Imagen}");
                    archivoImagen = usuario.Imagen;
                }
            }
            else
            {
                picImgUsuario.Image = Image.FromFile(imagenNoDisponible);
            }
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
        private void PersonalizarInicio()
        {
            panelDespegable.Visible = false;
            panelAplegar.Visible = false;
            panel1.Size = new Size(60, 634);
            toolStrip3.Visible = false;
            panelFormularios.Visible = false;
            tsbSentingsUsers.Enabled = true;
        }

        private void MostrarMenu(Panel menu)
        {
            if (menu.Visible == false)
            {
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
                flowLayoutPanel1.Size = new Size(1036, 344);
            }
            else
            {
                tsb.Visible = false;
                flowLayoutPanel1.Size = new Size(1036, 72);
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

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new frmProductos(_serviceProvider));
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

        private void btnGeneros_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new frmGeneros(_serviceProvider));
        }

        private void btnCombos_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new frmCombos(_serviceProvider));
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new frmVentasAE(_serviceProvider));
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new frmClientes(_serviceProvider));
        }

        private void btnTiposTelefonos_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new frmTiposTelefonos(_serviceProvider));
        }

        private void btnTiposDirecciones_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new frmTiposDirecciones(_serviceProvider));
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new frmUsuarios(_serviceProvider));
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void SetUsuario(Usuario usuario)
        {
            this.usuario = usuario;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            HabilitarMenu();
        }
        private void HabilitarMenu()
        {
            btnProductos.Enabled = false;
            btnCombos.Enabled = false;
            btnVentas.Enabled = false;
            btnClientes.Enabled = false;
            btnEmpleados.Enabled = false;
            btnOtros.Enabled = false;
            foreach (var item in usuario!.Rol!.Permisos)
            {
                if(item.Permiso!.Menu == "Productos")
                {
                    btnProductos.Enabled = true;
                }
                if (item.Permiso.Menu == "Combos")
                {
                    btnCombos.Enabled = true;
                }
                if (item.Permiso.Menu == "Ventas")
                {
                    btnVentas.Enabled = true;
                }
                if (item.Permiso.Menu == "Clientes")
                {
                    btnClientes.Enabled = true;
                }
                if (item.Permiso.Menu == "Empleados")
                {
                    btnEmpleados.Enabled = true;
                }
                if (item.Permiso.Menu == "Archivos")
                {
                    btnOtros.Enabled = true;
                }
            }
        }
    }
}
