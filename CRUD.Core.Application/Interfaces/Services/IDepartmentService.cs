using CRUD.Core.Application.DTOs.Department;
using CRUD.Core.Domain.Entities;

namespace CRUD.Core.Application.Interfaces.Services
{
    public interface IDepartmentService : IGenericService<int, SaveDepartmentDTO, DepartmentDTO, Department>
    {
    }
}
