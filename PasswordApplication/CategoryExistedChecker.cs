using PasswordApplication.AbstractClass;
using PasswordApplication.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordApplication
{
    class CategoryExistedChecker
    {

        public bool checkIsCategoryExisted(AbDatabaseEntity entity)
        {

            //Initial connection maker to make a connection 
            SQLServerConnMaker SQLconn = new SQLServerConnMaker();
            SqlConnection conn = SQLconn.Connect();

            //Get the category table category name
            DataSet ResultSet = new DataSet();

            SqlDataAdapter adapter = new SqlDataAdapter();
            // Create the SelectCategoryCommand. Assume UserAccountID is 1
            SqlCommand command = new SqlCommand(
                "SELECT CategoryID, CategoryName FROM Categories WHERE UserAccountID = @UserAccountID", conn);
            command.Parameters.AddWithValue("@UserAccountID", ((Category)entity).UserAccountId);
            // set selectCommand as selectCategory
            adapter.SelectCommand = command;

            adapter.Fill(ResultSet, "Categories");

            if (ResultSet.Tables.Count > 0)
            {
                //Check if the category name already in the category table
                foreach (DataRow row in ResultSet.Tables[0].Rows)
                {
                    if (((Category)entity).CategoryName.ToUpper() == row["CategoryName"].ToString().ToUpper())
                    {
                        MessageBox.Show("Category name alreay existed.");
                        return true;
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        


        

  
    }
}
