namespace PasswordApplication
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Category");
            this.CategoryFlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.CategoryTreeView = new System.Windows.Forms.TreeView();
            this.InteractCategoryPanel = new System.Windows.Forms.Panel();
            this.sepLinelabel2 = new System.Windows.Forms.Label();
            this.DeleteCategoryButton = new System.Windows.Forms.Button();
            this.EditCategoetButton = new System.Windows.Forms.Button();
            this.AddCategoryButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.userRecordDataGridView = new System.Windows.Forms.DataGridView();
            this.UserRightClickContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.InteractRecordPanel = new System.Windows.Forms.Panel();
            this.sepLinelabel1 = new System.Windows.Forms.Label();
            this.ViewRecordButton = new System.Windows.Forms.Button();
            this.DeleteRecordButton = new System.Windows.Forms.Button();
            this.EditRecordButton = new System.Windows.Forms.Button();
            this.NewRecordButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userRecorsDataGripToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.CategoryFlowLayoutPanel1.SuspendLayout();
            this.InteractCategoryPanel.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userRecordDataGridView)).BeginInit();
            this.UserRightClickContextMenuStrip.SuspendLayout();
            this.InteractRecordPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CategoryFlowLayoutPanel1
            // 
            this.CategoryFlowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.CategoryFlowLayoutPanel1.Controls.Add(this.CategoryTreeView);
            this.CategoryFlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.CategoryFlowLayoutPanel1.Location = new System.Drawing.Point(0, 26);
            this.CategoryFlowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.CategoryFlowLayoutPanel1.Name = "CategoryFlowLayoutPanel1";
            this.CategoryFlowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CategoryFlowLayoutPanel1.Size = new System.Drawing.Size(196, 440);
            this.CategoryFlowLayoutPanel1.TabIndex = 1;
            // 
            // CategoryTreeView
            // 
            this.CategoryTreeView.BackColor = System.Drawing.SystemColors.Control;
            this.CategoryTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategoryTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryTreeView.ForeColor = System.Drawing.SystemColors.InfoText;
            this.CategoryTreeView.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CategoryTreeView.Location = new System.Drawing.Point(0, 8);
            this.CategoryTreeView.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.CategoryTreeView.Name = "CategoryTreeView";
            treeNode2.Name = "CategoryRoot";
            treeNode2.Text = "Category";
            this.CategoryTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.CategoryTreeView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CategoryTreeView.Size = new System.Drawing.Size(192, 433);
            this.CategoryTreeView.TabIndex = 1;
            this.CategoryTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.CategoryTreeView_NodeMouseClick_1);
            this.CategoryTreeView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.stopTreeViewSound);
            // 
            // InteractCategoryPanel
            // 
            this.InteractCategoryPanel.BackColor = System.Drawing.SystemColors.Control;
            this.InteractCategoryPanel.Controls.Add(this.sepLinelabel2);
            this.InteractCategoryPanel.Controls.Add(this.DeleteCategoryButton);
            this.InteractCategoryPanel.Controls.Add(this.EditCategoetButton);
            this.InteractCategoryPanel.Controls.Add(this.AddCategoryButton);
            this.InteractCategoryPanel.Location = new System.Drawing.Point(0, 465);
            this.InteractCategoryPanel.Name = "InteractCategoryPanel";
            this.InteractCategoryPanel.Size = new System.Drawing.Size(196, 145);
            this.InteractCategoryPanel.TabIndex = 2;
            // 
            // sepLinelabel2
            // 
            this.sepLinelabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sepLinelabel2.Location = new System.Drawing.Point(7, -1);
            this.sepLinelabel2.Name = "sepLinelabel2";
            this.sepLinelabel2.Size = new System.Drawing.Size(180, 2);
            this.sepLinelabel2.TabIndex = 3;
            this.sepLinelabel2.Text = "label2";
            // 
            // DeleteCategoryButton
            // 
            this.DeleteCategoryButton.BackColor = System.Drawing.Color.White;
            this.DeleteCategoryButton.FlatAppearance.BorderSize = 0;
            this.DeleteCategoryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(222)))), ((int)(((byte)(19)))));
            this.DeleteCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DeleteCategoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteCategoryButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(206)))), ((int)(((byte)(91)))));
            this.DeleteCategoryButton.Location = new System.Drawing.Point(12, 99);
            this.DeleteCategoryButton.Name = "DeleteCategoryButton";
            this.DeleteCategoryButton.Size = new System.Drawing.Size(131, 34);
            this.DeleteCategoryButton.TabIndex = 2;
            this.DeleteCategoryButton.Text = "Delete Category";
            this.DeleteCategoryButton.UseVisualStyleBackColor = false;
            this.DeleteCategoryButton.Click += new System.EventHandler(this.DeleteCategoryButton_Click);
            // 
            // EditCategoetButton
            // 
            this.EditCategoetButton.BackColor = System.Drawing.Color.White;
            this.EditCategoetButton.FlatAppearance.BorderSize = 0;
            this.EditCategoetButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(222)))), ((int)(((byte)(19)))));
            this.EditCategoetButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.EditCategoetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditCategoetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(206)))), ((int)(((byte)(91)))));
            this.EditCategoetButton.Location = new System.Drawing.Point(12, 56);
            this.EditCategoetButton.Name = "EditCategoetButton";
            this.EditCategoetButton.Size = new System.Drawing.Size(112, 34);
            this.EditCategoetButton.TabIndex = 1;
            this.EditCategoetButton.Text = "Edit Category";
            this.EditCategoetButton.UseVisualStyleBackColor = false;
            this.EditCategoetButton.Click += new System.EventHandler(this.EditCategoetButton_Click);
            // 
            // AddCategoryButton
            // 
            this.AddCategoryButton.BackColor = System.Drawing.Color.White;
            this.AddCategoryButton.FlatAppearance.BorderSize = 0;
            this.AddCategoryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(222)))), ((int)(((byte)(19)))));
            this.AddCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AddCategoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCategoryButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(206)))), ((int)(((byte)(91)))));
            this.AddCategoryButton.Location = new System.Drawing.Point(12, 14);
            this.AddCategoryButton.Name = "AddCategoryButton";
            this.AddCategoryButton.Size = new System.Drawing.Size(112, 34);
            this.AddCategoryButton.TabIndex = 0;
            this.AddCategoryButton.Text = "Add Category";
            this.AddCategoryButton.UseVisualStyleBackColor = false;
            this.AddCategoryButton.Click += new System.EventHandler(this.AddCategoryButton_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel2.Controls.Add(this.userRecordDataGridView);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(195, 26);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(433, 441);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // userRecordDataGridView
            // 
            this.userRecordDataGridView.AllowUserToAddRows = false;
            this.userRecordDataGridView.AllowUserToDeleteRows = false;
            this.userRecordDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userRecordDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.userRecordDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userRecordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userRecordDataGridView.ContextMenuStrip = this.UserRightClickContextMenuStrip;
            this.userRecordDataGridView.Location = new System.Drawing.Point(0, 0);
            this.userRecordDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.userRecordDataGridView.Name = "userRecordDataGridView";
            this.userRecordDataGridView.ReadOnly = true;
            this.userRecordDataGridView.Size = new System.Drawing.Size(398, 439);
            this.userRecordDataGridView.TabIndex = 0;
            this.userRecorsDataGripToolTip.SetToolTip(this.userRecordDataGridView, "Click the cooresponding cell to copy the user name or password");
            this.userRecordDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.userRecordDataGridView_CellFormatting);
            this.userRecordDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CopyPaste_Click);
            this.userRecordDataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.userRecordDataGridView_MouseDown);
            // 
            // UserRightClickContextMenuStrip
            // 
            this.UserRightClickContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.UserRightClickContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.deleteToolStripMenuItem1,
            this.editToolStripMenuItem1,
            this.viewToolStripMenuItem1});
            this.UserRightClickContextMenuStrip.Name = "UserRightClickContextMenuStrip";
            this.UserRightClickContextMenuStrip.Size = new System.Drawing.Size(129, 108);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.newToolStripMenuItem.Text = "View";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(128, 26);
            this.deleteToolStripMenuItem1.Text = "Edit";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.editTollStripMenuItem_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(128, 26);
            this.editToolStripMenuItem1.Text = "Delete";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.deleteTollStripMenuItem_Click);
            // 
            // viewToolStripMenuItem1
            // 
            this.viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            this.viewToolStripMenuItem1.Size = new System.Drawing.Size(128, 26);
            this.viewToolStripMenuItem1.Text = "New";
            this.viewToolStripMenuItem1.Click += new System.EventHandler(this.newTollStripMenuItem_Clic);
            // 
            // InteractRecordPanel
            // 
            this.InteractRecordPanel.BackColor = System.Drawing.SystemColors.Control;
            this.InteractRecordPanel.Controls.Add(this.sepLinelabel1);
            this.InteractRecordPanel.Controls.Add(this.ViewRecordButton);
            this.InteractRecordPanel.Controls.Add(this.DeleteRecordButton);
            this.InteractRecordPanel.Controls.Add(this.EditRecordButton);
            this.InteractRecordPanel.Controls.Add(this.NewRecordButton);
            this.InteractRecordPanel.Location = new System.Drawing.Point(260, 572);
            this.InteractRecordPanel.Margin = new System.Windows.Forms.Padding(4);
            this.InteractRecordPanel.Name = "InteractRecordPanel";
            this.InteractRecordPanel.Size = new System.Drawing.Size(577, 178);
            this.InteractRecordPanel.TabIndex = 4;
            // 
            // sepLinelabel1
            // 
            this.sepLinelabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sepLinelabel1.Location = new System.Drawing.Point(4, 0);
            this.sepLinelabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sepLinelabel1.Name = "sepLinelabel1";
            this.sepLinelabel1.Size = new System.Drawing.Size(493, 2);
            this.sepLinelabel1.TabIndex = 0;
            this.sepLinelabel1.Text = "label1";
            // 
            // ViewRecordButton
            // 
            this.ViewRecordButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ViewRecordButton.Location = new System.Drawing.Point(373, 18);
            this.ViewRecordButton.Margin = new System.Windows.Forms.Padding(4);
            this.ViewRecordButton.Name = "ViewRecordButton";
            this.ViewRecordButton.Size = new System.Drawing.Size(100, 33);
            this.ViewRecordButton.TabIndex = 3;
            this.ViewRecordButton.Text = "View Record";
            this.ViewRecordButton.UseVisualStyleBackColor = true;
            this.ViewRecordButton.Click += new System.EventHandler(this.ViewRecordButton_Click);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DeleteRecordButton.Location = new System.Drawing.Point(257, 18);
            this.DeleteRecordButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteRecordButton.Name = "DeleteRecordButton";
            this.DeleteRecordButton.Size = new System.Drawing.Size(100, 33);
            this.DeleteRecordButton.TabIndex = 2;
            this.DeleteRecordButton.Text = "Delete Record";
            this.DeleteRecordButton.UseVisualStyleBackColor = true;
            this.DeleteRecordButton.Click += new System.EventHandler(this.DeleteRecordButton_Click);
            // 
            // EditRecordButton
            // 
            this.EditRecordButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.EditRecordButton.Location = new System.Drawing.Point(141, 18);
            this.EditRecordButton.Margin = new System.Windows.Forms.Padding(4);
            this.EditRecordButton.Name = "EditRecordButton";
            this.EditRecordButton.Size = new System.Drawing.Size(100, 33);
            this.EditRecordButton.TabIndex = 1;
            this.EditRecordButton.Text = "Edit Record";
            this.EditRecordButton.UseVisualStyleBackColor = true;
            this.EditRecordButton.Click += new System.EventHandler(this.EditRecordButton_Click);
            // 
            // NewRecordButton
            // 
            this.NewRecordButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.NewRecordButton.Location = new System.Drawing.Point(25, 18);
            this.NewRecordButton.Margin = new System.Windows.Forms.Padding(4);
            this.NewRecordButton.Name = "NewRecordButton";
            this.NewRecordButton.Size = new System.Drawing.Size(100, 33);
            this.NewRecordButton.TabIndex = 0;
            this.NewRecordButton.Text = "New Record";
            this.NewRecordButton.UseVisualStyleBackColor = true;
            this.NewRecordButton.Click += new System.EventHandler(this.NewRecordButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.accountToolStripMenuItem,
            this.configToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(835, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.editToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.configToolStripMenuItem.Text = "Config";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // userRecorsDataGripToolTip
            // 
            this.userRecorsDataGripToolTip.AutomaticDelay = 100;
            this.userRecorsDataGripToolTip.AutoPopDelay = 2000;
            this.userRecorsDataGripToolTip.InitialDelay = 100;
            this.userRecorsDataGripToolTip.ReshowDelay = 20;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(835, 751);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.InteractRecordPanel);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.InteractCategoryPanel);
            this.Controls.Add(this.CategoryFlowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Password App";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.CategoryFlowLayoutPanel1.ResumeLayout(false);
            this.InteractCategoryPanel.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userRecordDataGridView)).EndInit();
            this.UserRightClickContextMenuStrip.ResumeLayout(false);
            this.InteractRecordPanel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel CategoryFlowLayoutPanel1;
        private System.Windows.Forms.Panel InteractCategoryPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel InteractRecordPanel;
        private System.Windows.Forms.TreeView CategoryTreeView;
        private System.Windows.Forms.Button DeleteCategoryButton;
        private System.Windows.Forms.Button EditCategoetButton;
        private System.Windows.Forms.Button AddCategoryButton;
        private System.Windows.Forms.Button ViewRecordButton;
        private System.Windows.Forms.Button DeleteRecordButton;
        private System.Windows.Forms.Button EditRecordButton;
        private System.Windows.Forms.Button NewRecordButton;
        private System.Windows.Forms.Label sepLinelabel1;
        private System.Windows.Forms.DataGridView userRecordDataGridView;
        private System.Windows.Forms.Label sepLinelabel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolTip userRecorsDataGripToolTip;
        private System.Windows.Forms.ContextMenuStrip UserRightClickContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem1;
    }
}

