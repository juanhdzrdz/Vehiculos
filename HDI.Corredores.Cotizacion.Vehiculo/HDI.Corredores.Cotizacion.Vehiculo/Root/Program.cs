using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Root
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureServices(services => services.AddAutofac())       // Enable Autofac service functionality
                .ConfigureAppConfiguration((hostingContext, config) =>      // Enable enviroment variables functionality
                {
                    config.AddEnvironmentVariables();
                })
                .UseStartup<Startup>();
    }
}
