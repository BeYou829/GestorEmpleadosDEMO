using CRUD.Core.Application.Interfaces.Services;
using CRUD.Core.Application.Services;
using CRUD.Helpers;

namespace CRUD.Forms.Department
{
    public partial class DepartmentBaseForm : Form
    {
        private readonly IDepartmentService _departmentService;
        public DepartmentBaseForm(IDepartmentService departmentService)
        {
            InitializeComponent();

            _departmentService = departmentService;

            this.Load += async (s, e) => await BaseForm_LoadAsync();
        }

        private async Task BaseForm_LoadAsync()
        {
            await RefreshData();
        }

        private async Task RefreshData()
        {
            try
            {
                var departments = await _departmentService.GetAllWithRelations(["Employees"]);
                DataTableDepartments.DataSource = departments;
                // Hide the Id column
                DataTableDepartments.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private async void AddDepartmentBtn_Click(object sender, EventArgs e)
        {
            var form = new AddDepartmentForm(_departmentService);
            form.ShowDialog();
            await RefreshData();
        }

        private async void EditDepartmentBtn_Click(object sender, EventArgs e)
        {
            int? departmentId = DataTableHelpers.GetSelectedId(DataTableDepartments);
            if (departmentId.HasValue)
            {
                var form = new AddDepartmentForm(_departmentService, departmentId);
                form.ShowDialog();
                await RefreshData();
            }
            else
            {
                MessageBox.Show("Please select a department to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void DeleteDepartmentBtn_Click(object sender, EventArgs e)
        {
            int? departmentId = DataTableHelpers.GetSelectedId(DataTableDepartments);
            if (departmentId.HasValue)
            {
                var department = await _departmentService.GetByIdAsync(departmentId.Value);
                var result = MessageBox.Show($"Are you sure you want to delete {department.Name}? ",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    var success = await _departmentService.DeactiveAsync(department.Id);
                    if (!success)
                    {
                        MessageBox.Show("Cannot delete department because it has active employees assigned.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    await RefreshData();
                }
                else
                {
                    await RefreshData();
                }
            }
            else
            {
                MessageBox.Show("Please select a department to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
