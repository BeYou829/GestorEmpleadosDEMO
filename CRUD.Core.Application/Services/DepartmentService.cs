using CRUD.Core.Application.DTOs.Department;
using CRUD.Core.Application.Interfaces.Repositories;
using CRUD.Core.Application.Interfaces.Services;
using CRUD.Core.Domain.Entities;

namespace CRUD.Core.Application.Services
{
    public class DepartmentService(IDepartmentRepository departmentRepository)
        : GenericService<int, SaveDepartmentDTO, DepartmentDTO, Department>(departmentRepository), IDepartmentService
    {
    }
}
