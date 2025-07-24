using CRUD.Core.Application.DTOs.Employee;

namespace CRUD.Core.Application.Interfaces.Services
{
    public interface IEmployeeService
    {
        Task AddAsync(SaveEmployeeDTO employee);
        Task<EmployeeDTO> GetByIdAsync(int id);
        Task UpdateAsync(SaveEmployeeDTO employee);
        Task<ICollection<EmployeeDTO>> GetAllAsync();
        Task DeleteAsync(int id);
    }
}
