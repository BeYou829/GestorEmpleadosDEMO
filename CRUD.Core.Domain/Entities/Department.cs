using CRUD.Core.Domain.Common;

namespace CRUD.Core.Domain.Entities
{
    public class Department : BaseAuditable
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
