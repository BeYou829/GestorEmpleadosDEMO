using CRUD.Core.Application.DTOs.Employee;
using CRUD.Core.Application.Interfaces.Repositories;
using CRUD.Core.Application.Interfaces.Services;
using CRUD.Core.Domain.Entities;

namespace CRUD.Core.Application.Services
{
    public class EmployeeService(IEmployeeRepository employeeRepository) : IEmployeeService
    {
        public async Task AddAsync(SaveEmployeeDTO employee)
        {
            Employee newEmployee = new Employee
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Position = employee.Position,
                Salary = employee.Salary,
                DepartmentId = employee.DeparmentId
            };
            await employeeRepository.AddAsync(newEmployee);
        }

        public async Task DeleteAsync(int id)
        {
            if(await employeeRepository.ExistsAsync(id))
            {
                await employeeRepository.DeleteAsync(id);
            }
            else
            {
                throw new KeyNotFoundException($"Employee with ID {id} not found.");
            }
        }

        public async Task<ICollection<EmployeeDTO>> GetAllAsync()
        {
            var employees = await employeeRepository.GetAllWithRelations(["Department"]);

            return employees.Select(e => new EmployeeDTO
            {
                Id = e.Id,
                FirstName = e.FirstName,
                LastName = e.LastName,
                Position = e.Position,
                Salary = e.Salary,
                Department = e.Department.Name,
            }).ToList();
        }

        public async Task<EmployeeDTO> GetByIdAsync(int id)
        {
            var employee = await employeeRepository.GetByIdAsync(id);
            return new EmployeeDTO
            {
                Id = employee.Id,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Position = employee.Position,
                Salary = employee.Salary,
                Department = employee.Department?.Name ?? "No Department"
            };
        }

        public async Task UpdateAsync(SaveEmployeeDTO employee)
        {
            var existingEmployee = await employeeRepository.GetByIdAsync(employee.Id);
            await employeeRepository.UpdateAsync(employee.Id, existingEmployee);
        }
    }
}
