using CRUD.Core.Application.DTOs.Department;
using CRUD.Core.Application.DTOs.Employee;
using CRUD.Core.Application.Interfaces.Services;

namespace CRUD.Forms
{
    public partial class AddEmployeeForm : Form
    {
        private readonly IDepartmentService _departmentService;
        private readonly IEmployeeService _employeeService;
        private int? _employeeId;
        public AddEmployeeForm(IDepartmentService departmentService, IEmployeeService employeeService, int? employeeId = null)
        {
            InitializeComponent();
            _departmentService = departmentService;
            _employeeService = employeeService;

            this.Load += async (s, e) => await ComboBox_LoadAsync();
            _employeeId = employeeId;
            if(_employeeId.HasValue)
            {
                LoadEmployee();
            }

        }
        private async void LoadEmployee()
        {
            var existingEmployee = await _employeeService.GetByIdAsync(_employeeId.Value);

            TextBoxFirstName.Text = existingEmployee.FirstName;
            TextBoxLastName.Text = existingEmployee.LastName;
            TextBoxPosition.Text = existingEmployee.Position;
            TextBoxSalary.Text = existingEmployee.Salary.ToString();
            ComboBoxDepartments.Text = await _departmentService.GetAllAsync()
                .ContinueWith(task => task.Result.FirstOrDefault(d => d.Name == existingEmployee.DepartmentName).Name);
            ComboBoxDepartments.Enabled = false;

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
                //Si el employee id tiene un valor, edita, si no, crea un nuevo empleado
                if (_employeeId.HasValue)
                {
                    var editedEmployee = new SaveEmployeeDTO
                    {
                        Id = _employeeId.Value,
                        FirstName = TextBoxFirstName.Text,
                        LastName = TextBoxLastName.Text,
                        Position = TextBoxPosition.Text,
                        Salary = decimal.Parse(TextBoxSalary.Text),
                        DepartmentId = (ComboBoxDepartments.SelectedItem as DepartmentDTO).Id
                    };
                    await _employeeService.UpdateAsync(editedEmployee.Id, editedEmployee);
                    this.Close();
                }
                else
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

            }
            catch (Exception)
            {
                MessageBox.Show("Error saving employee. Please check the details and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
