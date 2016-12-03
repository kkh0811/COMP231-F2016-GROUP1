using PasswordApplication.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordApplication.Interfaces
{
    /// <summary>
    /// Update User Record,Category,User Account to Database
    /// Return bool value if the update is success.
    /// Any class implement IEdit can update any kind of databaseEntity
    /// Ex. class UpdateUserRecord_UpdateCategoryhelper : IEdit
    ///     {
    ///         UpdateEntity(Category);
    ///     }
    /// </summary>
    interface IUpdate
    {
        //DatabaseEntity can be UserRecord,Category,UserAccount
        //First Entity is the oldEntity, second Entity is the new Entity to be updated
        bool UpdateEntity(params AbDatabaseEntity[] Entity);
    }
}
