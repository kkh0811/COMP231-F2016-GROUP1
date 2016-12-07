using PasswordApplication.AbstractClass;
using PasswordApplication.Controller;
using PasswordApplication.DBHelper;
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
        internal Category oldCategory;
        string methodCall;

        //Set the controller call in runtime (EditController or AddController)
        public void setMethodCall(string method)
        {
            methodCall = method;
        }

        //Set the oldCategory
        internal void setOldCategory(Category category)
        {
            oldCategory = category;
        }

        public ManupulateCategoryForm()
        {
            InitializeComponent();
            oldCategory = new Category();
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
            Category newCategory = new Category();
            newCategory.CategoryName = CategoryNameTextBox.Text.Trim();
            newCategory.CategoryID = oldCategory.CategoryID;
            newCategory.UserAccountId = 1;
            //The this form is foe editing, then call update controller
            if (methodCall == "Edit")
            {
                //Call EditCategoryController
                EditCategoryController updateController = new EditCategoryController(this, oldCategory, newCategory);
                updateController.EditCategory();
                return;
            }
            else
            {
                //Instantiate AddCategoryController 
                AddCategoryController controller = new AddCategoryController(this, newCategory);
                controller.AddRecord();
            }
        }
    }
}
