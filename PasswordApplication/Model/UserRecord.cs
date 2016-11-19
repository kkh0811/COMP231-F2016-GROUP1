using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordApplication.AbstractClass;

namespace PasswordApplication.Model
{
    /// <summary>
    /// Represent one record from UserRecord table
    /// </summary>
    class UserRecord : AbDatabaseEntity
    {
        //RecordID in the UserRecors table
        public int RecordID { get; set; }

        //UserName in the UserRecord table
        public string UserName { get; set; }

        //UserPassword in the UserRecors table
        public string UserPassword { get; set; }

        //Note in the UserRecord table
        public string Note { get; set; }

        //AppName in the UserRecord table
        public string ServiceName { get; set; }
        
        //CategoryName in the UserRecord Table
        public string CategoryName { get; set; }

    }
}
