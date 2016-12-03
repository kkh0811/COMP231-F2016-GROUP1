using System;
using PasswordApplication.AbstractClass;
using PasswordApplication.Interfaces;
using System.Data.SqlClient;
using PasswordApplication.Model;

namespace PasswordApplication.Controller
{
    internal class UpdateUserRecord_categoryHelper : IEdit
    {
        bool isUpdated;
        public bool EditEntity(AbDatabaseEntity Entity)
        {
            //Initial connection maker to make a connention 
            SQLServerConnMaker SQLconn = new SQLServerConnMaker();
            SqlConnection conn = SQLconn.Connect();
            //Initial UserRecord entity
            Category category = (Category)Entity;

            // Delete record from UserRecordCategories table
            SqlCommand updateCategoryCmd;
            updateCategoryCmd = new SqlCommand("UPDATE UserRecord SET CategoryName = '' WHERE CategoryName = @categoryName AND UserAccountID = @UserAccountId ;", conn);

            // Add the parameters for the DeleteCommand.
            updateCategoryCmd.Parameters.AddWithValue("@categoryName", category.CategoryName);
            updateCategoryCmd.Parameters.AddWithValue("@UserAccountId", 1);


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