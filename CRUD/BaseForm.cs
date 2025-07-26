using CRUD.Core.Application.Interfaces.Repositories;
using CRUD.Core.Application.Interfaces.Services;
using CRUD.Forms;

namespace CRUD
{
    public partial class BaseForm : Form
    {
        private readonly IEmployeeService _context;
        public BaseForm(IEmployeeService context)
        {
            InitializeComponent();
            _context = context;

            this.Load += async (s, e) => await BaseForm_LoadAsync();
        }

        private async Task BaseForm_LoadAsync()
        {
            try
            {
                var empleados = await _context.GetAllWithRelations(["Department"]);
                dataTable.DataSource = empleados;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void AddEmployeeBtn_Click(object sender, EventArgs e)
        {
            var form = new AddEmployeeForm();
            form.ShowDialog();
        }
    }
}
