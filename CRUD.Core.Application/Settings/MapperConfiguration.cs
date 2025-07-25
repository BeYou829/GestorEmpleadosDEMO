using CRUD.Core.Application.DTOs.Employee;
using CRUD.Core.Domain.Entities;
using Mapster;

namespace CRUD.Core.Application.Settings
{
    public static class MapperConfiguration
    {
        public static void RegisterMappings()
        {
            TypeAdapterConfig<Employee, EmployeeDTO>
                .NewConfig()
                .Map(dto => dto.DepartmentName, entity => entity.Department.Name);
                
        }
    }
}
