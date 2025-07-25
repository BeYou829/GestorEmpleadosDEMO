using CRUD.Core.Application.DTOs.Employee;
using CRUD.Core.Application.Interfaces.Repositories;
using CRUD.Core.Application.Interfaces.Services;
using CRUD.Core.Domain.Entities;
using Mapster;
using MapsterMapper;

namespace CRUD.Core.Application.Services
{
    public class EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        : GenericService<int, SaveEmployeeDTO, EmployeeDTO, Employee>(employeeRepository), IEmployeeService
    {
        public async Task<ICollection<EmployeeDTO>> GetAllWithRelations(List<string> navigationProperties)
        {
            var employees = await employeeRepository.GetAllWithRelations(navigationProperties);
            return mapper.Map<ICollection<EmployeeDTO>>(employees);
        }
    }
}
