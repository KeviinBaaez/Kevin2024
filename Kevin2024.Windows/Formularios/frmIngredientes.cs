using Kevin2024.Entindades;
using Kevin2024.Servicios.Interfaces;
using Kevin2024.Windows.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace Kevin2024.Windows.Formularios
{
    public partial class frmIngredientes : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private readonly IServiciosIngredientes? _servicio;

        private List<Ingredientes>? lista;
        public frmIngredientes(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _servicio = _serviceProvider?.GetService<IServiciosIngredientes>();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmIngredientes_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                lista = _servicio!.GetLista();
                GridHelper.MostrarDatosEnGrilla(lista, dgvDatos);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
