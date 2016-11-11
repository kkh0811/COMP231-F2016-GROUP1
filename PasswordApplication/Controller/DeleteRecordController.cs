using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PasswordApplication.AbstractClass;
using PasswordApplication.Interfaces;
using PasswordApplication.Model;

namespace PasswordApplication.Controller
{
    class  DeleteRecordController
    {
        // view is a window form object,used to call back view method to update itself.
        Form view;
        //entity can be any table in db, such as UserRecord,Categories,UserRecordCategories, 
        //used to grab info(ie. userRecordID) from view what user want to manupulate.
        AbDatabaseEntity entity;
        // Two deleteUserRecord and deleteUserCategory helper class, used to call the helper class to do db stuff(ie. delete,save,insert).
        IDelete deleteHelper;

        //Construction
        public DeleteRecordController(Form _view, AbDatabaseEntity _entity)
        {
            this.view = _view;
            this.entity = _entity;
        }

        public bool DeleteRecord()
        {
            //Check if record in Record table,UserRecordCategory is deleted.
            bool isRecordDeleted;
            bool isRecordCategoryDeleted;
            bool isDeleted = false;

            DialogResult result;
            //Confirm if user wants to delete the record
            result = MessageBox.Show("Do You Want to delete?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result.Equals(DialogResult.OK))
            {
                //Call DeleteUserCategory and DeleteUserRecord hepler classes
                //Get the RecordId from the click row and send it as the delete record parameter
                //Remove the dependancy from userRecordCategory table first                  
                DeleteUserCategoryhelper deleteUserCategory = new DeleteUserCategoryhelper();
                isRecordCategoryDeleted = deleteUserCategory.DeleteEntity(((UserRecord)entity));  // Cast entity to UserRecord 
                DeleteUserRecordhelper deleteUserRecord = new DeleteUserRecordhelper();
                isRecordDeleted = deleteUserRecord.DeleteEntity(((UserRecord)entity));  // Cast entity to UserRecord
                if (isRecordDeleted && isRecordCategoryDeleted)
                {
                    MessageBox.Show("The record has been deleted.");
                    // display the result,cast view to MainForm and call MainForm update the Datagrid.
                    ((MainForm)view).DisplayUserRecordDataGrid();
                    isDeleted = true;
                }
                else
                {
                    MessageBox.Show("Something wrong.");
                    isDeleted = false;
                }
            }
            return isDeleted;
        }


    }
}
