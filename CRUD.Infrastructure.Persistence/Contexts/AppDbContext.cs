using CRUD.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Infrastructure.Persistence.Contexts
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
