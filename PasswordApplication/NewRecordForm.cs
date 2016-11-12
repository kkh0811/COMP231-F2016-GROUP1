using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PasswordApplication.Model;
using PasswordApplication.AbstractClass;

namespace PasswordApplication
{
    //Create a new record screen
    public partial class NewRecordForm : Form
    {
        //instantiate objects to call classes
        MainForm mainForm = new MainForm();
        UserNameValidator unv = new UserNameValidator();
        PasswordValidator pv = new PasswordValidator();
        NoteValidator nv = new NoteValidator();
        CategoryValidator cv = new CategoryValidator();



        SQLServerConnMaker SQLconn = new SQLServerConnMaker();
        //private DataViewManager dsView;
        private DataSet ds;


        public NewRecordForm()
        {
            InitializeComponent();
            string getCategoryName = "SELECT CategoryName FROM Categories WHERE UserAccountID = 1;";
            SqlDataAdapter da = new SqlDataAdapter(getCategoryName, SQLconn.Connect());

            // Build a dataset
            ds = new DataSet();
            da.Fill(ds, "Categories");
            // Table in Dataset

            foreach (DataRow dr1 in ds.Tables[0].Rows)
            {
                CategoryOptionComboBox.Items.Add(dr1["CategoryName"].ToString());
            }


        }
        private void NewRecordForm_Load(object sender, EventArgs e)
        {
            CategoryOptionComboBox.SelectedIndex = 0;


        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            //Close New Record window
            this.Close();
            mainForm.Show();
        }

        private void SaveNewRecordButton_Click(object sender, EventArgs e)
        {
            if (validating() == true)
            {
                //pass information to DB
                AddUserRecordhelper addUserRecordhelper = new AddUserRecordhelper();
                UserRecord addRecord = new UserRecord();
                Category category = new Category();
                //UserRecordExtend addUserRecordExtend = new UserRecordExtend();
                category.CategoryID = CategoryOptionComboBox.SelectedIndex;
                addRecord.UserName = UserNameTextBox.Text;
                addRecord.UserPassword = PasswordTextBox.Text;
                addRecord.Note = NoteTextBox.Text;
                addUserRecordhelper.SaveEntity(addRecord,category);
                MessageBox.Show("Success");
                this.Close();
				mainForm.Show();
            }
            else
            {
                //when missing/incorrect information still required.
                MessageBox.Show("Please enter the correct information and try again.");
                return;
            }

        }
        private bool validating()
        {
            if (unv.Validate(UserNameTextBox.Text) == true)
            {
                //validation for username is correct
                errorProvider1.SetError(UserNameTextBox, "");
            }
            else
            {
                //validation for username is incorrect
                errorProvider1.SetError(UserNameTextBox, "Please enter username in alphabets and numbers only");
                return false;
            }
            if (pv.Validate(PasswordTextBox.Text) == true)
            {
                //validation for password is correct
                errorProvider1.SetError(PasswordTextBox, "");
            }
            else
            {
                //validation is incorrect
                errorProvider1.SetError(PasswordTextBox, "The password cannot contain any of the following: ‘,\\*&amp;$&lt;&gt;");
                return false;
            }
            if (PasswordTextBox.Text == VerifyPasswordTextBox.Text)
            {
                //validation for same password is correct
                errorProvider1.SetError(VerifyPasswordTextBox, "");
            }
            else
            {
                //validation for same password is incorrect
                errorProvider1.SetError(VerifyPasswordTextBox, "The passwords do not match.Please enter them again.");
                return false;
            }
            if (cv.Validate(CategoryOptionComboBox.SelectedItem.ToString()) == true)
            {
                errorProvider1.SetError(CategoryOptionComboBox, "");
            }
            else
            {
                errorProvider1.SetError(CategoryOptionComboBox, "Please select a category");
                return false;
            }
            if (nv.Validate(NoteTextBox.Text) == true)
            {
                //correct validation
                errorProvider1.SetError(NoteTextBox, "");
                return true;
            }
            else
            {
                //incorrect validation
                errorProvider1.SetError(NoteTextBox, "Please don't put in any of the following characters ‘,\\*&amp;$&lt;&gt;");
                return false;
            }
        }
        //method to show masked characters when check box is selected
        private void ShowPasswordChkBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (ShowPasswordChkBox.Checked == true)
            {
                PasswordTextBox.PasswordChar = '\0';
                VerifyPasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                PasswordTextBox.PasswordChar = '*';
                VerifyPasswordTextBox.PasswordChar = '*';
            }
        }
    }
}
