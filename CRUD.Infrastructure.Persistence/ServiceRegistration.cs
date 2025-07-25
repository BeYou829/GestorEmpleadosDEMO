using CRUD.Core.Application.Interfaces.Repositories;
using CRUD.Infrastructure.Persistence.Contexts;
using CRUD.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CRUD.Infrastructure.Persistence
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddPersistenceLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("EmployeeDB"),
                    m => m.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName));
            });

            services.AddTransient(typeof(IGenericRepository<,>), typeof(GenericRepository<,>));
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();

            return services;
        }
    }
}
