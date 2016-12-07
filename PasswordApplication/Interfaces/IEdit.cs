using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordApplication.AbstractClass;

namespace PasswordApplication.Interfaces
{
    /// <summary>
    /// Edit/Update User Record,Category,User Account to Database
    /// Return bool value if the update is success.
    /// Any class implement IEdit can update any kind of databaseEntity
    /// Ex. class EditUserRecordhelper : IEdit
    ///     {
    ///         EditEntity(UserRecord);
    ///     }
    ///     class EditCategoryHelper : IEdit
    ///     {
    ///         EditEntity(Category);
    ///     }
    /// </summary>
    interface IEdit
    {
        //DatabaseEntity can be UserRecord,Category,UserAccount
        bool EditEntity(params AbDatabaseEntity[] Entity);
    }
}
