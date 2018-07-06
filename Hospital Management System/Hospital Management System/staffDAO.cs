using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Hospital_Management_System
{
    class staffDAO
    {
        sqlDatabase s;
        public staffDAO()
        {
            s = new sqlDatabase();
        }
        public DataSet getStaffs() {
            s.sqlConnection.Open();
            string query = "select * from staffs";
            s.sqlCommand = new SqlCommand(query, s.sqlConnection);
            s.sqlAdapter = new SqlDataAdapter(s.sqlCommand);
            s.dataSet = new DataSet();
            s.sqlAdapter.Fill(s.dataSet);
            s.sqlConnection.Close();
            return s.dataSet;
        }
        public void updateStaff(staffDTO st)
        {
            s.sqlConnection.Open();
            string query = "update staffs set name = '"
                + st.Name + "', gender = '"
                + st.Gender + "', age = '"
                + st.Age + "', roomNo = '"
                + st.RoomNo + "', phone = '"
                + st.Phone + "', salary = '"
                + st.Salary + "' where staffId = '"
                + st.StaffId + "' ";
            s.sqlCommand = new SqlCommand(query, s.sqlConnection);
            s.sqlCommand.ExecuteNonQuery();
            s.sqlConnection.Close();
        }
        public void createStaff(staffDTO st)
        {
            s.sqlConnection.Open();
            string query = "insert into staffs(name,gender,age,roomNo,phone,salary) values('"  + st.Name + "','"
                                                                                               + st.Gender + "','"
                                                                                               + st.Age + "','"
                                                                                               + st.RoomNo + "','"
                                                                                               + st.Phone + "','"
                                                                                               + st.Salary + "')";
            s.sqlCommand = new SqlCommand(query, s.sqlConnection);
            s.sqlCommand.ExecuteNonQuery();
            s.sqlConnection.Close();
        }
        public void deleteStaff(staffDTO st)
        {
            s.sqlConnection.Open();
            string query = "delete from staffs where staffId = '" + st.StaffId + "'";
            s.sqlCommand = new SqlCommand(query, s.sqlConnection);
            s.sqlCommand.ExecuteNonQuery();
            s.sqlConnection.Close();
        }
    }
}
