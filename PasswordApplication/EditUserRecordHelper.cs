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
        public bool EditEntity(AbDatabaseEntity[] Entity)
        {
            //Initial connection maker to make a connection 
            SQLServerConnMaker SQLconn = new SQLServerConnMaker();

            //Initial UserRecord entity
            UserRecord userRecord = (UserRecord)Entity[0];
            Category category = (Category)Entity[1];
            // Create the DeleteCommand.
            // Delete record from UserRecord table
            SqlCommand editUserRecordCmd;
            editUserRecordCmd = new SqlCommand(@"UPDATE UserRecord SET UserName= @Username, UserPassword= @Password, Note= @Notes , CategoryName = @CategoryName WHERE RecordID= @RecordID AND UserAccountID = @UserAccount;", SQLconn.Connect());


            // Add the parameters for the DeleteCommand.
            editUserRecordCmd.Parameters.AddWithValue("@RecordID", userRecord.RecordID);
            editUserRecordCmd.Parameters.AddWithValue("@Username", userRecord.UserName);
            editUserRecordCmd.Parameters.AddWithValue("@Password", userRecord.UserPassword);
            editUserRecordCmd.Parameters.AddWithValue("@CategoryName", category.CategoryName);
            editUserRecordCmd.Parameters.AddWithValue("@Notes", userRecord.Note);
            editUserRecordCmd.Parameters.AddWithValue("@RecordID", userRecord.RecordID);

            try
            {
                SQLconn.Connect().Open();
                using (editUserRecordCmd) { editUserRecordCmd.ExecuteNonQuery(); }
            }
            catch (Exception e)
            {
                //show error in output
                Console.WriteLine(e.ToString());
            }
            finally
            {
                SQLconn.Connect().Close();
            }
            throw new NotImplementedException();
        }
    }
}
