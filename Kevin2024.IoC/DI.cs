using Kevin2024.Datos.Interfaces;
using Kevin2024.Datos.Repositorios;
using Kevin2024.Servicios.Interfaces;
using Kevin2024.Servicios.Servicios;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;

namespace Kevin2024.IoC
{
    public static class DI
    {
        public static IServiceProvider ConfigurarServicios()
        {
            var service = new ServiceCollection();

            var cadena = ConfigurationManager
                .ConnectionStrings["MiConexion"].ToString();
            //SERVICE REPOSITORIOS
            service.AddScoped<IRepositorioProductos, RepositorioProductos>();

            service.AddScoped<IRepositorioLogin, RepositorioLogin>();

            service.AddScoped<IRepositorioEmpleados, RepositorioEmpleados>();

            service.AddScoped<IRepositorioVentas, RepositorioVentas>();

            service.AddScoped<IRepositorioClientes, RepositorioClientes>();

            service.AddScoped<IRepositorioClientesDirecciones, RepositorioClientesDirecciones>();

            service.AddScoped<IRepositorioClientesTelefonos, RepositorioClientesTelefonos>();

            service.AddScoped<IRepositorioTelefonos, RepositorioTelefonos>();

            service.AddScoped<IRepositorioDirecciones, RepositorioDirecciones>();

            service.AddScoped<IRepositorioTiposDeTelefonos, RepositorioTiposDeTelefonos>();

            service.AddScoped<IRepositorioTiposDeDirecciones, RepositorioTiposDeDirecciones>();
            //SERVICE SERVICIOS
            service.AddScoped<IServiciosLogin, ServiciosLogin>();

            service.AddScoped<IServiciosEmpleados, ServiciosEmpleados>();

            service.AddScoped<IServiciosArchivos, ServiciosArchivos>();

            service.AddScoped<IServicioConsulta, ServiciosConsulta>();

            service.AddScoped<IServiciosCombos, ServiciosCombos>();

            service.AddScoped<IServiciosVentas, ServiciosVentas>();

            service.AddScoped<IServiciosUsuarios, ServiciosUsuarios>();



            service.AddScoped<IServiciosLogin>(sp =>
            {
                var repositorio = new RepositorioLogin();
                return new ServiciosLogin(repositorio, cadena);
            });

            service.AddScoped<IServiciosProductos>(sp =>
            {
                var repositorio = new RepositorioProductos();
                return new ServiciosProductos(repositorio, cadena);
            });

            service.AddScoped<IServiciosEmpleados>(sp =>
            {
                var repositorio = new RepositorioEmpleados();
                return new ServiciosEmpleados(repositorio, cadena);
            });

            service.AddScoped<IServiciosArchivos>(sp =>
            {
                var repositorio = new RepositorioArchivos();
                return new ServiciosArchivos(repositorio, cadena);
            });

            service.AddScoped<IServicioConsulta>(sp =>
            {
                var repositorio = new RepositorioConsulta();
                return new ServiciosConsulta(repositorio, cadena);
            });

            service.AddScoped<IServiciosCombos>(sp =>
            {
                var repositorio = new RepositorioCombos();
                var repositorioDetalles = new RepositorioDetallesCombos();
                return new ServiciosCombos(repositorio, repositorioDetalles, cadena);
            });

            service.AddScoped<IServiciosVentas>(sp =>
            {
                var repositorio = new RepositorioVentas();
                var repositorioDetalles = new RepositorioDetallesVentas();
                return new ServiciosVentas(repositorio,repositorioDetalles, cadena);
            });

            service.AddScoped<IServiciosOrden>(sp =>
            {
                var repositorio = new RepositorioOrden();
                var repositorioDetalles = new RepositorioDetalleOrden();
                return new ServiciosOrden(repositorio, repositorioDetalles, cadena);
            });

            service.AddScoped<IServiciosClientes>(sp =>
            {
                var repositorio = new RepositorioClientes();
                var repositorioDirecciones = new RepositorioDirecciones();
                var repositorioTelefonos = new RepositorioTelefonos();
                var repositorioClientesDirecciones = new RepositorioClientesDirecciones();
                var repositorioClientesTelefonos = new RepositorioClientesTelefonos();
                return new ServiciosClientes(repositorio,
                    repositorioDirecciones,
                    repositorioTelefonos,
                    repositorioClientesDirecciones,
                    repositorioClientesTelefonos,
                    cadena);
            });

            service.AddScoped<IServiciosTiposDeDirecciones>(sp =>
            {
                var repositorio = new RepositorioTiposDeDirecciones();
                return new ServiciosTiposDeDirecciones(repositorio, cadena);
            });

            service.AddScoped<IServiciosTiposDeTelefonos>(sp =>
            {
                var repositorio = new RepositorioTiposDeTelefonos();
                return new ServiciosTiposDeTelefonos(repositorio, cadena);
            });

            service.AddScoped<IServiciosUsuarios>(sp =>
            {
                var repositorio = new RepositorioUsuario();
                return new ServiciosUsuarios(repositorio, cadena);
            });

            return service.BuildServiceProvider();  
        }
    }
}
