using CRUD.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace CRUD
{
    public partial class BaseForm : Form
    {
        private readonly AppDbContext _context;
        public BaseForm(AppDbContext context)
        {
            InitializeComponent();
            _context = context;

            this.Load += async (s, e) => await BaseForm_LoadAsync();
        }

        private async Task BaseForm_LoadAsync()
        {
            try
            {
                var empleados = await _context.Employees.ToListAsync();
                dataTable.DataSource = empleados;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
