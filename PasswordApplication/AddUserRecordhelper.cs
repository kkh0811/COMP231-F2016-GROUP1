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
        public bool SaveEntity(AbDatabaseEntity[] Entity)
        {
            //start the connection string
            SQLServerConnMaker SQLconn = new SQLServerConnMaker();
            //initialize user record values
            UserRecord userRecord = (UserRecord)Entity[0];
            //initialize user record category
            UserRecordCategory userRecordCategory = (UserRecordCategory)Entity[0];

            //create the SQL command to add user input
            SqlCommand addUserRecord;

            try
            {
                SQLconn.Connect().Open();
                //calling methods to demonstrate sqlCommand capabilities
                addUserRecord = new SqlCommand("dbo.AddRecord", SQLconn.Connect());
                addUserRecord.CommandType = CommandType.StoredProcedure;
                
                //addUserRecord.Parameters.Add("@categoryName", SqlDbType.VarChar).Value = 
                addUserRecord.Parameters.Add("@id", SqlDbType.VarChar).Value = userRecord.UserName;
                addUserRecord.Parameters.Add("@pw", SqlDbType.VarChar).Value = userRecord.UserPassword;
                addUserRecord.Parameters.Add("@note", SqlDbType.VarChar).Value = userRecord.Note;
                addUserRecord.ExecuteNonQuery();
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
