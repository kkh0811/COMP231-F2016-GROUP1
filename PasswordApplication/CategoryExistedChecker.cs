﻿using PasswordApplication.AbstractClass;
using PasswordApplication.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

[assembly: InternalsVisibleTo("PasswordAppUTest")]
namespace PasswordApplication
{
    class CategoryExistedChecker
    {

        public bool checkIsCategoryExisted(AbDatabaseEntity entity)
        {


            //Get the category table category name
            DataSet ResultSet = new DataSet();

            //ListCategoryHelper's selectEntity() return SqlDataAdapter
            ListCategoryHelper categoryList = new ListCategoryHelper();
            categoryList.SelectEntity(entity).Fill(ResultSet, "Categories");

            if (ResultSet.Tables.Count > 0)
            {
                //Check if the category name already in the category table
                foreach (DataRow row in ResultSet.Tables[0].Rows)
                {
                    if (((Category)entity).CategoryName.ToUpper() == row["CategoryName"].ToString().ToUpper())
                    {
                        MessageBox.Show("Category name already exists.");
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
