using CRUD.Core.Domain.Common;
using System.Data.SqlTypes;

namespace CRUD.Core.Domain.Entities
{
    public class Employee : BaseAuditable
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
