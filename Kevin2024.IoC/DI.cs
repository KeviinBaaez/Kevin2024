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
            //SERVICE SERVICIOS
            service.AddScoped<IServiciosLogin, ServiciosLogin>();

            service.AddScoped<IServiciosEmpleados, ServiciosEmpleados>();

            service.AddScoped<IServiciosTipos, ServiciosTipos>();

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

            service.AddScoped<IServiciosTipos>(sp =>
            {
                var repositorio = new RepositorioTipos();
                return new ServiciosTipos(repositorio, cadena);
            });

            return service.BuildServiceProvider();  
        }
    }
}
