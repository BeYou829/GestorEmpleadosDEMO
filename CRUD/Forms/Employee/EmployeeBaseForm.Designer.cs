namespace CRUD
{
    partial class EmployeeBaseForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeBaseForm));
            DataTableEmployees = new DataGridView();
            AddEmployeeBtn = new Button();
            EditEmployeeBtn = new Button();
            DeleteEmployeeBtn = new Button();
            TitleLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)DataTableEmployees).BeginInit();
            SuspendLayout();
            // 
            // DataTableEmployees
            // 
            DataTableEmployees.AllowUserToAddRows = false;
            DataTableEmployees.AllowUserToDeleteRows = false;
            DataTableEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataTableEmployees.BackgroundColor = SystemColors.ButtonShadow;
            DataTableEmployees.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataTableEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataTableEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataTableEmployees.Location = new Point(12, 108);
            DataTableEmployees.MultiSelect = false;
            DataTableEmployees.Name = "DataTableEmployees";
            DataTableEmployees.ReadOnly = true;
            DataTableEmployees.Size = new Size(722, 326);
            DataTableEmployees.TabIndex = 0;
            // 
            // AddEmployeeBtn
            // 
            AddEmployeeBtn.Image = Properties.Resources.user_plus;
            AddEmployeeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            AddEmployeeBtn.Location = new Point(12, 67);
            AddEmployeeBtn.Name = "AddEmployeeBtn";
            AddEmployeeBtn.Size = new Size(129, 35);
            AddEmployeeBtn.TabIndex = 1;
            AddEmployeeBtn.Text = "Add Employee  ";
            AddEmployeeBtn.TextAlign = ContentAlignment.MiddleRight;
            AddEmployeeBtn.UseVisualStyleBackColor = true;
            AddEmployeeBtn.Click += AddEmployeeBtn_Click;
            // 
            // EditEmployeeBtn
            // 
            EditEmployeeBtn.Image = Properties.Resources.user_pen;
            EditEmployeeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            EditEmployeeBtn.Location = new Point(147, 67);
            EditEmployeeBtn.Name = "EditEmployeeBtn";
            EditEmployeeBtn.Size = new Size(129, 35);
            EditEmployeeBtn.TabIndex = 2;
            EditEmployeeBtn.Text = "Edit Employee  ";
            EditEmployeeBtn.TextAlign = ContentAlignment.MiddleRight;
            EditEmployeeBtn.UseVisualStyleBackColor = true;
            EditEmployeeBtn.Click += EditEmployeeBtn_Click;
            // 
            // DeleteEmployeeBtn
            // 
            DeleteEmployeeBtn.Image = Properties.Resources.user_minus;
            DeleteEmployeeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            DeleteEmployeeBtn.Location = new Point(282, 67);
            DeleteEmployeeBtn.Name = "DeleteEmployeeBtn";
            DeleteEmployeeBtn.Size = new Size(129, 35);
            DeleteEmployeeBtn.TabIndex = 3;
            DeleteEmployeeBtn.Text = "Delete Employee";
            DeleteEmployeeBtn.TextAlign = ContentAlignment.MiddleRight;
            DeleteEmployeeBtn.UseVisualStyleBackColor = true;
            DeleteEmployeeBtn.Click += DeleteEmployeeBtn_Click;
            // 
            // TitleLbl
            // 
            TitleLbl.AutoSize = true;
            TitleLbl.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            TitleLbl.Location = new Point(12, 28);
            TitleLbl.Name = "TitleLbl";
            TitleLbl.Size = new Size(263, 36);
            TitleLbl.TabIndex = 4;
            TitleLbl.Text = "Employees Reports";
            // 
            // EmployeeBaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 446);
            Controls.Add(TitleLbl);
            Controls.Add(DeleteEmployeeBtn);
            Controls.Add(EditEmployeeBtn);
            Controls.Add(AddEmployeeBtn);
            Controls.Add(DataTableEmployees);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EmployeeBaseForm";
            Text = "CRUD - Employees";
            ((System.ComponentModel.ISupportInitialize)DataTableEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataTableEmployees;
        private Button AddEmployeeBtn;
        private Button EditEmployeeBtn;
        private Button DeleteEmployeeBtn;
        private Label TitleLbl;
    }
}
