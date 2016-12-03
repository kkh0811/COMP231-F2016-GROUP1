namespace PasswordApplication
{
    partial class EditRecordForm
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
            this.components = new System.ComponentModel.Container();
            this.CreateNewRecordLabel = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ServiceNameTextBox = new System.Windows.Forms.TextBox();
            this.ShowPasswordChkBox = new System.Windows.Forms.CheckBox();
            this.GeneratePwButton = new System.Windows.Forms.Button();
            this.GenerateNewCateButton = new System.Windows.Forms.Button();
            this.VerifyPasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.NoteTextBox = new System.Windows.Forms.TextBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.CategoryOptionComboBox = new System.Windows.Forms.ComboBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveNewRecordButton = new System.Windows.Forms.Button();
            this.NoteLabel = new System.Windows.Forms.Label();
            this.VerifyPwLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateNewRecordLabel
            // 
            this.CreateNewRecordLabel.AutoSize = true;
            this.CreateNewRecordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateNewRecordLabel.Location = new System.Drawing.Point(54, 37);
            this.CreateNewRecordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CreateNewRecordLabel.Name = "CreateNewRecordLabel";
            this.CreateNewRecordLabel.Size = new System.Drawing.Size(146, 29);
            this.CreateNewRecordLabel.TabIndex = 16;
            this.CreateNewRecordLabel.Text = "Edit Record:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 303);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Service Name:";
            // 
            // ServiceNameTextBox
            // 
            this.ServiceNameTextBox.CausesValidation = false;
            this.ServiceNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceNameTextBox.Location = new System.Drawing.Point(246, 303);
            this.ServiceNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ServiceNameTextBox.MaxLength = 30;
            this.ServiceNameTextBox.Name = "ServiceNameTextBox";
            this.ServiceNameTextBox.Size = new System.Drawing.Size(237, 30);
            this.ServiceNameTextBox.TabIndex = 30;
            // 
            // ShowPasswordChkBox
            // 
            this.ShowPasswordChkBox.AutoSize = true;
            this.ShowPasswordChkBox.Location = new System.Drawing.Point(521, 266);
            this.ShowPasswordChkBox.Name = "ShowPasswordChkBox";
            this.ShowPasswordChkBox.Size = new System.Drawing.Size(64, 21);
            this.ShowPasswordChkBox.TabIndex = 34;
            this.ShowPasswordChkBox.Text = "Show";
            this.ShowPasswordChkBox.UseVisualStyleBackColor = true;
            this.ShowPasswordChkBox.CheckedChanged += new System.EventHandler(this.ShowPasswordChkBox_CheckedChanged);
            // 
            // GeneratePwButton
            // 
            this.GeneratePwButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneratePwButton.Location = new System.Drawing.Point(505, 203);
            this.GeneratePwButton.Margin = new System.Windows.Forms.Padding(4);
            this.GeneratePwButton.Name = "GeneratePwButton";
            this.GeneratePwButton.Size = new System.Drawing.Size(171, 34);
            this.GeneratePwButton.TabIndex = 33;
            this.GeneratePwButton.Text = "Generate Password";
            this.GeneratePwButton.UseVisualStyleBackColor = true;
            // 
            // GenerateNewCateButton
            // 
            this.GenerateNewCateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateNewCateButton.Location = new System.Drawing.Point(505, 100);
            this.GenerateNewCateButton.Margin = new System.Windows.Forms.Padding(4);
            this.GenerateNewCateButton.Name = "GenerateNewCateButton";
            this.GenerateNewCateButton.Size = new System.Drawing.Size(129, 34);
            this.GenerateNewCateButton.TabIndex = 32;
            this.GenerateNewCateButton.Text = "New Category";
            this.GenerateNewCateButton.UseVisualStyleBackColor = true;
            // 
            // VerifyPasswordTextBox
            // 
            this.VerifyPasswordTextBox.CausesValidation = false;
            this.VerifyPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerifyPasswordTextBox.Location = new System.Drawing.Point(246, 257);
            this.VerifyPasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.VerifyPasswordTextBox.MaxLength = 29;
            this.VerifyPasswordTextBox.Name = "VerifyPasswordTextBox";
            this.VerifyPasswordTextBox.PasswordChar = '*';
            this.VerifyPasswordTextBox.Size = new System.Drawing.Size(237, 30);
            this.VerifyPasswordTextBox.TabIndex = 29;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.CausesValidation = false;
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(248, 203);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTextBox.MaxLength = 29;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(236, 30);
            this.PasswordTextBox.TabIndex = 28;
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteTextBox.Location = new System.Drawing.Point(248, 358);
            this.NoteTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NoteTextBox.MaxLength = 255;
            this.NoteTextBox.Multiline = true;
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.Size = new System.Drawing.Size(427, 155);
            this.NoteTextBox.TabIndex = 31;
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.CausesValidation = false;
            this.UserNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTextBox.Location = new System.Drawing.Point(248, 150);
            this.UserNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.UserNameTextBox.MaxLength = 29;
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(236, 30);
            this.UserNameTextBox.TabIndex = 27;
            // 
            // CategoryOptionComboBox
            // 
            this.CategoryOptionComboBox.CausesValidation = false;
            this.CategoryOptionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryOptionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryOptionComboBox.FormattingEnabled = true;
            this.CategoryOptionComboBox.Items.AddRange(new object[] {
            "--Select One--"});
            this.CategoryOptionComboBox.Location = new System.Drawing.Point(248, 100);
            this.CategoryOptionComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.CategoryOptionComboBox.Name = "CategoryOptionComboBox";
            this.CategoryOptionComboBox.Size = new System.Drawing.Size(236, 33);
            this.CategoryOptionComboBox.TabIndex = 26;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(434, 556);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(109, 34);
            this.CancelButton.TabIndex = 25;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveNewRecordButton
            // 
            this.SaveNewRecordButton.CausesValidation = false;
            this.SaveNewRecordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveNewRecordButton.Location = new System.Drawing.Point(247, 556);
            this.SaveNewRecordButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveNewRecordButton.Name = "SaveNewRecordButton";
            this.SaveNewRecordButton.Size = new System.Drawing.Size(121, 34);
            this.SaveNewRecordButton.TabIndex = 24;
            this.SaveNewRecordButton.Text = "Save";
            this.SaveNewRecordButton.UseVisualStyleBackColor = true;
            this.SaveNewRecordButton.Click += new System.EventHandler(this.SaveNewRecordButton_Click);
            // 
            // NoteLabel
            // 
            this.NoteLabel.AutoSize = true;
            this.NoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteLabel.Location = new System.Drawing.Point(176, 358);
            this.NoteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NoteLabel.Name = "NoteLabel";
            this.NoteLabel.Size = new System.Drawing.Size(59, 25);
            this.NoteLabel.TabIndex = 23;
            this.NoteLabel.Text = "Note:";
            // 
            // VerifyPwLabel
            // 
            this.VerifyPwLabel.AutoSize = true;
            this.VerifyPwLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerifyPwLabel.Location = new System.Drawing.Point(70, 255);
            this.VerifyPwLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VerifyPwLabel.Name = "VerifyPwLabel";
            this.VerifyPwLabel.Size = new System.Drawing.Size(159, 25);
            this.VerifyPwLabel.TabIndex = 22;
            this.VerifyPwLabel.Text = "Verify Password:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(129, 203);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(104, 25);
            this.PasswordLabel.TabIndex = 21;
            this.PasswordLabel.Text = "Password:";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(114, 151);
            this.UserNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(116, 25);
            this.UserNameLabel.TabIndex = 20;
            this.UserNameLabel.Text = "User Name:";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLabel.Location = new System.Drawing.Point(136, 100);
            this.CategoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(98, 25);
            this.CategoryLabel.TabIndex = 19;
            this.CategoryLabel.Text = "Category:";
            // 
            // EditRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 618);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ServiceNameTextBox);
            this.Controls.Add(this.ShowPasswordChkBox);
            this.Controls.Add(this.GeneratePwButton);
            this.Controls.Add(this.GenerateNewCateButton);
            this.Controls.Add(this.VerifyPasswordTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.NoteTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.CategoryOptionComboBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveNewRecordButton);
            this.Controls.Add(this.NoteLabel);
            this.Controls.Add(this.VerifyPwLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.CreateNewRecordLabel);
            this.Name = "EditRecordForm";
            this.Text = "EditRecordForm";
            this.Load += new System.EventHandler(this.EditRecordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CreateNewRecordLabel;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ServiceNameTextBox;
        private System.Windows.Forms.CheckBox ShowPasswordChkBox;
        private System.Windows.Forms.Button GeneratePwButton;
        private System.Windows.Forms.Button GenerateNewCateButton;
        private System.Windows.Forms.TextBox VerifyPasswordTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox NoteTextBox;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.ComboBox CategoryOptionComboBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveNewRecordButton;
        private System.Windows.Forms.Label NoteLabel;
        private System.Windows.Forms.Label VerifyPwLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label CategoryLabel;
    }
}