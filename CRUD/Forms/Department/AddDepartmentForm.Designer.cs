namespace CRUD.Forms.Department
{
    partial class AddDepartmentForm
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
            NameLbl = new Label();
            TextBoxName = new TextBox();
            DescriptionLbl = new Label();
            TextBoxDescription = new TextBox();
            CancelBtn = new Button();
            SaveBtn = new Button();
            SuspendLayout();
            // 
            // NameLbl
            // 
            NameLbl.AutoSize = true;
            NameLbl.Location = new Point(12, 40);
            NameLbl.Name = "NameLbl";
            NameLbl.Size = new Size(39, 15);
            NameLbl.TabIndex = 0;
            NameLbl.Text = "Name";
            // 
            // TextBoxName
            // 
            TextBoxName.Location = new Point(86, 37);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(163, 23);
            TextBoxName.TabIndex = 1;
            // 
            // DescriptionLbl
            // 
            DescriptionLbl.AutoSize = true;
            DescriptionLbl.Location = new Point(13, 76);
            DescriptionLbl.Name = "DescriptionLbl";
            DescriptionLbl.Size = new Size(67, 15);
            DescriptionLbl.TabIndex = 2;
            DescriptionLbl.Text = "Description";
            // 
            // TextBoxDescription
            // 
            TextBoxDescription.AcceptsReturn = true;
            TextBoxDescription.Location = new Point(86, 73);
            TextBoxDescription.Multiline = true;
            TextBoxDescription.Name = "TextBoxDescription";
            TextBoxDescription.Size = new Size(172, 93);
            TextBoxDescription.TabIndex = 3;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(293, 204);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(75, 23);
            CancelBtn.TabIndex = 5;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(374, 204);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(75, 23);
            SaveBtn.TabIndex = 4;
            SaveBtn.Text = "Save Changes";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // AddDepartmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 257);
            Controls.Add(CancelBtn);
            Controls.Add(SaveBtn);
            Controls.Add(TextBoxDescription);
            Controls.Add(DescriptionLbl);
            Controls.Add(TextBoxName);
            Controls.Add(NameLbl);
            Name = "AddDepartmentForm";
            Text = "Add a new Department";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameLbl;
        private TextBox TextBoxName;
        private Label DescriptionLbl;
        private TextBox TextBoxDescription;
        private Button CancelBtn;
        private Button SaveBtn;
    }
}