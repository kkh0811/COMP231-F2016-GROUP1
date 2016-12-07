namespace PasswordApplication
{
    partial class ViewRecordForm
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
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.NoteLabel = new System.Windows.Forms.Label();
            this.EditRecordButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.CategoryOptionComboBox = new System.Windows.Forms.ComboBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.NoteTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ServiceNameTextBox = new System.Windows.Forms.TextBox();
            this.ShowChkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLabel.Location = new System.Drawing.Point(116, 73);
            this.CategoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(98, 25);
            this.CategoryLabel.TabIndex = 16;
            this.CategoryLabel.Text = "Category:";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(94, 124);
            this.UserNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(116, 25);
            this.UserNameLabel.TabIndex = 17;
            this.UserNameLabel.Text = "User Name:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(109, 176);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(104, 25);
            this.PasswordLabel.TabIndex = 18;
            this.PasswordLabel.Text = "Password:";
            // 
            // NoteLabel
            // 
            this.NoteLabel.AutoSize = true;
            this.NoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteLabel.Location = new System.Drawing.Point(151, 280);
            this.NoteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NoteLabel.Name = "NoteLabel";
            this.NoteLabel.Size = new System.Drawing.Size(59, 25);
            this.NoteLabel.TabIndex = 20;
            this.NoteLabel.Text = "Note:";
            // 
            // EditRecordButton
            // 
            this.EditRecordButton.CausesValidation = false;
            this.EditRecordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditRecordButton.Location = new System.Drawing.Point(226, 490);
            this.EditRecordButton.Margin = new System.Windows.Forms.Padding(4);
            this.EditRecordButton.Name = "EditRecordButton";
            this.EditRecordButton.Size = new System.Drawing.Size(121, 34);
            this.EditRecordButton.TabIndex = 21;
            this.EditRecordButton.Text = "Edit";
            this.EditRecordButton.UseVisualStyleBackColor = true;
            this.EditRecordButton.Click += new System.EventHandler(this.EditRecordButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkButton.Location = new System.Drawing.Point(413, 490);
            this.OkButton.Margin = new System.Windows.Forms.Padding(4);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(109, 34);
            this.OkButton.TabIndex = 22;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CategoryOptionComboBox
            // 
            this.CategoryOptionComboBox.CausesValidation = false;
            this.CategoryOptionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryOptionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryOptionComboBox.FormattingEnabled = true;
            this.CategoryOptionComboBox.Location = new System.Drawing.Point(228, 73);
            this.CategoryOptionComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.CategoryOptionComboBox.Name = "CategoryOptionComboBox";
            this.CategoryOptionComboBox.Size = new System.Drawing.Size(341, 33);
            this.CategoryOptionComboBox.TabIndex = 23;
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.CausesValidation = false;
            this.UserNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTextBox.Location = new System.Drawing.Point(228, 123);
            this.UserNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.ReadOnly = true;
            this.UserNameTextBox.Size = new System.Drawing.Size(341, 30);
            this.UserNameTextBox.TabIndex = 24;
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteTextBox.Location = new System.Drawing.Point(226, 280);
            this.NoteTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NoteTextBox.Multiline = true;
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.ReadOnly = true;
            this.NoteTextBox.Size = new System.Drawing.Size(343, 155);
            this.NoteTextBox.TabIndex = 27;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.CausesValidation = false;
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(228, 176);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.ReadOnly = true;
            this.PasswordTextBox.Size = new System.Drawing.Size(341, 30);
            this.PasswordTextBox.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 224);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Service Name:";
            // 
            // ServiceNameTextBox
            // 
            this.ServiceNameTextBox.CausesValidation = false;
            this.ServiceNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceNameTextBox.Location = new System.Drawing.Point(228, 224);
            this.ServiceNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ServiceNameTextBox.Name = "ServiceNameTextBox";
            this.ServiceNameTextBox.ReadOnly = true;
            this.ServiceNameTextBox.Size = new System.Drawing.Size(341, 30);
            this.ServiceNameTextBox.TabIndex = 24;
            // 
            // ShowChkBox
            // 
            this.ShowChkBox.AutoSize = true;
            this.ShowChkBox.Location = new System.Drawing.Point(596, 185);
            this.ShowChkBox.Name = "ShowChkBox";
            this.ShowChkBox.Size = new System.Drawing.Size(64, 21);
            this.ShowChkBox.TabIndex = 28;
            this.ShowChkBox.Text = "Show";
            this.ShowChkBox.UseVisualStyleBackColor = true;
            this.ShowChkBox.CheckedChanged += new System.EventHandler(this.ShowChkBox_CheckedChanged);
            // 
            // ViewRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 597);
            this.Controls.Add(this.ShowChkBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.NoteTextBox);
            this.Controls.Add(this.ServiceNameTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.CategoryOptionComboBox);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.EditRecordButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NoteLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Name = "ViewRecordForm";
            this.Text = "ViewRecordForm";
            this.Load += new System.EventHandler(this.ViewRecordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label NoteLabel;
        private System.Windows.Forms.Button EditRecordButton;
        private System.Windows.Forms.Button OkButton;
        public System.Windows.Forms.ComboBox CategoryOptionComboBox;
        public System.Windows.Forms.TextBox UserNameTextBox;
        public System.Windows.Forms.TextBox NoteTextBox;
        public System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox ServiceNameTextBox;
        private System.Windows.Forms.CheckBox ShowChkBox;
    }
}