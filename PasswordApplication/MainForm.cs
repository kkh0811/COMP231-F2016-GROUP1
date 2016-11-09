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
            //PopulateCategories();


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
            userRecordDataGridView.Columns[0].HeaderText = "USER NAME";
            userRecordDataGridView.Columns[1].HeaderText = "PASSWORD";
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

        //Cast GridView column to textbox and use Textbox's passwordChar feature (GirdView should be editable)
        /*
        private void userRecordDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (userRecordDataGridView.CurrentRow.Tag != null)
                e.Control.Text = userRecordDataGridView.CurrentRow.Tag.ToString();
        }
        */

        //DataGrid view mouse click event handler
        //when user click the cell, password and user name will be save to clipboard
        private void CopyPaste_Click(object sender, DataGridViewCellMouseEventArgs e)
        {
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
            DialogResult result;
            if (userRecordID != 0)
            {   //Confirm if user wants to delete the record
                result = MessageBox.Show("Do You Want to delete?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    //Get the RecordId from the click row and send it as the delete record parameter
                    DatabaseHelper.deleteRecord(userRecordID);
                    // display the result
                    DisplayUserRecordDataGrid();
                    //After delete reset userRecord to 0
                    userRecordID = 0;
                }
            }
        }

        //User wants to "Delete" click -- "Delete" button
        private void DeleteRecordButton_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if (userRecordID != 0)
            {   //Confirm if user wants to delete the record
                result = MessageBox.Show("Do You Want to delete?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    //Get the RecordId from the click row and send it as the delete record parameter
                    DatabaseHelper.deleteRecord(userRecordID);
                    // display the result
                    DisplayUserRecordDataGrid();
                    //After delete reset userRecord to 0
                    userRecordID = 0;
                }
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
            MessageBox.Show("You just click New");
        }


      
        private void ViewRecordButton_Click(object sender, EventArgs e)
        {
			try
            {
                vrf.GrabRecordID = (Int32)userRecordDataGridView.CurrentRow.Cells[0].Value;
                vrf.ViewUserName = this.userRecordDataGridView.CurrentRow.Cells[1].Value.ToString();
                vrf.ViewPassword = this.userRecordDataGridView.CurrentRow.Cells[2].Value.ToString();
                vrf.ViewNote = this.userRecordDataGridView.CurrentRow.Cells[3].Value.ToString();
                vrf.Show();
                this.Hide();
            }

            catch
            {
                MessageBox.Show("Please select a record first.");
            }
        }

        private void userRecordDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            vrf.GrabRecordID = (Int32)userRecordDataGridView.CurrentRow.Cells[0].Value;
            vrf.ViewUserName = this.userRecordDataGridView.CurrentRow.Cells[1].Value.ToString();
            vrf.ViewPassword = this.userRecordDataGridView.CurrentRow.Cells[2].Value.ToString();
            vrf.ViewNote = this.userRecordDataGridView.CurrentRow.Cells[3].Value.ToString();
            vrf.Show();
            this.Hide();

        }


        //Populate Category treeview 
        public void PopulateCategories()
        {

            // Query for the user categories. These are the values
            // for the nodes.
            DataSet ResultSet = new DataSet();
            DatabaseHelper.manupulateCategory(1).Fill(ResultSet, "Categories");
            CategoryTreeView.Nodes[0].Nodes.Clear();
            // Create the second-level nodes.
            if (ResultSet.Tables.Count > 0)
            {
                // Iterate through and create a new node for each row in the query results.
                // Notice that the query results are stored in the table of the DataSet.
                foreach (DataRow row in ResultSet.Tables[0].Rows)
                {
                    //MessageBox.Show(row["CategoryName"].ToString());
                    // Create the new node. Notice that the CategoryId is stored in the Value property 
                    // of the node. This will make querying for items in a specific category easier when
                    // the third-level nodes are created. 
                    TreeNode NewNode = new TreeNode(row["CategoryName"].ToString());
                    //Save the CategoryID to the treeNode value
                    NewNode.Tag = row["CategoryID"];

                    // Add the new node to the ChildNodes collection of the parent node. Node[0] is the parent Node.
                    CategoryTreeView.Nodes[0].Nodes.Add(NewNode);
                    //MessageBox.Show(row["CategoryName"].ToString() + "is created.");
                    //CategoryTreeView.ExpandAll();
                }
            }
            CategoryTreeView.Update();
        }

        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            ManupulateCategoryForm MCF = new ManupulateCategoryForm();
            MCF.ShowDialog();
        }
		private void EditRecordButton_Click(object sender, EventArgs e)
        {

            try
            {   
				edf.GrabRecordID = (Int32)userRecordDataGridView.CurrentRow.Cells[0].Value;
                edf.EditUserName = this.userRecordDataGridView.CurrentRow.Cells[1].Value.ToString();
                edf.EditPassword = this.userRecordDataGridView.CurrentRow.Cells[2].Value.ToString();
                edf.EditNote = this.userRecordDataGridView.CurrentRow.Cells[3].Value.ToString();
                edf.Show();
                this.Hide();
            }

            catch
            {
                MessageBox.Show("Please select a record first.");

            }
        }
    }
}
