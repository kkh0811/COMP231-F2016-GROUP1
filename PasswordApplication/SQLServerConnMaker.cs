using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordApplication.Interfaces;
using System.Data.SqlClient;

namespace PasswordApplication
{
    /// <summary>
    /// Keep the connction string only in here.
    /// If need, just call SQLServerConnMake-->Connect() to return the SQL connection;
    /// </summary>
    class SQLServerConnMaker : IDatabaseConnection
    {

        private static String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.Environment.CurrentDirectory + "\\Hexalogydb.mdf;Integrated Security=True";
        public SqlConnection Connect()
        {
            //Return SqlConnection for the connectionString
            return new SqlConnection(connectionString);
        }

    }
}
