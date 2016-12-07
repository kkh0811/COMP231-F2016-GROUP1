using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordApplication
{
    public partial class ViewRecordForm : Form
    {
        Decryptor decryptor = new Decryptor();
        public ViewRecordForm()
        {
            InitializeComponent();
        }
		

        //getter and setter
        public int GrabRecordID;
       
        private void ViewRecordForm_Load(object sender, EventArgs e)
        {
            

            //display the selected information
            //get information from DB and show the necessary information
            UserNameTextBox.Text = pUserName;
            //PasswordTextBox.Text = pPassword;
            PasswordTextBox.Text = decryptor.AESDecrypt256(pPassword);
            NoteTextBox.Text = pNote;

        }
        private void EditRecordButton_Click(object sender, EventArgs e)
        {

            
            //open edit records form
            EditRecordForm erf = new EditRecordForm();
            erf.GrabRecordID = pRecordID;
            erf.EditUserName = pUserName;
            erf.EditCategory = pCategory;
            erf.EditPassword = decryptor.AESDecrypt256(pPassword);
            erf.EditNote = pNote;
            erf.Show();
            this.Hide();
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
