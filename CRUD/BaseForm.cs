using CRUD.Core.Application.Interfaces.Repositories;

namespace CRUD
{
    public partial class BaseForm : Form
    {
        private readonly IEmployeeRepository _context;
        public BaseForm(IEmployeeRepository context)
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
    }
}
