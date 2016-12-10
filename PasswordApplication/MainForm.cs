using PasswordApplication.AbstractClass;
using PasswordApplication.Controller;
using PasswordApplication.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordApplication
{
    //Password App main screen
    public partial class MainForm : Form
    {
        //set up Database helper stuff to get Connection.
        private DatabaseHelper dbHelper = new DatabaseHelper();
        DataGridViewRow dgvr = new DataGridViewRow();

        //Trace which row User right clicked
        private DataGridViewRow userRightClickRow;
        //Trace which row user clicked
        private DataGridViewRow userCurrentClickRow;
        //User Record ID
        private int userRecordID;

        //set up sending information to other forms

        ViewRecordForm vrf = new ViewRecordForm();
        EditRecordForm edf = new EditRecordForm();

        //The category Id and Name the user is selected
        private int selectedCategoryID;
        private string selectedCategoryName;
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void NewRecordButton_Click(object sender, EventArgs e)
        {
            Form NewRecordForm = new NewRecordForm();
            NewRecordForm.Show();
			this.Hide();
        }

        private void stopTreeViewSound(object sender, KeyEventArgs e)
        {
            e.Handled = e.SuppressKeyPress = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DisplayUserRecordDataGrid();
            PopulateCategories();
        }


        // set up UserRecordDataGrid view's properties then connect to database and display the data.
        public void DisplayUserRecordDataGrid()
        {
            userRecordDataGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            // Bind the DataGridView to the BindingSource
            // and load the data from the database.
            userRecordDataGridView.DataSource = dbHelper.GetData("select * from dbo.UserRecord");
            // Resize the DataGridView columns to fit the newly loaded content.
            userRecordDataGridView.AutoResizeColumns(
            DataGridViewAutoSizeColumnsMode.ColumnHeader);
            //Remove "RecordID" column from DataGrid
            //userRecordDataGridView.Columns.Remove("RecordID");
            //Hide "Note","UserAccountID" columns from DataGrid
            userRecordDataGridView.Columns["UserAccountID"].Visible = false;
            userRecordDataGridView.Columns["Note"].Visible = false;
            userRecordDataGridView.Columns["RecordID"].Visible = false;
            // Rename columuns
            userRecordDataGridView.Columns[1].HeaderText = "User Name";
            userRecordDataGridView.Columns[2].HeaderText = "Password";
            userRecordDataGridView.ScrollBars = ScrollBars.Horizontal;

        }



        // DataGrid view cell formatting event handler -- Formatting password cell to hide password
        private void userRecordDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //Show toolTip for remaining user use click to copy user name or password to clipboard.
            DataGridViewCell cell = this.userRecordDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
            cell.ToolTipText = "Click cooresponding cell to copy user name or password";

            //Format password, hide password as '*'
            if (userRecordDataGridView.Columns[e.ColumnIndex].Name == "UserPassword" && e.Value != null)
            {
                userRecordDataGridView.Rows[e.RowIndex].Tag = e.Value;
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }


        //DataGrid view mouse click event handler
        //when user click the cell, password and user name will be save to clipboard
        private void CopyPaste_Click(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex < 0) return;
            //When user click row, it pass the recordID to the userRecordID
            userCurrentClickRow = userRecordDataGridView.CurrentRow;
            userRecordID = (Int32)userCurrentClickRow.Cells[0].Value;
            //If current column is Password column, it pass the actual password to clipboard
            if (userRecordDataGridView.Columns[e.ColumnIndex].Name == "UserPassword")
            {
                try
                {
                    // Add the selection to the clipboard.
                    Clipboard.SetDataObject(userRecordDataGridView.CurrentRow.Tag);

                    // Replace the text box contents with the clipboard text.
                    //this.TextBox1.Text = Clipboard.GetText();
                }
                catch (System.Runtime.InteropServices.ExternalException)
                {
                    //("The Clipboard could not be accessed. Please try again.");
                }
            }
            //if not , that means it is user name column, it passes the user name to clipboard
            else
            {
                try
                {
                    // Add the selection to the clipboard.
                    Clipboard.SetDataObject(userRecordDataGridView.GetClipboardContent());

                    // Replace the text box contents with the clipboard text.
                    //this.TextBox1.Text = Clipboard.GetText();
                }
                catch (System.Runtime.InteropServices.ExternalException)
                {
                    //("The Clipboard could not be accessed. Please try again.");
                }
            }
        }


        //DataGrid cell right click pop up contextMenu
        private void userRecordDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridView.HitTestInfo hit = userRecordDataGridView.HitTest(e.X, e.Y);
                if (hit.Type == DataGridViewHitTestType.Cell)
                {
                    //Get the row the user right click to.
                    userRightClickRow = userRecordDataGridView.Rows[hit.RowIndex];
                    //Get the userRecordID
                    userRecordID = (Int32)userRightClickRow.Cells[0].Value;
                }
            }
        }

        //Handle right click selection event
        //User wants to "view" record 
        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (userRightClickRow != null)
            {
                //Retrieve the RecordID.
                string userRecordTxt = userRightClickRow.Cells[0].Value.ToString();

                //For testing pop up a msg to show "UserAccountID"
                MessageBox.Show("You just click " + userRecordTxt);
            }

            //After call the controler, reset userRightClickRow
            userRightClickRow = null;
        }

        //User wants to "Delete" click -- right click meun
        private void deleteTollStripMenuItem_Click(object sender, EventArgs e)
        {
            if (userRecordID != 0)
            {
                //Instantiate new UserRecord and pass userRecordID to the RecordID property
                UserRecord userRecord = new UserRecord();
                userRecord.RecordID = userRecordID;
                //Call DeleteRecordController to delete the UserRecord
                DeleteRecordController deleteController = new DeleteRecordController(this, userRecord);
                //After delete reset userRecord to 0
                if (deleteController.DeleteRecord())
                    userRecordID = 0;
            }
        }

        //User wants to "Delete" click -- "Delete" button
        private void DeleteRecordButton_Click(object sender, EventArgs e)
        {
            if (userRecordID != 0)
            {
                //Instantiate new UserRecord and pass userRecordID to the RecordID property
                UserRecord userRecord = new UserRecord();
                userRecord.RecordID = userRecordID;
                //Call DeleteRecordController to delete the UserRecord
                DeleteRecordController deleteController = new DeleteRecordController(this, userRecord);
                //After delete reset userRecord to 0
                if (deleteController.DeleteRecord())
                    userRecordID = 0;
            }
            else
            {
                MessageBox.Show("Please select a record.");
                return;
            }
        }

        //User wants to "Edit" click
        private void editTollStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You just click Edit");
        }

        //User wants to create "New" record
        private void newTollStripMenuItem_Clic(object sender, EventArgs e)
        {
            Form NewRecordForm = new NewRecordForm();
            NewRecordForm.Show();
            this.Hide();
        }



        private void ViewRecordButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool isSelected;
                //Instantiate new UserRecord and pass userRecordID to the RecordID property
                UserRecord userRecord = new UserRecord();

                userRecord.RecordID = (Int32)userCurrentClickRow.Cells[0].Value;
                userRecord.UserName = this.userCurrentClickRow.Cells[1].Value.ToString();
                userRecord.UserPassword = this.userCurrentClickRow.Cells[2].Value.ToString();
                userRecord.ServiceName = this.userCurrentClickRow.Cells[3].Value.ToString();
                userRecord.Note = this.userCurrentClickRow.Cells[4].Value.ToString();
                userRecord.CategoryName = this.userCurrentClickRow.Cells[6].Value.ToString();

                viewRecordDetails viewRecordclass = new viewRecordDetails();
                isSelected = viewRecordclass.SelectEntity(userRecord);

                if (isSelected)
                {

                    this.Hide();

                }
            }

            catch
            {
                MessageBox.Show("Please select a record first.");
            }
        }

        //Populate Category treeview 
        public void PopulateCategories()
        {
            // Query for the user categories. These are the values
            // for the nodes.
            DataSet ResultSet = new DataSet();

            //Get the UserAccountId, hard code UseAccount = 1, should be change to static class userAccount later.
            Category category = new Category();
            category.UserAccountId = 1;
            //ListCategoryHelper's selectEntity() return SqlDataAdapter
            ListCategoryHelper categoryList = new ListCategoryHelper();
            categoryList.SelectEntity(category).Fill(ResultSet, "Categories");
            CategoryTreeView.Nodes[0].Nodes.Clear();
            // Create the second-level nodes.
            if (ResultSet.Tables.Count > 0)
            {
                // Iterate through and create a new node for each row in the query results.
                // Notice that the query results are stored in the table of the DataSet.
                foreach (DataRow row in ResultSet.Tables[0].Rows)
                {
                    // Create the new node. Notice that the CategoryId is stored in the Value property 
                    // of the node. This will make querying for items in a specific category easier when
                    // the third-level nodes are created. 
                    TreeNode NewNode = new TreeNode(row["CategoryName"].ToString());
                    //Save the CategoryID to the treeNode value
                    NewNode.Tag = row["CategoryID"];

                    // Add the new node to the ChildNodes collection of the parent node. Node[0] is the parent Node.
                    CategoryTreeView.Nodes[0].Nodes.Add(NewNode);
                    //MessageBox.Show(row["CategoryName"].ToString() + "is created.");

                }
            }

            CategoryTreeView.ExpandAll();
            CategoryTreeView.Refresh();
        }

        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManupulateCategoryForm MCF = new ManupulateCategoryForm();
            MCF.ShowDialog();

        }
        private void EditRecordButton_Click(object sender, EventArgs e)
        {
            UserRecord passUserRecord = new UserRecord();
            try
            {
                Decryptor decryptor = new Decryptor();
                passUserRecord.RecordID = userRecordID;
                passUserRecord.UserName = this.userRecordDataGridView.CurrentRow.Cells[1].Value.ToString();
                passUserRecord.UserPassword = decryptor.AESDecrypt256(this.userRecordDataGridView.CurrentRow.Cells[2].Value.ToString());
                passUserRecord.ServiceName = this.userRecordDataGridView.CurrentRow.Cells[3].Value.ToString();
                passUserRecord.CategoryName = this.userRecordDataGridView.CurrentRow.Cells[6].Value.ToString();
                passUserRecord.Note = this.userRecordDataGridView.CurrentRow.Cells[4].Value.ToString();
                EditRecordForm ERF = new EditRecordForm();
                ERF.passData(passUserRecord);
                this.Hide();
                ERF.Show();

            }
            catch 
            {
                MessageBox.Show("Please select a record first.");

            }
        }

        //After user click the Node, save the corresponding categoryId and categoryName to selectCategoryId
        private void CategoryTreeView_NodeMouseClick_1(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag != null)
            {
                if ((int)e.Node.Tag != 11000001)
                {
                    selectedCategoryID = (int)e.Node.Tag;
                    selectedCategoryName = e.Node.Text;
                }
            }
        }

        //When user click "Delete category button", trigger the DeleteCategoryController
        private void DeleteCategoryButton_Click(object sender, EventArgs e)
        {
            if (selectedCategoryID != 0)
            {
                //Instantiate new Category and pass CategoryID to the categoryName property
                Category category = new Category();
                category.CategoryID= selectedCategoryID;
                category.CategoryName = selectedCategoryName;
                //Call DeleteCategoryController to delete the Category
                DeleteCategoryController deleteController = new DeleteCategoryController(this, category);
                //After delete reset userRecord to 0
                if (deleteController.DeleteCategory())
                    selectedCategoryID = 0;
            }
            else
            {
                MessageBox.Show("Please select a category.");
                return;
            }
        }

        private void EditCategoetButton_Click(object sender, EventArgs e)
        {
            if (selectedCategoryID != 0)
            {
                //Instantiate new Category and pass CategoryID to the categoryName property
                this.Hide();
                Category changeCategory = new Category();
                changeCategory.CategoryID = selectedCategoryID;
                changeCategory.CategoryName = selectedCategoryName;
                ManupulateCategoryForm MCF = new ManupulateCategoryForm();
                MCF.setOldCategory(changeCategory);
                MCF.Text = "Edit Category";
                //Set the controller to be call is EditController
                MCF.setMethodCall("Edit");
                MCF.CategoryNameTextBox.Text = selectedCategoryName;
                MCF.manupulateCategoryLabel.Text = "Edit Category Name:";
                MCF.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a category.");
                return;
            }
        }

    }
}
