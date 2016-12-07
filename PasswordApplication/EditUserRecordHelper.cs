using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordApplication.AbstractClass;
using PasswordApplication.Interfaces;
using System.Data.SqlClient;
using PasswordApplication.Model;

namespace PasswordApplication
{
    /// <summary>
    /// Delete Record from User Record table, accept Entity(UserRecord,UserAccount,Category)
    /// </summary>
    class EditUserRecordhelper : IEdit
    {
        public bool EditEntity(params AbDatabaseEntity[] Entity)
        {
            //Initial connection maker to make a connection 
            SQLServerConnMaker SQLconn = new SQLServerConnMaker();
            SqlConnection conn = SQLconn.Connect();

            //Initialize UserRecord entity
            UserRecord userRecord = (UserRecord)Entity[0];
            //Category category = (Category)Entity[1];
            // Create the update command.
            // update record from UserRecord table
            SqlCommand editUserRecordCmd;

            editUserRecordCmd = new SqlCommand(@"UPDATE UserRecord SET UserName= @Username, UserPassword= @Password, 
                        ServiceName = @ServiceName, CategoryName = @CategoryName, Note= @Notes WHERE RecordID= @RecordID;", conn);
            //return bool value of recordUpdated
            bool recordUpdated = false;
            try
            {
                conn.Open();
                // Add the parameters for the Updated Command.
                editUserRecordCmd.Parameters.AddWithValue("@RecordID", userRecord.RecordID);
                editUserRecordCmd.Parameters.AddWithValue("@Username", userRecord.UserName);
                editUserRecordCmd.Parameters.AddWithValue("@Password", userRecord.UserPassword);
                editUserRecordCmd.Parameters.AddWithValue("@ServiceName", userRecord.ServiceName);
                editUserRecordCmd.Parameters.AddWithValue("@CategoryName", userRecord.CategoryName);
                editUserRecordCmd.Parameters.AddWithValue("@Notes", userRecord.Note);
                //editUserRecordCmd.Parameters.AddWithValue("@UserAccount", 1);
                if (editUserRecordCmd.ExecuteNonQuery() > 0)
                {
                    recordUpdated = true;
                }
                else
                {
                    recordUpdated = false;
                }
            }
            catch (Exception e)
            {
                //show error in output
                Console.WriteLine(e.ToString());
                recordUpdated = false;
            }
            finally
            {
                SQLconn.Connect().Close();
            }
            return recordUpdated;
            throw new NotImplementedException();
        }
    }
}
