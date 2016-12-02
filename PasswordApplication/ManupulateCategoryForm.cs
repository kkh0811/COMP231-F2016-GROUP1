using PasswordApplication.Controller;
using PasswordApplication.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PasswordApplication
{
    public partial class ManupulateCategoryForm : Form
    {
        string methodCall;

        //Set the controller call in runtime (EditController or AddController)
        public void setMethodCall(string method)
        {
            methodCall = method;
        }
        public ManupulateCategoryForm()
        {
            InitializeComponent();
        }

        private void cancelAddCatrgoryButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            MainForm MF = new MainForm();
            MF.Show();
        }

        private void SaveNewCategoryButton_Click(object sender, EventArgs e)
        {
            //Instantiate category model and save category name and UserAccountId (Assume UserAccountId is 1)to it.
            Category category = new Category();
            category.CategoryName = CategoryNameTextBox.Text.Trim();
            category.UserAccountId = 1;

            if (methodCall == "Edit")
            {
                //Call EditCategoryController
                return;
            }
            //Instantiate AddCategoryController 
            AddCategoryController controller = new AddCategoryController(this,category);
            if (controller.AddRecord())
            {
                //MessageBox.Show(String.Format("{0} has been inserted.", category.CategoryName));
            }
            else
            {
                //Do nothing
                //MessageBox.Show("Unable new category, please try again later.");
            }
        }
 
    }
}
