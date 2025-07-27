using CRUD.Core.Application.DTOs.Department;
using CRUD.Core.Application.DTOs.Employee;
using CRUD.Core.Application.Interfaces.Services;

namespace CRUD.Forms
{
    public partial class AddEmployeeForm : Form
    {
        private readonly IDepartmentService _departmentService;
        private readonly IEmployeeService _employeeService;

        public AddEmployeeForm(IDepartmentService departmentService, IEmployeeService employeeService)
        {
            InitializeComponent();
            _departmentService = departmentService;
            _employeeService = employeeService;

            this.Load += async (s, e) => await ComboBox_LoadAsync();
        }
        private async Task ComboBox_LoadAsync()
        {
            try
            {
                var departments = await _departmentService.GetAllAsync();
                ComboBoxDepartments.DataSource = departments;
            }
            catch (Exception)
            {
                MessageBox.Show("Error loading departments. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private async void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var newEmployee = new SaveEmployeeDTO
                {
                    FirstName = TextBoxFirstName.Text,
                    LastName = TextBoxLastName.Text,
                    Position = TextBoxPosition.Text,
                    Salary = decimal.Parse(TextBoxSalary.Text),
                    DepartmentId = (ComboBoxDepartments.SelectedItem as DepartmentDTO).Id
                };
                await _employeeService.AddAsync(newEmployee);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error saving employee. Please check the details and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
