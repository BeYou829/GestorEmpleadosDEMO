using Mapster;
using MapsterMapper;
using CRUD.Core.Application.Interfaces.Services;
using CRUD.Core.Application.Services;
using CRUD.Core.Application.Settings;
using Microsoft.Extensions.DependencyInjection;


namespace CRUD.Core.Application
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
        {
            var config = TypeAdapterConfig.GlobalSettings;
            MapperConfiguration.RegisterMappings();

            services.AddSingleton(config);
            services.AddScoped<IMapper, ServiceMapper>();

            services.AddTransient(typeof(IGenericService<, , ,>), typeof(GenericService<, , ,>));
            services.AddTransient<IEmployeeService, EmployeeService>();
            services.AddTransient<IDepartmentService, DepartmentService>();

            return services;
        }
    }
}
