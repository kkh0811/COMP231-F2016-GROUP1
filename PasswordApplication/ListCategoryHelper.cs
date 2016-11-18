using PasswordApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordApplication.AbstractClass;
using System.Data.SqlClient;
using PasswordApplication.Model;

namespace PasswordApplication
{
    /// <summary>
    /// Get the categories from the categories table, return SqlDataAdapter for populating the data to view
    /// </summary>
    class ListCategoryHelper : ISelect
    {
        public SqlDataAdapter SelectEntity(AbDatabaseEntity Entity)
        {
            //Initial connection maker to make a connection 
            SQLServerConnMaker SQLconn = new SQLServerConnMaker();
            SqlConnection conn = SQLconn.Connect();

            SqlDataAdapter adapter = new SqlDataAdapter();
            // Create the SelectCategoryCommand. Assume UserAccountID is 1
            SqlCommand command = new SqlCommand(
                "SELECT CategoryID, CategoryName FROM Categories WHERE UserAccountID = @UserAccountID", conn);
            command.Parameters.AddWithValue("@UserAccountID", ((Category)Entity).UserAccountId);
            // set selectCommand as selectCategory
            adapter.SelectCommand = command;

            return adapter;

            throw new NotImplementedException();
        }
    }
}
