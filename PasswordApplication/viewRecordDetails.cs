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
            Decryptor decryptor = new Decryptor();
            ViewRecordForm vrf = new ViewRecordForm();

            //Initial connection maker to make a connention 
            SQLServerConnMaker SQLconn = new SQLServerConnMaker();
            SqlConnection conn = SQLconn.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter();
            //Initial UserRecord entity
            UserRecord userRecord = (UserRecord)Entity;
            int recordID = userRecord.RecordID;
            string userName = userRecord.UserName;
            string userPassword = userRecord.UserPassword;
            string serviceName = userRecord.ServiceName;
            string note = userRecord.Note;
            string categoryName = userRecord.CategoryName;



            try
            {
                conn.Open();

                vrf.GrabRecordID = userRecord.RecordID;
                vrf.CategoryOptionComboBox.Items.Add(categoryName);
                vrf.CategoryOptionComboBox.SelectedIndex = 0;
                vrf.UserNameTextBox.Text = userName;
                vrf.PasswordTextBox.Text = decryptor.AESDecrypt256(userPassword);
                vrf.PasswordTextBox.PasswordChar = '*';
                vrf.NoteTextBox.Text = note;
                vrf.ServiceNameTextBox.Text = serviceName;

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
