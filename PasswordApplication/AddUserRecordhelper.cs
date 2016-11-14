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
            bool recordAdded;


            try
            {
                conn.Open();
                //calling methods to demonstrate sqlCommand capabilities
                addUserRecord = new SqlCommand("dbo.AddRecord", conn);
                addUserRecord.CommandType = CommandType.StoredProcedure;
                addUserRecord.Parameters.Add("@categoryID", SqlDbType.VarChar).Value = category.CategoryID;
                addUserRecord.Parameters.Add("@id", SqlDbType.VarChar).Value = userRecord.UserName;
                addUserRecord.Parameters.Add("@pw", SqlDbType.VarChar).Value = userRecord.UserPassword;
                addUserRecord.Parameters.Add("@note", SqlDbType.VarChar).Value = userRecord.Note;
                addUserRecord.ExecuteNonQuery();
                
                if(addUserRecord.ExecuteNonQuery() >= 1)
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
