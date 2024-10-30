using Kevin2024.IoC;
using Kevin2024.Windows.Formularios;

namespace Kevin2024.Windows
{
    internal static class Program
    {
        private static IServiceProvider? _serviceProvider;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            _serviceProvider = DI.ConfigurarServicios();
            ApplicationConfiguration.Initialize();
            Application.Run(new frmPrincipal(_serviceProvider));
            //Application.Run(new frmMenuPrincipal(_serviceProvider));
        }
    }
}