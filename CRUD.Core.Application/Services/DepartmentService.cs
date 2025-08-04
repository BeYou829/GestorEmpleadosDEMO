using CRUD.Core.Application.DTOs.Department;
using CRUD.Core.Application.Interfaces.Repositories;
using CRUD.Core.Application.Interfaces.Services;
using CRUD.Core.Domain.Entities;
using MapsterMapper;

namespace CRUD.Core.Application.Services
{
    public class DepartmentService(
        IDepartmentRepository departmentRepository,
        IEmployeeService employeeService,
        IMapper mapper)
        : GenericService<int, SaveDepartmentDTO, DepartmentDTO, Department>(departmentRepository), IDepartmentService
    {
        public async Task<ICollection<DepartmentDTO>> GetAllWithRelations(List<string> navigationProperties)
        {
            var departments = await departmentRepository.GetAllWithRelations(navigationProperties);
            return mapper.Map<ICollection<DepartmentDTO>>(departments);
        }
        //public override Task<bool> DeactiveAsync(int key)
        //{
        //    // Tengo que verificar que no haya empleados asociados al departamento antes de desactivarlo
        //    var employeesAssigned = employeeService.GetAllWithRelations(["Department"])
        //        .ContinueWith(task => task.Result.Any(e => e.));
        //    return base.DeactiveAsync(key);
        //}
    }
}
