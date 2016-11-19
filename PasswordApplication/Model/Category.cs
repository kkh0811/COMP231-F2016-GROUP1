using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordApplication.AbstractClass;
namespace PasswordApplication.Model
{
    /// <summary>
    /// Represent one Category record from categories table
    /// </summary>
    class Category : AbDatabaseEntity
    {
        //CategoryID in Categories table
        public int CategoryID { get; set; }

        //CategoryName in Categories table
        public string CategoryName { get; set; }

        //UserAccountId in UserAccount table
        public int UserAccountId { get; set; }
    }
}
