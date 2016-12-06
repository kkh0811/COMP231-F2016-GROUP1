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
    {
        internal UserRecord oldUserRecord;
        //instantiate objs
        UserRecord editUserRecord = new UserRecord();
        Category selectedCategory = new Category();
        ServiceNameValidator snv = new ServiceNameValidator();
        ListCategoryHelper listCategory = new ListCategoryHelper();

        public EditRecordForm()
        {
            InitializeComponent();

        }
        internal void passData(UserRecord userRecord)
        {
            oldUserRecord = userRecord;
        }
        private void EditRecordForm_Load(object sender, EventArgs e)
        {
            Category category = new Category();
            DataSet dataSet = new DataSet();
            category.UserAccountId = 1;
            //on form load, show the data from selected record in respective text box fields
            listCategory.SelectEntity(category).Fill(dataSet, "Categories");
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                CategoryOptionComboBox.Items.Add(row["CategoryName"].ToString());
            }
            UserNameTextBox.Text = oldUserRecord.UserName;
            PasswordTextBox.Text = oldUserRecord.UserPassword;
            ServiceNameTextBox.Text = oldUserRecord.ServiceName;

            NoteTextBox.Text = oldUserRecord.Note;
            CategoryOptionComboBox.SelectedIndex = CategoryOptionComboBox.FindString(oldUserRecord.CategoryName);

        }

        /// <summary>
        /// Public constructor for unit test
        /// </summary>
        /// <param name="isValid"></param>
        /// <param name="isTest"></param>
        /// <returns></returns>
        public bool ValidatingEditRecord(bool isValid, bool isTest)
        {
            return ValidatingEditRecord(isValid);
        }
        /// <summary>
        /// Method that will be called when validating user input prior to sending to database.
        /// If validate successful, method will return true. Otherwise, it will return false.
        /// </summary>
        private bool ValidatingEditRecord(bool isValid)
        {
            //set default to true
            isValid = true;
            //pass record to textboxes
            editUserRecord.UserName = UserNameTextBox.Text;
            editUserRecord.UserPassword = PasswordTextBox.Text;
            editUserRecord.ServiceName = ServiceNameTextBox.Text;
            editUserRecord.Note = NoteTextBox.Text;
            //instantiate controller class
            EditUserRecordController controller = new EditUserRecordController(this, editUserRecord);
            errorProvider.Clear();
            if (isValid == true)
            {
                //validate username text box
                if (controller.EditUserName() == true)
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
                if (controller.EditPassword() == true)
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
                if (controller.EditServiceName() == true)
                {
                    errorProvider.SetError(ServiceNameTextBox, "");
                }
                else
                {
                    errorProvider.SetError(ServiceNameTextBox, "Service name has to be minimum 2 characters long and \ncan only use _ @ . or whitespace");
                    return false;
                }
                //validate note text box
                if (controller.EditNote() == true)
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
            else
            {
                isValid = false;
            }
            return isValid;

        }

        /// <summary>
        /// Method that checks if user selects checkbox to show masked characters for password and verify password text box.
        /// </summary>
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
        /// <summary>
        /// When save button is clicked, method will validate the user input.
        /// If user input validation passes, controller class EditUserRecordController obj is created and calls method UpdateRecord
        /// to process update record.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveNewRecordButton_Click(object sender, EventArgs e)
        {
            if (ValidatingEditRecord(true))
            {
                //grab category ID of selected value
                selectedCategory.CategoryID = Convert.ToInt16(CategoryOptionComboBox.SelectedIndex);
                //grab the text box values
                editUserRecord.UserName = UserNameTextBox.Text;
                editUserRecord.UserPassword = PasswordTextBox.Text;
                editUserRecord.ServiceName = ServiceNameTextBox.Text;
                editUserRecord.RecordID = oldUserRecord.RecordID;

                if (selectedCategory.CategoryID != 0)
                {
                    editUserRecord.CategoryName = CategoryOptionComboBox.SelectedItem.ToString();
                }
                else
                {
                    selectedCategory.CategoryName = "";
                }
                //instantiate controller to call method UpdateRecord from controller class
                EditUserRecordController controller = new EditUserRecordController(this, editUserRecord);
                controller.UpdateRecord();
                //After record is updated, show the message box and direct back to main form
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

        /// <summary>
        /// When user selects the cancel button, bring user back to main form.
        /// </summary>
        /// <param object="sender"></param>
        /// <param EventArgs="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();

        }
    }
}
