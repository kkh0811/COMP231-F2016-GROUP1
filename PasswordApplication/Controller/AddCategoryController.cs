using PasswordApplication.AbstractClass;
using PasswordApplication.Interfaces;
using PasswordApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordApplication.Controller
{
    class AddCategoryController
    {
        // view is a window form object,used to call back view method to update itself.
        Form view;
        //entity can be any table in db, such as UserRecord,Categories,UserRecordCategories, 
        //used to grab info(ie. userRecordID) from view what user want to manupulate.
        AbDatabaseEntity entity;
        // Save Category helper class, used to call the helper class to do db stuff(ie. delete,save,insert).
        ISave saveHelper;

        //Construction
        public AddCategoryController(Form _view, AbDatabaseEntity _entity)
        {
            this.view = _view;
            this.entity = _entity;
        }

        // Call from view
        public bool AddRecord()
        {
            bool isSaved = false;

            //Validate the input
            NewCategoryValidator validator = new NewCategoryValidator();
            if (!validator.Validate(((Category)entity).CategoryName))
            {
                    return false;
            }

            //Check if the category is existed, yes--save, no--message
            CategoryExistedChecker existChecker = new CategoryExistedChecker();
            if (existChecker.checkIsCategoryExisted(entity))
            {
                return false;
            }
            else
            {
                //Save new category to Db
                saveHelper = new AddCategoryHelper();
                if (saveHelper.SaveEntity(entity))
                {
                    MessageBox.Show(String.Format("{0} has been inserted.", ((Category)entity).CategoryName));
                    view.Close();
                    view.Dispose();
                    isSaved = true;
                    MainForm MF = new MainForm();
                    //Call view to update the category tree itself.
                    MF.PopulateCategories();
                    MF.Refresh();
                }
                else
                {
                    isSaved = false;
                }
            } 
            return isSaved;

        }
    }
}
