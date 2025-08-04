using CRUD.Core.Application.DTOs.Department;
using CRUD.Core.Application.DTOs.Employee;
using CRUD.Core.Application.Interfaces.Services;
using CRUD.Core.Application.Services;

namespace CRUD.Forms.Department
{
    public partial class AddDepartmentForm : Form
    {
        private readonly IDepartmentService _departmentService;
        private int? _departmentId;
        public AddDepartmentForm(IDepartmentService departmentService, int? departmentId = null)
        {
            InitializeComponent();
            _departmentService = departmentService;
            _departmentId = departmentId;
            if (departmentId.HasValue)
            {
                this.Text = "Edit Department";
                LoadDepartment();
            }
        }
        private async void LoadDepartment()
        {
            var existingDepartment = await _departmentService.GetByIdAsync(_departmentId.Value);

            TextBoxName.Text = existingDepartment.Name;
            TextBoxDescription.Text = existingDepartment.Description;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Si el departamento id tiene un valor, edita, si no, crea un nuevo empleado
                if (_departmentId.HasValue)
                {
                    var editedDepartment = new SaveDepartmentDTO
                    {
                        Id = _departmentId.Value,
                        Name = TextBoxName.Text,
                        Description = TextBoxDescription.Text,
                    };
                    await _departmentService.UpdateAsync(editedDepartment.Id, editedDepartment);
                    this.Close();
                }
                else
                {
                    var newEmployee = new SaveDepartmentDTO
                    {
                        Name = TextBoxName.Text,
                        Description = TextBoxDescription.Text,
                    };
                    await _departmentService.AddAsync(newEmployee);
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
