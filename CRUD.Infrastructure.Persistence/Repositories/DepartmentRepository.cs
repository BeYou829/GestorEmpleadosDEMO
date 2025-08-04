using CRUD.Core.Application.Interfaces.Repositories;
using CRUD.Core.Domain.Entities;
using CRUD.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Infrastructure.Persistence.Repositories
{
    public class DepartmentRepository(AppDbContext context) : GenericRepository<int, Department>(context), IDepartmentRepository
    {
        private readonly AppDbContext _context = context;
        public async Task<ICollection<Department>> GetAllWithRelations(List<string> navigationProperties)
        {
            IQueryable<Department> query = _context
                .Set<Department>()
                .Where(e => e.IsActive)
                .AsQueryable();

            foreach (var property in navigationProperties)
            {
                query = query.Include(property);
            }
            return await query.ToListAsync();
        }

        public async override Task<bool> DeactiveAsync(int key)
        {
            // Check if there are any employees associated with the department
            bool anyEmployeesAssigned = await _context.Set<Employee>().AnyAsync(e => e.DepartmentId == key && e.IsActive);
            if (anyEmployeesAssigned)
            {
                return false; // Cannot deactivate department if there are active employees assigned
            }
            return await base.DeactiveAsync(key);
        }
    }
}
