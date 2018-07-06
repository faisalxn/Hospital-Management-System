using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Hospital_Management_System
{
    class passwordDAO
    {
        sqlDatabase s;
        public passwordDAO()
        {
            s = new sqlDatabase();
        }

        public DataSet getPassword() {
            s.sqlConnection.Open();
            string query = "select * from passwords";
            s.sqlCommand = new SqlCommand(query, s.sqlConnection);
            s.sqlAdapter = new SqlDataAdapter(s.sqlCommand);
            s.dataSet = new DataSet();
            s.sqlAdapter.Fill(s.dataSet);
            s.sqlConnection.Close();
            return s.dataSet;
        }

        public void updatePassword(passwordDTO p)
        {
            s.sqlConnection.Open();
            string query = "update passwords set password = '"
                + p.Password + "' where userName = 'admin'";
            s.sqlCommand = new SqlCommand(query, s.sqlConnection);
            s.sqlCommand.ExecuteNonQuery();
            s.sqlConnection.Close();
        }



    }
}
