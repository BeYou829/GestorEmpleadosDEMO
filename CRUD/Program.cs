using CRUD.Core.Application;
using CRUD.Infrastructure.Persistence;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CRUD
{
    internal static class Program
    {
        public static IServiceProvider? ServiceProvider { get; private set; }
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<BaseForm>());
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    // Agregando los servicios de la capa de infraestructura y aplicación
                    services
                            .AddPersistenceLayer(context.Configuration)
                            .AddApplicationLayer();

                    services.AddTransient<BaseForm>();
                });
        }
    }
}