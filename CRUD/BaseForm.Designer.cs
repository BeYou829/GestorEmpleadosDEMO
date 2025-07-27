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
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EditEmployeeBtn);
            Controls.Add(AddEmployeeBtn);
            Controls.Add(dataTable);
            Name = "BaseForm";
            Text = "CRUD - Employees";
            ((System.ComponentModel.ISupportInitialize)dataTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataTable;
        private Button AddEmployeeBtn;
        private Button EditEmployeeBtn;
    }
}
