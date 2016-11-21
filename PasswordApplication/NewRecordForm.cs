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
        Validation validate = new Validation();
        DatabaseHelper dh = new DatabaseHelper();

        UserNameValidator unv = new UserNameValidator();
        PasswordValidator pv = new PasswordValidator();
        NoteValidator nv = new NoteValidator();
        UserRecord userRecord = new UserRecord();
        

        SQLServerConnMaker SQLconn = new SQLServerConnMaker();
        //private DataViewManager dsView;
        private DataSet ds;

        public NewRecordForm()
        {
            InitializeComponent();

            //this needs to go to a different class helper for handling categories
            string getCategoryName = "SELECT CategoryName FROM Categories WHERE UserAccountID = 1;";
            SqlDataAdapter da = new SqlDataAdapter(getCategoryName, SQLconn.Connect());

            // Build a dataset
            ds = new DataSet();
            da.Fill(ds, "Categories");
            // Table in Dataset

            foreach (DataRow dr1 in ds.Tables[0].Rows)
            {
                CategoryOptionComboBox.Items.Add(dr1["CategoryName"].ToString());
                CategoryOptionComboBox.ValueMember = "CategoryId";//value member wrong?
            }


        }
        private void NewRecordForm_Load(object sender, EventArgs e)
        {
            CategoryOptionComboBox.SelectedIndex = 0;
        }
        //Event trigger on user pressing cancel
        private void CancelButton_Click(object sender, EventArgs e)
        {
            //Close New Record window
            this.Close();
            mainForm.Show();
        }

        //Event trigger on user pressing Save
        private void SaveNewRecordButton_Click(object sender, EventArgs e)
        {
            //if statement of the return bool value from method validating
            if (validating() == true)
            {
                //pass information to DB
                //instantiate AddUserRecordHelper, UserRecord, Category
                AddUserRecordhelper addUserRecordhelper = new AddUserRecordhelper();
                UserRecord addRecord = new UserRecord();
                Category category = new Category();
                //Gets the Category ID of the selected Category
                category.CategoryID = Convert.ToInt16(CategoryOptionComboBox.SelectedIndex);
                //Grab values from user inputs
                addRecord.UserName = UserNameTextBox.Text;
                addRecord.UserPassword = PasswordTextBox.Text;
                addRecord.Note = NoteTextBox.Text;
                addRecord.ServiceName = ServiceNameTextBox.Text;
                if (category.CategoryID != 0)
                { 
                    category.CategoryName = CategoryOptionComboBox.SelectedItem.ToString();
                }
                else
                {
                    //set empty string if user did not select a category.
                    category.CategoryName = "";
                }

                //Pass entities to addUserRecordHelper class
                addUserRecordhelper.SaveEntity(addRecord,category);
                //On success show message box and close new record form and display the main form.
                MessageBox.Show("Success");
                this.Close();
				mainForm.Show();
            }
            else
            {
                //when missing/incorrect information still required.
                MessageBox.Show("Please enter the correct information and try again.","Add New User Record",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

        }
        private bool validating()
        {   
            //instantiate validator classes
            UserNameValidator unv = new UserNameValidator();
            PasswordValidator pv = new PasswordValidator();
            NoteValidator nv = new NoteValidator();
            ServiceNameValidator snv = new ServiceNameValidator();

            errorProvider1.Clear();
            //validate username text box
            if (unv.Validate(UserNameTextBox.Text) == true)
            {
                //validation for username is correct
                errorProvider1.SetError(UserNameTextBox, "");
            }
            else
            {
                //validation for username is incorrect
                errorProvider1.SetError(UserNameTextBox, "Please enter username in alphabets and numbers. Email format is allowed.");
                return false;
            }
            //validate password text box
            if (pv.Validate(PasswordTextBox.Text) == true)
            {
                //validation for password is correct
                errorProvider1.SetError(PasswordTextBox, "");
            }
            else
            {
                //validation is incorrect
                errorProvider1.SetError(PasswordTextBox, "Please make sure your password has minimum two characters, at least one number and letter. \nCannot contain the following special characters:" +
                    " & ' . OR ");
                return false;
                
            }
            //validate password verify text box
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
            //validate service name text box
            if (snv.Validate(ServiceNameTextBox.Text) == true)
            {
                errorProvider1.SetError(ServiceNameTextBox, "");
                
            }
            else
            {
                errorProvider1.SetError(ServiceNameTextBox, "Service name has to be minimum 2 characters long and \ncan only use _ @ . or whitespace");
                return false;

            }
            //validate note text box
            if (nv.Validate(NoteTextBox.Text) == true)
            {
                //correct validation
                errorProvider1.SetError(NoteTextBox, "");
                return true;
            }
            else
            {
                //incorrect validation
                errorProvider1.SetError(NoteTextBox, "Please don't put in any of the following characters ‘, \\ * & ; - '");
                return false;
            }

        }
        //Method to show masked characters when check box is selected
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
