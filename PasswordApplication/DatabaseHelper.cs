using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordApplication
{
    /// <summary>
    /// Use to set up database Connection, fetch data from db and return BindingSource to whoever uses the Connection.
    /// </summary>
    class DatabaseHelper
    {
        //Define data source and data adapter
        private BindingSource bindingSource = new BindingSource();


        private SqlDataAdapter dataAdapter = new SqlDataAdapter(); 

        //define variables
        private string pUsername;
        private string pPassword;
        private string pNote;
        private string pCategory;
        private int pRecordID;
        //setting accessors
        public string PassUserName
        {
            get { return pUsername; }
            set { pUsername = value; }
        }
        public string PassPassword
        {
            get { return pPassword; }
            set { pPassword = value; }
        }
        public string PassNote
        {
            get { return pNote; }
            set { pNote = value; }
        }
        public string PassCategory
        {
            get { return pCategory; }
            set { pCategory = value; }
        }
        public int PassRecordID
        {
            get { return pRecordID; }
            set { pRecordID = value; }
        }

        // Specify a Connection string. Replace the given value with a 
        // valid Connection string for a production database accessible to your system.
        private static String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.Environment.CurrentDirectory + "\\Hexalogydb.mdf;Integrated Security=True";


        //SQLconnection object
        private static SqlConnection conn = new SqlConnection(connectionString);


        //Connecting to database and get the data for certain SQL statement
        public BindingSource GetData(string sqlCommand)
        {
            try
            {

                // Create a new data adapter based on the specified query.
                dataAdapter = new SqlDataAdapter(sqlCommand, connectionString);
                // Create a command builder to generate SQL update, insert, and
                // delete commands based on sqlCommand. These are used to
                // update the database.
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource.DataSource = table;

            }
            catch (SqlException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a Connection string that is " +
                    "valid for your system.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception.Message: {0}", ex.Message);
            }
            finally
            {

            }

            return bindingSource;
        }

        //Insert record
        public void passInput()
        {
            //specify Connection string here
            //SqlConnection conn = new SqlConnection(connectionString);
            //SqlCommand cmd;
            //SqlDataAdapter adpt;

            //input SQL Commands
            try
            {
                /*
                conn.Open();   
                //calling methods to demonstrate sqlCommand capabilities
                cmd = new SqlCommand("dbo.AddRecord", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@categoryName", SqlDbType.VarChar).Value = PassCategory;
                cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = pUsername;
                cmd.Parameters.Add("@pw", SqlDbType.VarChar).Value = pPassword;
                cmd.Parameters.Add("@note", SqlDbType.VarChar).Value = pNote;
                cmd.ExecuteNonQuery();
                */
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
        }

        
        public static SqlDataAdapter manupulateCategory(int userAccountID,string categoryName = "")
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            // Create the SelectCategoryCommand.
            SqlCommand command = new SqlCommand(
                "SELECT CategoryID, CategoryName FROM Categories WHERE UserAccountID = @UserAccountID", conn);

            // Add the parameters for the SelectCommand.
            command.Parameters.AddWithValue("@UserAccountID", userAccountID);
            // set selectCommand as selectCategory
            adapter.SelectCommand = command;

            // Create the InsertCategoryCommand
            SqlCommand insertCommand = new SqlCommand(
                "INSERT INTO Categories VALUES (@CategoryName,@userAccountID)",conn
                );
            //Add the parameters for the insertCommand
            insertCommand.Parameters.AddWithValue("@CategoryName", categoryName);
            insertCommand.Parameters.AddWithValue("@UserAccountID", userAccountID);
            // Set InsertCommand as insertCommand
            adapter.InsertCommand = insertCommand;

            return adapter;

        }
		public void UpdateRecord()
        {
            //specify Connection string here
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd;
            //input SQL Command
            try
            {
                //commands goes here
                cmd = new SqlCommand(@"UPDATE UserRecord SET UserName= @Username, UserPassword= @Password, Note= @Notes WHERE RecordID= @RecordID;", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Username", pUsername);
                cmd.Parameters.AddWithValue("@Password", pPassword);
                cmd.Parameters.AddWithValue("@Notes", pNote);
                cmd.Parameters.AddWithValue("@RecordID", pRecordID);
                conn.Open();


                cmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {

                //show error input
                Console.WriteLine(e.ToString());
            }
            finally
            {
                conn.Close();
            }

        }


        public static bool addNewCategory(string categoryName)
        {
            int successRow;
            bool isInsertSuccess = false;
            try
            {
                conn.Open();
                //Assume the userAccountID is 1
                successRow = manupulateCategory(1, categoryName).InsertCommand.ExecuteNonQuery();
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

        /*
        //create customerAdapter for delete,edit,view(select),new command
        public static SqlDataAdapter CreateRecordAdapter()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            // Create the SelectCommand.
            SqlCommand command = new SqlCommand("SELECT * FROM Customers " +
                "WHERE Country = @Country AND City = @City", conn);

            // Add the parameters for the SelectCommand.
            command.Parameters.Add("@Country", SqlDbType.NVarChar, 15);
            command.Parameters.Add("@City", SqlDbType.NVarChar, 15);

            adapter.SelectCommand = command;

            // Create the InsertCommand.
            command = new SqlCommand(
                "INSERT INTO Customers (CustomerID, CompanyName) " +
                "VALUES (@CustomerID, @CompanyName)", conn);

            // Add the parameters for the InsertCommand.
            command.Parameters.Add("@CustomerID", SqlDbType.NChar, 5, "CustomerID");
            command.Parameters.Add("@CompanyName", SqlDbType.NVarChar, 40, "CompanyName");

            adapter.InsertCommand = command;

            // Create the UpdateCommand.
            command = new SqlCommand(
                "UPDATE Customers SET CustomerID = @CustomerID, CompanyName = @CompanyName " +
                "WHERE CustomerID = @oldCustomerID", conn);

            // Add the parameters for the UpdateCommand.
            command.Parameters.Add("@CustomerID", SqlDbType.NChar, 5, "CustomerID");
            command.Parameters.Add("@CompanyName", SqlDbType.NVarChar, 40, "CompanyName");
            SqlParameter parameter = command.Parameters.Add(
                "@oldCustomerID", SqlDbType.NChar, 5, "CustomerID");
            parameter.SourceVersion = DataRowVersion.Original;

            adapter.UpdateCommand = command;

            // Create the DeleteCommand.
            command = new SqlCommand(
                "DELETE FROM Customers WHERE CustomerID = @CustomerID", Connection);

            // Add the parameters for the DeleteCommand.
            parameter = command.Parameters.Add(
                "@CustomerID", SqlDbType.NChar, 5, "CustomerID");
            parameter.SourceVersion = DataRowVersion.Original;

            adapter.DeleteCommand = command;

            return adapter;
        }*/


    }
}
