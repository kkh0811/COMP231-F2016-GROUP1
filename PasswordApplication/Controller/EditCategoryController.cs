using PasswordApplication.AbstractClass;
using PasswordApplication.Controller;
using PasswordApplication.Interfaces;
using PasswordApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordApplication.DBHelper
{
    /// <summary>
    /// Update category name from user input, update record to category table
    /// </summary>
    class EditCategoryController
    {
        // view is a window form object,used to call back view method to update itself.
        Form view;
        //entity can be any table in db, such as UserRecord,Categories,UserRecordCategories, 
        //used to grab info(ie. userRecordID) from view what user want to manupulate.
        AbDatabaseEntity oldCategory;
        // Two deleteUserRecord and deleteUserCategory helper class, used to call the helper class to do db stuff(ie. delete,save,insert).
        IUpdate updateUserRecordHelper;
        IUpdate updateCategoryNameHelper;
        AbDatabaseEntity newCategory;

        public EditCategoryController(Form _view, params AbDatabaseEntity[] _entity)
        {
            this.view = _view;
            this.oldCategory = _entity[0];
            this.newCategory = _entity[1];
        }

        public bool EditCategory()
        {
            bool isUpdated = false;

            //Validate the input
            NewCategoryValidator validator = new NewCategoryValidator();
            if (!validator.Validate(((Category)newCategory).CategoryName))
            {
                return false;
            }

            //Check if the category is existed, yes--save, no--message
            CategoryExistedChecker existChecker = new CategoryExistedChecker();
            if (existChecker.checkIsCategoryExisted((Category)newCategory))
            {
                return false;
            }
            else
            {
                //Update new category to Db
                updateUserRecordHelper = new UpdateUserRecord_UpdateCategoryHelper();
                updateCategoryNameHelper = new UpdateCategoryNameHelper();
                if (updateUserRecordHelper.UpdateEntity(oldCategory,newCategory) 
                    && updateCategoryNameHelper.UpdateEntity(oldCategory,newCategory))
                {
                    MessageBox.Show(String.Format("{0} has been updated.", ((Category)newCategory).CategoryName));
                    view.Close();
                    view.Dispose();
                    isUpdated = true;
                    MainForm MF = new MainForm();
                    //Call view to update the category tree itself.
                    MF.PopulateCategories();
                    MF.Show();
                }
                else
                {
                    isUpdated = false;
                }
            }
            return isUpdated;
        }
    }
}
