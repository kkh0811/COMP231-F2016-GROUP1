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
    /// <summary>
    /// 
    /// </summary>
    class EditUserRecordController
    {
        //create Form view object to call back method and update
        Form view;
        //entity to resemble table from db
        AbDatabaseEntity entity;
        //editHelper class to handle the database commands
        IEdit editHelper;
        //instantiate objs

        //Constructor
        public EditUserRecordController(Form _view, AbDatabaseEntity _entity)
        {
            this.view = _view;
            this.entity = _entity;

        }
        public EditUserRecordController(Form _view,params AbDatabaseEntity[] _entity)
        {
            this.view = _view;
            this.entity = _entity[0];
            this.entity = _entity[1];
        }

        //call the username
        public bool EditUserName()
        {
            bool isValid = false; 
            //validate username
            UserNameValidator usernameValidator = new UserNameValidator();
            if(!usernameValidator.Validate(((UserRecord)entity).UserName))
            {
                isValid = false;
            }
            else
            {
                isValid = true;
            }
            return isValid;
        }
        public bool EditPassword()
        {
            bool isValid = false;
            //validate password
            PasswordValidator passwordValidator = new PasswordValidator();
            if(!passwordValidator.Validate(((UserRecord)entity).UserPassword))
            {
                isValid = false;
            }
            else
            {
                isValid = true;
            }
            return isValid;
        }
        public bool EditServiceName()
        {
            bool isValid = false;
            //validate the service name text
            ServiceNameValidator serviceValidator = new ServiceNameValidator();
            if(!serviceValidator.Validate(((UserRecord)entity).ServiceName))
            {
                isValid = false;
            }
            else
            {
                isValid = true;
            }
            return isValid;
        }
        public bool EditNote()
        {
            bool isValid = false;
            //validate the note text
            NoteValidator noteValidator = new NoteValidator();
            if(!noteValidator.Validate(((UserRecord)entity).Note))
            {
                isValid = false;
            }
            else
            {
                isValid = true;
            }
            return isValid;
        }
        public bool UpdateRecord()
        {
            bool isUpdated = false;

            editHelper = new EditUserRecordhelper();

            if (editHelper.EditEntity(entity))
            {
                isUpdated = true;
            }
            else
            {
                isUpdated = false;
            }
            return isUpdated;
        }
    }
}
