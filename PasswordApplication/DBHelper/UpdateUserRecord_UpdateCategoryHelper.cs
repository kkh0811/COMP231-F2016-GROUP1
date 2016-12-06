using PasswordApplication.AbstractClass;
using PasswordApplication.Interfaces;
using PasswordApplication.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordApplication.DBHelper
{
    /// <summary>
    /// Update category name to UserRecord table,change old categoryName to new categoryName, accept old category entity, new category entity.
    /// </summary>
    class UpdateUserRecord_UpdateCategoryHelper : IUpdate
    {

        bool isUpdated;
        public bool UpdateEntity(AbDatabaseEntity[] Entity)
        {
            //Initial connection maker to make a connention 
            SQLServerConnMaker SQLconn = new SQLServerConnMaker();
            SqlConnection conn = SQLconn.Connect();
            //Initial UserRecord entity
            Category oldCategory = (Category)Entity[0];
            Category newCategory = (Category)Entity[1];

            // Delete record from UserRecordCategories table
            SqlCommand updateCategoryCmd;
            updateCategoryCmd = new SqlCommand("UPDATE UserRecord SET CategoryName = @newCategory WHERE CategoryName = @oldCategory AND UserAccountID = @UserAccountId;", conn);

            // Add the parameters for the DeleteCommand.
            updateCategoryCmd.Parameters.AddWithValue("@oldCategory", oldCategory.CategoryName);
            updateCategoryCmd.Parameters.AddWithValue("@newCategory", newCategory.CategoryName);
            updateCategoryCmd.Parameters.AddWithValue("@UserAccountId", newCategory.UserAccountId);

            try
            {
                conn.Open();
                if (updateCategoryCmd.ExecuteNonQuery() >= 1)
                { isUpdated = true; }
                else
                { isUpdated = false; }
            }
            catch (Exception e)
            {
                //show error in output
                Console.WriteLine(e.ToString());
                isUpdated = false;
            }
            finally
            {
                conn.Close();
            }
            return isUpdated;
        }

    }
}
