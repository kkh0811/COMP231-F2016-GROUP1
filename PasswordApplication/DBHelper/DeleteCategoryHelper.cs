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
    /// Delete Record from Categories table, accept Entity (Category) 
    /// </summary>
    class DeleteCategoryHelper : IDelete
    {
        bool isDeleted;
        public bool DeleteEntity(AbDatabaseEntity Entity)
        {
            //Initial connection maker to make a connention 
            SQLServerConnMaker SQLconn = new SQLServerConnMaker();
            SqlConnection conn = SQLconn.Connect();
            //Initial UserRecord entity
            Category category = (Category)Entity;

            // Delete record from UserRecordCategories table
            SqlCommand deleteCategoryCmd;
            deleteCategoryCmd = new SqlCommand("DELETE FROM Categories WHERE CategoryID = @categoryID;", conn);

            // Add the parameters for the DeleteCommand.
            deleteCategoryCmd.Parameters.AddWithValue("@categoryID", category.CategoryID);

            try
            {
                conn.Open();
                if (deleteCategoryCmd.ExecuteNonQuery() >= 1)
                { isDeleted = true; }
                else
                { isDeleted = false; }
            }
            catch (Exception e)
            {
                //show error in output
                Console.WriteLine(e.ToString());
                isDeleted = false;
            }
            finally
            {
                conn.Close();
            }
            return isDeleted;
        }
    }
}
