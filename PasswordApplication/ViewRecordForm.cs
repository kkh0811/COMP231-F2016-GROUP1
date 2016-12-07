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
		

        //getter and setter
        public int GrabRecordID;
       
        private void ViewRecordForm_Load(object sender, EventArgs e)
        {
          
        }
        private void EditRecordButton_Click(object sender, EventArgs e)
        {
            
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
