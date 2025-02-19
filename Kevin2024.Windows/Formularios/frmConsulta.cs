using Kevin2024.Entidades.Dtos;
using Kevin2024.Entidades.Entidades;
using Kevin2024.Servicios.Interfaces;
using Kevin2024.Windows.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace Kevin2024.Windows.Formularios
{
    public partial class frmConsulta : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private readonly IServicioConsulta? _servicios;
        private TiposDeDatos? consulta;
        private List<ProductosListDto> lista;
        public frmConsulta(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _servicios = serviceProvider?.GetService<IServicioConsulta>() ?? throw new ApplicationException("Dependencias no cargadas!!");
        }

        public void SetConsulta(TiposDeDatos consulta)
        {
            this.consulta = consulta;
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            lista = _servicios!.GetLista(consulta);
            GridHelper.MostrarDatosEnGrilla<ProductosListDto>(lista, dgvDatos);
        }
    }
}
