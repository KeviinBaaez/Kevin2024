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

            service.AddScoped<IRepositorioIngredinetes, RepositorioIngredientes>();

            service.AddScoped<IRepositorioMarcas, RepositorioMarcas>();
            service.AddScoped<IRepositorioCategorias, RepositorioCategorias>();

            service.AddScoped<IRepositorioTamanios, RepositorioTamanios>();
            //SERVICE SERVICIOS
            service.AddScoped<IServiciosLogin, ServiciosLogin>();

            service.AddScoped<IServiciosIngredientes, ServiciosIngredintes>();

            service.AddScoped<IServiciosMarcas, ServiciosMarcas>();
            service.AddScoped<IServiciosCategorias, ServiciosCategorias>();

            service.AddScoped<IServiciosLogin>(sp =>
            {
                var repositorio = new RepositorioLogin();
                return new ServiciosLogin(repositorio, cadena);
            });

            service.AddScoped<IServiciosIngredientes>(sp =>
            {
                var repositorio = new RepositorioIngredientes();
                return new ServiciosIngredintes(repositorio, cadena);
            });

            service.AddScoped<IServiciosProductos>(sp =>
            {
                var repositorio = new RepositorioProductos();
                return new ServiciosProductos(repositorio, cadena);
            });

            service.AddScoped<IServiciosMarcas>(sp =>
            {
                var repositorio = new RepositorioMarcas();
                return new ServiciosMarcas(repositorio, cadena);
            });

            service.AddScoped<IServiciosCategorias>(sp =>
            {
                var repositorio = new RepositorioCategorias();
                return new ServiciosCategorias(repositorio, cadena);
            });

            service.AddScoped<IServiciosTamanios>(sp =>
            {
                var repositorio = new RepositorioTamanios();
                return new ServiciosTamanios(repositorio, cadena);
            });

            return service.BuildServiceProvider();  
        }
    }
}
