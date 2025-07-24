using CRUD.Core.Application.Interfaces.Repositories;
using CRUD.Core.Domain.Entities;
using CRUD.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Infrastructure.Persistence.Repositories
{
    public class EmployeeRepository(AppDbContext context) : GenericRepository<Employee>(context), IEmployeeRepository
    {
        private readonly AppDbContext _context = context;
        public async Task<ICollection<Employee>> GetAllWithRelations(List<string> navigationProperties)
        {
            var query = _context.Set<Employee>().AsQueryable();
            foreach (var propertie in navigationProperties)
            {
                query = query.Include(propertie);  
            }
            return await query.ToListAsync();
        }
    }
}
