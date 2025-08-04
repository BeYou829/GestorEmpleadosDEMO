namespace CRUD
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PanelMenu = new Panel();
            DepartmentBtn = new Button();
            EmployeeBtn = new Button();
            InicioBtn = new Button();
            PanelContenido = new Panel();
            PanelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // PanelMenu
            // 
            PanelMenu.BackColor = SystemColors.ControlLight;
            PanelMenu.Controls.Add(DepartmentBtn);
            PanelMenu.Controls.Add(EmployeeBtn);
            PanelMenu.Controls.Add(InicioBtn);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(179, 485);
            PanelMenu.TabIndex = 1;
            // 
            // DepartmentBtn
            // 
            DepartmentBtn.Location = new Point(12, 141);
            DepartmentBtn.Name = "DepartmentBtn";
            DepartmentBtn.Size = new Size(155, 44);
            DepartmentBtn.TabIndex = 2;
            DepartmentBtn.Text = "Reportes Departamentos";
            DepartmentBtn.UseVisualStyleBackColor = true;
            DepartmentBtn.Click += DepartmentBtn_Click;
            // 
            // EmployeeBtn
            // 
            EmployeeBtn.Location = new Point(12, 91);
            EmployeeBtn.Name = "EmployeeBtn";
            EmployeeBtn.Size = new Size(155, 44);
            EmployeeBtn.TabIndex = 1;
            EmployeeBtn.Text = "Reportes Empleados";
            EmployeeBtn.UseVisualStyleBackColor = true;
            EmployeeBtn.Click += EmployeeBtn_Click;
            // 
            // InicioBtn
            // 
            InicioBtn.Location = new Point(12, 41);
            InicioBtn.Name = "InicioBtn";
            InicioBtn.Size = new Size(155, 44);
            InicioBtn.TabIndex = 0;
            InicioBtn.Text = "Inicio";
            InicioBtn.UseVisualStyleBackColor = true;
            InicioBtn.Click += InicioBtn_Click;
            // 
            // PanelContenido
            // 
            PanelContenido.BackColor = SystemColors.Control;
            PanelContenido.Dock = DockStyle.Fill;
            PanelContenido.Location = new Point(179, 0);
            PanelContenido.Name = "PanelContenido";
            PanelContenido.Size = new Size(762, 485);
            PanelContenido.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 485);
            Controls.Add(PanelContenido);
            Controls.Add(PanelMenu);
            MaximizeBox = false;
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            PanelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelMenu;
        private Button DepartmentBtn;
        private Button EmployeeBtn;
        private Button InicioBtn;
        private Panel PanelContenido;
    }
}