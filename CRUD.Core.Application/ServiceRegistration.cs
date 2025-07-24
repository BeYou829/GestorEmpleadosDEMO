using CRUD.Core.Application.Interfaces.Services;
using CRUD.Core.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CRUD.Core.Application
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
        {
            services.AddTransient<IEmployeeService, EmployeeService>();
            return services;
        }
    }
}
