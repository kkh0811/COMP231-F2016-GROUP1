namespace PasswordApplication
{
    partial class ManupulateCategoryForm
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
            this.manupulateCategoryLabel = new System.Windows.Forms.Label();
            this.CategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.SaveNewCategoryButton = new System.Windows.Forms.Button();
            this.cancelAddCatrgoryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manupulateCategoryLabel
            // 
            this.manupulateCategoryLabel.AutoSize = true;
            this.manupulateCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manupulateCategoryLabel.Location = new System.Drawing.Point(12, 32);
            this.manupulateCategoryLabel.Name = "manupulateCategoryLabel";
            this.manupulateCategoryLabel.Size = new System.Drawing.Size(194, 24);
            this.manupulateCategoryLabel.TabIndex = 1;
            this.manupulateCategoryLabel.Text = "Create New Category:";
            // 
            // CategoryNameTextBox
            // 
            this.CategoryNameTextBox.CausesValidation = false;
            this.CategoryNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryNameTextBox.Location = new System.Drawing.Point(179, 87);
            this.CategoryNameTextBox.MaxLength = 30;
            this.CategoryNameTextBox.Name = "CategoryNameTextBox";
            this.CategoryNameTextBox.Size = new System.Drawing.Size(178, 26);
            this.CategoryNameTextBox.TabIndex = 1;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(50, 87);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(123, 20);
            this.UserNameLabel.TabIndex = 10;
            this.UserNameLabel.Text = "Category Name:";
            // 
            // SaveNewCategoryButton
            // 
            this.SaveNewCategoryButton.CausesValidation = false;
            this.SaveNewCategoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveNewCategoryButton.Location = new System.Drawing.Point(82, 187);
            this.SaveNewCategoryButton.Name = "SaveNewCategoryButton";
            this.SaveNewCategoryButton.Size = new System.Drawing.Size(91, 28);
            this.SaveNewCategoryButton.TabIndex = 2;
            this.SaveNewCategoryButton.Text = "Save";
            this.SaveNewCategoryButton.UseVisualStyleBackColor = true;
            this.SaveNewCategoryButton.Click += new System.EventHandler(this.SaveNewCategoryButton_Click);
            // 
            // cancelAddCatrgoryButton
            // 
            this.cancelAddCatrgoryButton.CausesValidation = false;
            this.cancelAddCatrgoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelAddCatrgoryButton.Location = new System.Drawing.Point(226, 187);
            this.cancelAddCatrgoryButton.Name = "cancelAddCatrgoryButton";
            this.cancelAddCatrgoryButton.Size = new System.Drawing.Size(91, 28);
            this.cancelAddCatrgoryButton.TabIndex = 3;
            this.cancelAddCatrgoryButton.Text = "Cancel";
            this.cancelAddCatrgoryButton.UseVisualStyleBackColor = true;
            this.cancelAddCatrgoryButton.Click += new System.EventHandler(this.cancelAddCatrgoryButton_Click);
            // 
            // ManupulateCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 261);
            this.Controls.Add(this.cancelAddCatrgoryButton);
            this.Controls.Add(this.SaveNewCategoryButton);
            this.Controls.Add(this.CategoryNameTextBox);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.manupulateCategoryLabel);
            this.Name = "ManupulateCategoryForm";
            this.Text = "Create New Category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label manupulateCategoryLabel;
        private System.Windows.Forms.TextBox CategoryNameTextBox;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Button SaveNewCategoryButton;
        private System.Windows.Forms.Button cancelAddCatrgoryButton;
    }
}