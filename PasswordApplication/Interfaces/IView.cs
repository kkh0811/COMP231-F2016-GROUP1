using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordApplication.AbstractClass;

namespace PasswordApplication.Interfaces
{
    /// <summary>
    /// Select User Record,Category,User Account from Database
    /// Return boolean from select command.
    /// </summary>
    interface IView
    {

        //DatabaseEntity can be UserRecord,Category,UserAccount
        bool SelectEntity(AbDatabaseEntity Entity);
    }
}
