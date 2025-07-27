using CRUD.Core.Application.Interfaces.Repositories;
using CRUD.Core.Domain.Entities;
using CRUD.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Infrastructure.Persistence.Repositories
{
    public class EmployeeRepository(AppDbContext context) : GenericRepository<int, Employee>(context), IEmployeeRepository
    {
        private readonly AppDbContext _context = context;
        public async Task<ICollection<Employee>> GetAllWithRelations(List<string> navigationProperties)
        {
            IQueryable<Employee> query = _context
                .Set<Employee>()
                .Where(e => e.IsActive)
                .AsQueryable();

            foreach (var property in navigationProperties)
            {
                query = query.Include(property);  
            }
            return await query.ToListAsync();
        }
    }
}
