using System.ComponentModel;

namespace CRUD.Core.Application.DTOs.Employee
{
    public sealed class EmployeeDTO
    {
        [DisplayName("Identifier")]
        public int Id { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; } = string.Empty;
        [DisplayName("Last Name")]
        public string LastName { get; set; } = string.Empty;
        [DisplayName("Position")]
        public string Position { get; set; } = string.Empty;
        [DisplayName("Salary")]
        public decimal Salary { get; set; }
        [DisplayName("Department Name")]
        public string DepartmentName { get; set; } = string.Empty;
    }
}
