namespace CRUD.Forms
{
    partial class AddEmployeeForm
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
            SaveBtn = new Button();
            ClearBtn = new Button();
            TextBoxFirstName = new TextBox();
            FirstNameLbl = new Label();
            LastNameLbl = new Label();
            TextBoxLastName = new TextBox();
            PositionLbl = new Label();
            TextBoxPosition = new TextBox();
            SalaryLbl = new Label();
            TextBoxSalary = new TextBox();
            ComboBoxDepartments = new ComboBox();
            SuspendLayout();
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(374, 204);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(75, 23);
            SaveBtn.TabIndex = 0;
            SaveBtn.Text = "Save Changes";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.Location = new Point(293, 204);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(75, 23);
            ClearBtn.TabIndex = 1;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = true;
            // 
            // TextBoxFirstName
            // 
            TextBoxFirstName.Location = new Point(88, 37);
            TextBoxFirstName.Name = "TextBoxFirstName";
            TextBoxFirstName.Size = new Size(100, 23);
            TextBoxFirstName.TabIndex = 2;
            // 
            // FirstNameLbl
            // 
            FirstNameLbl.AutoSize = true;
            FirstNameLbl.Location = new Point(12, 40);
            FirstNameLbl.Name = "FirstNameLbl";
            FirstNameLbl.Size = new Size(64, 15);
            FirstNameLbl.TabIndex = 3;
            FirstNameLbl.Text = "First Name";
            // 
            // LastNameLbl
            // 
            LastNameLbl.AutoSize = true;
            LastNameLbl.Location = new Point(12, 69);
            LastNameLbl.Name = "LastNameLbl";
            LastNameLbl.Size = new Size(63, 15);
            LastNameLbl.TabIndex = 5;
            LastNameLbl.Text = "Last Name";
            // 
            // TextBoxLastName
            // 
            TextBoxLastName.Location = new Point(88, 66);
            TextBoxLastName.Name = "TextBoxLastName";
            TextBoxLastName.Size = new Size(100, 23);
            TextBoxLastName.TabIndex = 4;
            // 
            // PositionLbl
            // 
            PositionLbl.AutoSize = true;
            PositionLbl.Location = new Point(12, 98);
            PositionLbl.Name = "PositionLbl";
            PositionLbl.Size = new Size(50, 15);
            PositionLbl.TabIndex = 7;
            PositionLbl.Text = "Position";
            // 
            // TextBoxPosition
            // 
            TextBoxPosition.Location = new Point(88, 95);
            TextBoxPosition.Name = "TextBoxPosition";
            TextBoxPosition.Size = new Size(100, 23);
            TextBoxPosition.TabIndex = 6;
            // 
            // SalaryLbl
            // 
            SalaryLbl.AutoSize = true;
            SalaryLbl.Location = new Point(12, 127);
            SalaryLbl.Name = "SalaryLbl";
            SalaryLbl.Size = new Size(38, 15);
            SalaryLbl.TabIndex = 9;
            SalaryLbl.Text = "Salary";
            // 
            // TextBoxSalary
            // 
            TextBoxSalary.Location = new Point(88, 124);
            TextBoxSalary.Name = "TextBoxSalary";
            TextBoxSalary.Size = new Size(100, 23);
            TextBoxSalary.TabIndex = 8;
            // 
            // ComboBoxDepartments
            // 
            ComboBoxDepartments.DisplayMember = "Name";
            ComboBoxDepartments.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxDepartments.FormattingEnabled = true;
            ComboBoxDepartments.Location = new Point(293, 37);
            ComboBoxDepartments.Name = "ComboBoxDepartments";
            ComboBoxDepartments.Size = new Size(121, 23);
            ComboBoxDepartments.TabIndex = 10;
            ComboBoxDepartments.ValueMember = "Id";
            // 
            // AddEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 257);
            Controls.Add(ComboBoxDepartments);
            Controls.Add(SalaryLbl);
            Controls.Add(TextBoxSalary);
            Controls.Add(PositionLbl);
            Controls.Add(TextBoxPosition);
            Controls.Add(LastNameLbl);
            Controls.Add(TextBoxLastName);
            Controls.Add(FirstNameLbl);
            Controls.Add(TextBoxFirstName);
            Controls.Add(ClearBtn);
            Controls.Add(SaveBtn);
            Name = "AddEmployeeForm";
            Text = "AddEmployeeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveBtn;
        private Button ClearBtn;
        private TextBox TextBoxFirstName;
        private Label FirstNameLbl;
        private Label LastNameLbl;
        private TextBox TextBoxLastName;
        private Label PositionLbl;
        private TextBox TextBoxPosition;
        private Label SalaryLbl;
        private TextBox TextBoxSalary;
        private ComboBox ComboBoxDepartments;
    }
}