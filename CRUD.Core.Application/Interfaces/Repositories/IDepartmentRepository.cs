using CRUD.Core.Domain.Entities;

namespace CRUD.Core.Application.Interfaces.Repositories
{
    public interface IDepartmentRepository : IGenericRepository<int, Department>
    {
    }
}
