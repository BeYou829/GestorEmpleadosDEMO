using CRUD.Core.Application.Interfaces.Services;
using CRUD.Forms;

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
    }
}
