using CRUD.Core.Application.Interfaces.Repositories;
using CRUD.Core.Domain.Entities;
using CRUD.Infrastructure.Persistence.Contexts;

namespace CRUD.Infrastructure.Persistence.Repositories
{
    public class DepartmentRepository(AppDbContext context) : GenericRepository<int, Department>(context), IDepartmentRepository
    {
    }
}
