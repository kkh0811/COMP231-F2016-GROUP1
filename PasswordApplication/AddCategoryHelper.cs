using PasswordApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordApplication.AbstractClass;
using PasswordApplication.Model;
using System.Data.SqlClient;

namespace PasswordApplication
{
    /// <summary>
    /// Add new category from the view, save category record to Categories table accept Entities(UserAccount,Category).
    /// </summary>
    class AddCategoryHelper : ISave
    {
        public bool SaveEntity(AbDatabaseEntity[] Entity)
        {
            int successRow;
            bool isInsertSuccess = false;

            //Initial connection maker to make a connection 
            SQLServerConnMaker SQLconn = new SQLServerConnMaker();
            SqlConnection conn = SQLconn.Connect();
            //Initial Catrogry entity
            Category category = (Category)Entity[0];


            // Create the Insert category command.
            // Insert record to Categories table
            SqlCommand insertCategotyRecordCmd;
            insertCategotyRecordCmd =  new SqlCommand(
                    "INSERT INTO Categories VALUES (@CategoryName,@userAccountID)", conn);
            //Add the parameters for the insertCommand
            insertCategotyRecordCmd.Parameters.AddWithValue("@CategoryName", category.CategoryName);
            insertCategotyRecordCmd.Parameters.AddWithValue("@UserAccountID", category.UserAccountId);
            try
            {
                conn.Open();
                //Assume the userAccountID is 1 for Release 1
                successRow = insertCategotyRecordCmd.ExecuteNonQuery();
                if (successRow > 0)
                {
                    isInsertSuccess = true;
                }
                else
                {
                    isInsertSuccess = false;
                }

            }
            catch (Exception e)
            {
                //show error in output
                Console.WriteLine(e.ToString());
            }
            finally
            {
                conn.Close();
            }
            return isInsertSuccess;
        }
        
    }
}
