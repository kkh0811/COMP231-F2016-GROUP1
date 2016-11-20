using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordApplication.AbstractClass;
using PasswordApplication.Interfaces;
using System.Data.SqlClient;
using PasswordApplication.Model;
using System.Data;

namespace PasswordApplication
{
    class AddUserRecordhelper : ISave
    {
        public bool SaveEntity(params AbDatabaseEntity[] Entity)
        {
            //start the connection string
            SQLServerConnMaker SQLconn = new SQLServerConnMaker();
            SqlConnection conn = SQLconn.Connect();
            //initialize user record  and category values
            UserRecord userRecord = (UserRecord)Entity[0];
            Category category = (Category)Entity[1];
            //create the SQL command to add user input
            SqlCommand addUserRecord;
            bool recordAdded = false;


            try
            {
                conn.Open();
                //calling methods to demonstrate sqlCommand capabilities

                string insertNewRecord = "INSERT INTO UserRecord VALUES(@UserName,@UserPassword,@ServiceName,@Note,@UserAccountID,@CategoryName)";
                addUserRecord = new SqlCommand(insertNewRecord, conn);
                addUserRecord.Parameters.AddWithValue("@UserName", userRecord.UserName);
                addUserRecord.Parameters.AddWithValue("@UserPassword", userRecord.UserPassword);
                addUserRecord.Parameters.AddWithValue("@ServiceName", userRecord.ServiceName);
                addUserRecord.Parameters.AddWithValue("@Note", userRecord.Note);
                addUserRecord.Parameters.AddWithValue("@UserAccountID", 1); // This will be modified in the future.
                addUserRecord.Parameters.AddWithValue("@CategoryName", category.CategoryName); // Need to change to CategoryName

                if (addUserRecord.ExecuteNonQuery() > 0)
                {
                    recordAdded = true;
                }
                else
                {
                    recordAdded = false;
                }

            }
            catch (Exception e)
            {
                //show error in output
                Console.WriteLine(e.ToString());
                recordAdded = false;
            }
            finally
            {
                conn.Close();
            }
            return recordAdded;
        }
    }
}
