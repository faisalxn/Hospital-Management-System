using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Hospital_Management_System
{
    class testDAO
    {
        sqlDatabase s;
        public testDAO()
        {
            s = new sqlDatabase();
        }

        public DataSet getTests() {
            s.sqlConnection.Open();
            string query = "select * from tests";
            s.sqlCommand = new SqlCommand(query, s.sqlConnection);
            s.sqlAdapter = new SqlDataAdapter(s.sqlCommand);
            s.dataSet = new DataSet();
            s.sqlAdapter.Fill(s.dataSet);
            s.sqlConnection.Close();
            return s.dataSet;
        }

        public void updateTest(testDTO t)
        {
            s.sqlConnection.Open();
            string query = "update tests set name = '"
                + t.Name + "', category = '"
                + t.Category + "', roomNo = '"
                + t.RoomNo + "', price = '"
                + t.Price + "' where testId = '"
                + t.TestId + "' ";
            s.sqlCommand = new SqlCommand(query, s.sqlConnection);
            s.sqlCommand.ExecuteNonQuery();
            s.sqlConnection.Close();
        }

        public void createTest(testDTO t)
        {
            s.sqlConnection.Open();
            string query = "insert into tests values('"+ t.Name + "','"
                                                       + t.Category + "','"
                                                       + t.RoomNo + "','"
                                                       + t.Price + "')";
            s.sqlCommand = new SqlCommand(query, s.sqlConnection);
            s.sqlCommand.ExecuteNonQuery();
            s.sqlConnection.Close();
        }
        public void deleteTest(testDTO t)
        {
            s.sqlConnection.Open();
            string query = "delete from tests where testId = '" + t.TestId + "'";
            s.sqlCommand = new SqlCommand(query, s.sqlConnection);
            s.sqlCommand.ExecuteNonQuery();
            s.sqlConnection.Close();
        }


    }
}
