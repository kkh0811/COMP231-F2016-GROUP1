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
        public ViewRecordForm()
        {
            InitializeComponent();
        }
		private int pRecordID;
        private string pUserName;
        private string pPassword;
        private string pNote;
		private string pCategory;

        //getter and setter
        public int GrabRecordID
        {
            get { return pRecordID; }
            set { pRecordID = value; }
        }
        public string ViewUserName
        {
            get { return pUserName; }
            set { pUserName = value; }
        }
        public string ViewPassword
        {
            get { return pPassword; }
            set { pPassword = value; }
        }
        public string ViewNote
        {
            get { return pNote; }
            set { pNote = value; }
        }
        public string ViewCategory
        {
            get { return pCategory; }
            set { pCategory = value; }
        }
        private void ViewRecordForm_Load(object sender, EventArgs e)
        {
            //display the selected information
            //get information from DB and show the necessary information
            //UserNameTextBox.Text = pUserName;
            //PasswordTextBox.Text = pPassword;
            //NoteTextBox.Text = pNote;

        }
        private void EditRecordButton_Click(object sender, EventArgs e)
        {
            //open edit records form
            //EditRecordForm erf = new EditRecordForm();
            //erf.GrabRecordID = pRecordID;
            //erf.EditUserName = pUserName;
            //erf.EditCategory = pCategory;
            //erf.EditPassword = pPassword;
            //erf.EditNote = pNote;
            //erf.Show();
            //this.Hide();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            //when user is done viewing the records in detail, click ok to return to main screen.
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void ChkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkBoxShow.Checked == true)
            {
                PasswordTextBox.PasswordChar = '\0';
               // VerifyPasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                PasswordTextBox.PasswordChar = '*';
                //VerifyPasswordTextBox.PasswordChar = '*';
            }
        }
    }
}
