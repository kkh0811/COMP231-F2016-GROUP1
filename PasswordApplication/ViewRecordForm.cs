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

namespace PasswordApplication
{
    public partial class ViewRecordForm : Form
    {
        public ViewRecordForm()
        {
            InitializeComponent();
        }

        //getter and setter
        public int GrabRecordID;
        

        //getter and setter
       // public int GrabRecordID;
       
        private void ViewRecordForm_Load(object sender, EventArgs e)
        {
            //display the selected information
            //get information from DB and show the necessary information
            
            

        }
        /// <summary>
        /// On button click, open Edit Record Form with the data passed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditRecordButton_Click(object sender, EventArgs e)
        {
            UserRecord passUserRecord = new UserRecord();
            passUserRecord.UserName = UserNameTextBox.Text;
            passUserRecord.UserPassword = PasswordTextBox.Text;
            passUserRecord.ServiceName = ServiceNameTextBox.Text;
            passUserRecord.CategoryName = CategoryOptionComboBox.SelectedText.ToString();
            passUserRecord.Note = NoteTextBox.Text;
            EditRecordForm ERF = new EditRecordForm();
            ERF.passData(passUserRecord);
            this.Hide();
            ERF.Show();

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            //when user is done viewing the records in detail, click ok to return to main screen.
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void ShowChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowChkBox.Checked == true)
            {
                PasswordTextBox.PasswordChar = '\0';
                
            }
            else
            {
                PasswordTextBox.PasswordChar = '*';
                
            }
        }
    }
}
