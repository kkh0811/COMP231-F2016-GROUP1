using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.Common;
using System.Data.SqlClient;
using PasswordApplication.Interfaces;
using PasswordApplication.Model;
using PasswordApplication.AbstractClass;
namespace PasswordApplication
{
    class viewRecordDetails : IView
    {
        public bool SelectEntity(AbDatabaseEntity Entity)
        {
            ViewRecordForm vrf = new ViewRecordForm();
            //DataAdapter adapter;

            //Initial connection maker to make a connention 
            SQLServerConnMaker SQLconn = new SQLServerConnMaker();
            SqlConnection conn = SQLconn.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter();
            //Initial UserRecord entity
            UserRecord userRecord = (UserRecord)Entity;
           

            try
            {
                conn.Open();

                vrf.GrabRecordID = userRecord.RecordID;
                vrf.CategoryOptionComboBox.Items.Add(userRecord.CategoryName);
                vrf.CategoryOptionComboBox.SelectedIndex = 0;
                vrf.UserNameTextBox.Text = userRecord.UserName;
                vrf.PasswordTextBox.Text = userRecord.UserPassword;
                vrf.PasswordTextBox.PasswordChar = '*';
                vrf.NoteTextBox.Text = userRecord.Note;
                vrf.ServiceNameTextBox.Text = userRecord.ServiceName;



            }
            finally
            {
                conn.Close();
            }

            vrf.Show();

            return true;
        }
    }
}
