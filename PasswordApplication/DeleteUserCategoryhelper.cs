using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordApplication.Interfaces;
using PasswordApplication.AbstractClass;
using PasswordApplication.Model;
using System.Data.SqlClient;

namespace PasswordApplication
{
    /// <summary>
    /// Delete Record from User Record table, accept Entity(UserRecord,UserAccount,Category)
    /// </summary>
    class DeleteUserCategoryhelper : IDelete
    {
        bool isDeleted;
        public bool DeleteEntity(AbDatabaseEntity Entity)
        {
            //Initial connection maker to make a connention 
            SQLServerConnMaker SQLconn = new SQLServerConnMaker();
            SqlConnection conn = SQLconn.Connect();
            //Initial UserRecord entity
            UserRecord userRecord = (UserRecord)Entity;

            // Delete record from UserRecordCategories table
            SqlCommand deleteUserCategoryCmd;
            deleteUserCategoryCmd = new SqlCommand("DELETE FROM UserRecordCategories WHERE RecordID = @RecordID;", conn);

            // Add the parameters for the DeleteCommand.
            deleteUserCategoryCmd.Parameters.AddWithValue("@RecordID", userRecord.RecordID);

            try
            {
                conn.Open();
                if (deleteUserCategoryCmd.ExecuteNonQuery() >= 1)
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
