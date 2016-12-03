using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PasswordApplication.Model;
using PasswordApplication.AbstractClass;
using PasswordApplication.Interfaces;
using PasswordApplication.Controller;

namespace PasswordApplication
{
    public partial class EditRecordForm : Form
    {   //instantiate objs
        
        UserNameValidator unv = new UserNameValidator();
        PasswordValidator pv = new PasswordValidator();
        NoteValidator nv = new NoteValidator();
        //UserRecord editUserRecord = new UserRecord();
        Category selectedCategory = new Category();
        ServiceNameValidator snv = new ServiceNameValidator();
        EditUserRecordHelper editUserRecordHelper = new EditUserRecordHelper();




        public EditRecordForm()
        {
            InitializeComponent();
            
        }

        private void EditRecordForm_Load(object sender, EventArgs e)
        {
            UserRecord editUserRecord = new UserRecord();
            //on form load, display information from UserRecord form in editable text boxes.
            UserNameTextBox.Text = editUserRecord.UserName; //editUserRecord.UserName;
            //editUserRecord.UserPassword= PasswordTextBox.Text;
            //editUserRecord.CategoryName = CategoryOptionComboBox.Text;
            //editUserRecord.Note = NoteTextBox.Text;

        }
        private bool ValidatingEditRecord()
        {
            errorProvider.Clear();
            //validate username text box
            if (unv.Validate(UserNameTextBox.Text) == true)
            {
                //validation for username is correct
                errorProvider.SetError(UserNameTextBox, "");
            }
            else
            {
                //validation for username is incorrect
                errorProvider.SetError(UserNameTextBox, "Please enter username in alphabets and numbers. Email format is allowed.");
                return false;
            }
            //validate password text box
            if (pv.Validate(PasswordTextBox.Text) == true)
            {
                //validation for password is correct
                errorProvider.SetError(PasswordTextBox, "");
            }
            else
            {
                //validation is incorrect
                errorProvider.SetError(PasswordTextBox, "Please make sure your password has minimum two characters, at least one number and letter. \nCannot contain the following special characters:" +
                    " & ' . OR ");
                return false;

            }
            //validate password verify text box
            if (PasswordTextBox.Text == VerifyPasswordTextBox.Text)
            {
                //validation for same password is correct
                errorProvider.SetError(VerifyPasswordTextBox, "");
            }
            else
            {
                //validation for same password is incorrect
                errorProvider.SetError(VerifyPasswordTextBox, "The passwords do not match.Please enter them again.");
                return false;
            }
            //validate service name text box
            if (snv.Validate(ServiceNameTextBox.Text) == true)
            {
                errorProvider.SetError(ServiceNameTextBox, "");
            }
            else
            {
                errorProvider.SetError(ServiceNameTextBox, "Service name has to be minimum 2 characters long and \ncan only use _ @ . or whitespace");
                return false;
            }
            //validate note text box
            if (nv.Validate(NoteTextBox.Text) == true)
            {
                //correct validation
                errorProvider.SetError(NoteTextBox, "");
                return true;
            }
            else
            {
                //incorrect validation
                errorProvider.SetError(NoteTextBox, "Please don't put in any of the following characters ‘, \\ * & ; - '");
                return false;
            }

        }



        private void ShowPasswordChkBox_CheckedChanged(object sender, EventArgs e)
        {
            //check if user check to show password or not and display/no display.
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

        private void SaveNewRecordButton_Click(object sender, EventArgs e)
        {
            UserRecord editUserRecord = new UserRecord();
            if (ValidatingEditRecord() == true)
            {
                //grab category ID of selected value
                selectedCategory.CategoryID = Convert.ToInt16(CategoryOptionComboBox.SelectedIndex);
                //grab the text box values
                editUserRecord.UserName = UserNameTextBox.Text;
                editUserRecord.UserPassword = PasswordTextBox.Text;
                editUserRecord.ServiceName = ServiceNameTextBox.Text;
                if (selectedCategory.CategoryID != 0)
                {
                    selectedCategory.CategoryName = CategoryOptionComboBox.SelectedItem.ToString();
                }
                else
                {
                    selectedCategory.CategoryName = "";
                }
                //send information to EditUserRecordHelper class
                editUserRecordHelper.EditEntity(editUserRecord, selectedCategory);
                //display message box that record has been updated
                MessageBox.Show("Record has been updated.");
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();

            }
            else
            {
                //if validation fails, show the message box
                MessageBox.Show("Please enter the correct information and try again.", "Edit User Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();

        }
    }
}
