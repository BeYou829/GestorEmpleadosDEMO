using CRUD.Core.Domain.Entities;

namespace CRUD.Core.Application.Interfaces.Repositories
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        Task<ICollection<Employee>> GetAllWithRelations(List<string> navigationProperties);
    }
}
