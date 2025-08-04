using CRUD.Core.Application.Interfaces.Services;
using CRUD.Forms;
using CRUD.Helpers;

namespace CRUD
{
    public partial class EmployeeBaseForm : Form
    {
        private readonly IEmployeeService _employeeService;
        private readonly IDepartmentService _departmentService;
        public EmployeeBaseForm(IEmployeeService employeeService, IDepartmentService departmentService)
        {
            InitializeComponent();
            _employeeService = employeeService;
            _departmentService = departmentService;

            this.Load += async (s, e) => await BaseForm_LoadAsync();
        }

        private async Task BaseForm_LoadAsync()
        {
            await RefreshData();
        }

        private async void AddEmployeeBtn_Click(object sender, EventArgs e)
        {
            var form = new AddEmployeeForm(_departmentService, _employeeService);
            form.ShowDialog();
            await RefreshData();
        }
        private async Task RefreshData()
        {
            try
            {
                var empleados = await _employeeService.GetAllWithRelations(["Department"]);
                DataTableEmployees.DataSource = empleados;

                DataTableEmployees.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private async void EditEmployeeBtn_Click(object sender, EventArgs e)
        {
            int? employeeId = DataTableHelpers.GetSelectedId(DataTableEmployees);
            if (employeeId.HasValue)
            {
                AddEmployeeForm editForm = new(_departmentService, _employeeService, employeeId);
                editForm.ShowDialog();
                await RefreshData();
            }
            else
            {
                MessageBox.Show("Please select an employee to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void DeleteEmployeeBtn_Click(object sender, EventArgs e)
        {
            int? employeeId = DataTableHelpers.GetSelectedId(DataTableEmployees);

            if (employeeId.HasValue)
            {
                var employee = await _employeeService.GetByIdAsync(employeeId.Value);

                var result = MessageBox.Show($"Are you sure you want to delete {employee.FirstName} {employee.LastName}? ",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    await _employeeService.DeactiveAsync(employee.Id);
                    await RefreshData();
                }
                else
                {
                    await RefreshData();
                }
            }
            else
            {
                MessageBox.Show("Please select an employee to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
