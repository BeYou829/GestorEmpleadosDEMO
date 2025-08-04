namespace CRUD.Forms.Department
{
    partial class DepartmentBaseForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            TitleLbl = new Label();
            DeleteDepartmentBtn = new Button();
            EditDepartmentBtn = new Button();
            AddDepartmentBtn = new Button();
            DataTableDepartments = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DataTableDepartments).BeginInit();
            SuspendLayout();
            // 
            // TitleLbl
            // 
            TitleLbl.AutoSize = true;
            TitleLbl.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            TitleLbl.Location = new Point(12, 18);
            TitleLbl.Name = "TitleLbl";
            TitleLbl.Size = new Size(289, 36);
            TitleLbl.TabIndex = 9;
            TitleLbl.Text = "Departments Reports";
            // 
            // DeleteDepartmentBtn
            // 
            DeleteDepartmentBtn.Image = Properties.Resources.user_minus;
            DeleteDepartmentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            DeleteDepartmentBtn.Location = new Point(282, 57);
            DeleteDepartmentBtn.Name = "DeleteDepartmentBtn";
            DeleteDepartmentBtn.Size = new Size(140, 35);
            DeleteDepartmentBtn.TabIndex = 8;
            DeleteDepartmentBtn.Text = "Delete Department";
            DeleteDepartmentBtn.TextAlign = ContentAlignment.MiddleRight;
            DeleteDepartmentBtn.UseVisualStyleBackColor = true;
            DeleteDepartmentBtn.Click += DeleteDepartmentBtn_Click;
            // 
            // EditDepartmentBtn
            // 
            EditDepartmentBtn.Image = Properties.Resources.user_pen;
            EditDepartmentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            EditDepartmentBtn.Location = new Point(147, 57);
            EditDepartmentBtn.Name = "EditDepartmentBtn";
            EditDepartmentBtn.Size = new Size(129, 35);
            EditDepartmentBtn.TabIndex = 7;
            EditDepartmentBtn.Text = "Edit Department";
            EditDepartmentBtn.TextAlign = ContentAlignment.MiddleRight;
            EditDepartmentBtn.UseVisualStyleBackColor = true;
            EditDepartmentBtn.Click += EditDepartmentBtn_Click;
            // 
            // AddDepartmentBtn
            // 
            AddDepartmentBtn.Image = Properties.Resources.user_plus;
            AddDepartmentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            AddDepartmentBtn.Location = new Point(12, 57);
            AddDepartmentBtn.Name = "AddDepartmentBtn";
            AddDepartmentBtn.Size = new Size(129, 35);
            AddDepartmentBtn.TabIndex = 6;
            AddDepartmentBtn.Text = "Add Department";
            AddDepartmentBtn.TextAlign = ContentAlignment.MiddleRight;
            AddDepartmentBtn.UseVisualStyleBackColor = true;
            AddDepartmentBtn.Click += AddDepartmentBtn_Click;
            // 
            // DataTableDepartments
            // 
            DataTableDepartments.AllowUserToAddRows = false;
            DataTableDepartments.AllowUserToDeleteRows = false;
            DataTableDepartments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataTableDepartments.BackgroundColor = SystemColors.ButtonShadow;
            DataTableDepartments.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataTableDepartments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataTableDepartments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataTableDepartments.Location = new Point(12, 98);
            DataTableDepartments.MultiSelect = false;
            DataTableDepartments.Name = "DataTableDepartments";
            DataTableDepartments.ReadOnly = true;
            DataTableDepartments.Size = new Size(722, 326);
            DataTableDepartments.TabIndex = 5;
            // 
            // DepartmentBaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 446);
            Controls.Add(TitleLbl);
            Controls.Add(DeleteDepartmentBtn);
            Controls.Add(EditDepartmentBtn);
            Controls.Add(AddDepartmentBtn);
            Controls.Add(DataTableDepartments);
            Name = "DepartmentBaseForm";
            Text = "DepartmentBaseForm";
            ((System.ComponentModel.ISupportInitialize)DataTableDepartments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLbl;
        private Button DeleteDepartmentBtn;
        private Button EditDepartmentBtn;
        private Button AddDepartmentBtn;
        private DataGridView DataTableDepartments;
    }
}