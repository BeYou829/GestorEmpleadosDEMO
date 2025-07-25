using CRUD.Core.Application.DTOs.Employee;
using CRUD.Core.Domain.Entities;

namespace CRUD.Core.Application.Interfaces.Services
{
    public interface IEmployeeService : IGenericService<int, SaveEmployeeDTO, EmployeeDTO, Employee>
    {
        Task<ICollection<EmployeeDTO>> GetAllWithRelations(List<string> navigationProperties);
    }
}
