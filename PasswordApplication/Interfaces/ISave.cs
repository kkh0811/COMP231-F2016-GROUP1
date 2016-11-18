using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordApplication.AbstractClass;

namespace PasswordApplication.Interfaces
{
    /// <summary>
    /// Save User Record,Category,User Account to Database
    /// Return bool value if save record is success.
    /// Any class implement ISave can save any kind of databaseEntity
    /// Ex. class SaveUserRecordhelper : ISave
    ///     {
    ///         SaveEntity(UserRecord);
    ///     }
    ///     class SaveCategoryHelper : IDelete
    ///     {
    ///         SaveEntity(Category);
    ///     }
    /// </summary>
    interface ISave
    { 
        //DatabaseEntity can be UserRecord,Category,UserAccount
        bool SaveEntity(params AbDatabaseEntity[] Entity);
    }
}
