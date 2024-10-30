using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kevin2024.Windows.Formularios
{
    public partial class frmMenuPrincipal : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        public frmMenuPrincipal(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            frmMarcas frm = new frmMarcas(_serviceProvider);
            frm.ShowDialog();
        }

        private void btnBebidas_Click(object sender, EventArgs e)
        {
            frmBebidas frm = new frmBebidas(_serviceProvider);
            frm.ShowDialog();
        }

        private void btnTamanio_Click(object sender, EventArgs e)
        {
            frmTamanios frm = new frmTamanios(_serviceProvider);
            frm.ShowDialog();
        }

        private void btnPostres_Click(object sender, EventArgs e)
        {
            frmPostres frm = new frmPostres(_serviceProvider);
            frm.ShowDialog();
        }

        private void brnCategoria_Click(object sender, EventArgs e)
        {
            frmCategoria frmCategoria = new frmCategoria(_serviceProvider);
            frmCategoria.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal(_serviceProvider);
            frmPrincipal.ShowDialog();
        }
    }
}
