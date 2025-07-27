using CRUD.Core.Application.DTOs.Employee;
using CRUD.Core.Application.Interfaces.Services;
using CRUD.Forms;
using System.Windows.Forms;

namespace CRUD
{
    public partial class BaseForm : Form
    {
        private readonly IEmployeeService _employeeService;
        private readonly IDepartmentService _departmentService;
        public BaseForm(IEmployeeService employeeService, IDepartmentService departmentService)
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
                dataTable.DataSource = empleados;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private int? GetSelectedEmployeeId()
        {
            try
            {
                var id = int.Parse(dataTable.Rows[dataTable.CurrentRow.Index].Cells[0].Value.ToString());
                return id;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        private async void EditEmployeeBtn_Click(object sender, EventArgs e)
        {
            int? employeeId = GetSelectedEmployeeId();
            if (employeeId.HasValue)
            {
                AddEmployeeForm editForm = new AddEmployeeForm(_departmentService, _employeeService, employeeId);
                editForm.ShowDialog();
                await RefreshData();
            }
        }
    }
}
