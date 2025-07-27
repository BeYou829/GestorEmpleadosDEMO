namespace CRUD
{
    partial class BaseForm
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
            dataTable = new DataGridView();
            AddEmployeeBtn = new Button();
            EditEmployeeBtn = new Button();
            DeleteEmployeeBtn = new Button();
            TitleLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)dataTable).BeginInit();
            SuspendLayout();
            // 
            // dataTable
            // 
            dataTable.AllowUserToAddRows = false;
            dataTable.AllowUserToDeleteRows = false;
            dataTable.BackgroundColor = SystemColors.ButtonShadow;
            dataTable.BorderStyle = BorderStyle.Fixed3D;
            dataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataTable.Location = new Point(45, 91);
            dataTable.MultiSelect = false;
            dataTable.Name = "dataTable";
            dataTable.ReadOnly = true;
            dataTable.Size = new Size(712, 304);
            dataTable.TabIndex = 0;
            // 
            // AddEmployeeBtn
            // 
            AddEmployeeBtn.Location = new Point(45, 62);
            AddEmployeeBtn.Name = "AddEmployeeBtn";
            AddEmployeeBtn.Size = new Size(75, 23);
            AddEmployeeBtn.TabIndex = 1;
            AddEmployeeBtn.Text = "Add Employee";
            AddEmployeeBtn.UseVisualStyleBackColor = true;
            AddEmployeeBtn.Click += AddEmployeeBtn_Click;
            // 
            // EditEmployeeBtn
            // 
            EditEmployeeBtn.Location = new Point(126, 62);
            EditEmployeeBtn.Name = "EditEmployeeBtn";
            EditEmployeeBtn.Size = new Size(75, 23);
            EditEmployeeBtn.TabIndex = 2;
            EditEmployeeBtn.Text = "Edit";
            EditEmployeeBtn.UseVisualStyleBackColor = true;
            EditEmployeeBtn.Click += EditEmployeeBtn_Click;
            // 
            // DeleteEmployeeBtn
            // 
            DeleteEmployeeBtn.Location = new Point(207, 62);
            DeleteEmployeeBtn.Name = "DeleteEmployeeBtn";
            DeleteEmployeeBtn.Size = new Size(75, 23);
            DeleteEmployeeBtn.TabIndex = 3;
            DeleteEmployeeBtn.Text = "Delete";
            DeleteEmployeeBtn.UseVisualStyleBackColor = true;
            DeleteEmployeeBtn.Click += DeleteEmployeeBtn_Click;
            // 
            // TitleLbl
            // 
            TitleLbl.AutoSize = true;
            TitleLbl.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            TitleLbl.Location = new Point(45, 11);
            TitleLbl.Name = "TitleLbl";
            TitleLbl.Size = new Size(274, 36);
            TitleLbl.TabIndex = 4;
            TitleLbl.Text = "RRHH - Employees";
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TitleLbl);
            Controls.Add(DeleteEmployeeBtn);
            Controls.Add(EditEmployeeBtn);
            Controls.Add(AddEmployeeBtn);
            Controls.Add(dataTable);
            Name = "BaseForm";
            Text = "CRUD - Employees";
            ((System.ComponentModel.ISupportInitialize)dataTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataTable;
        private Button AddEmployeeBtn;
        private Button EditEmployeeBtn;
        private Button DeleteEmployeeBtn;
        private Label TitleLbl;
    }
}
