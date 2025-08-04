using CRUD.Forms.Department;
using CRUD.Forms.Home;
using Microsoft.Extensions.DependencyInjection;

namespace CRUD
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void OpenFormInPanel(Form form)
        {
            PanelContenido.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            PanelContenido.Controls.Add(form);
            form.Show();
        }

        private void InicioBtn_Click(object sender, EventArgs e)
        {
            var dashboardForm = Program.ServiceProvider?.GetRequiredService<DashboardForm>();
            OpenFormInPanel(dashboardForm);
        }
        private void EmployeeBtn_Click(object sender, EventArgs e)
        {
            var employeeForm = Program.ServiceProvider?.GetRequiredService<EmployeeBaseForm>();
            OpenFormInPanel(employeeForm);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InicioBtn_Click(sender, e);
        }

        private void DepartmentBtn_Click(object sender, EventArgs e)
        {
            var departmentForm = Program.ServiceProvider?.GetRequiredService<DepartmentBaseForm>();
            OpenFormInPanel(departmentForm);
        }
    }
}
