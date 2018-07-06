using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Hospital_Management_System
{
    class roomDAO
    {
        sqlDatabase s;
        public roomDAO()
        {
            s = new sqlDatabase();
        }

        public DataSet getRooms() {
            s.sqlConnection.Open();
            string query = "select * from rooms";
            s.sqlCommand = new SqlCommand(query, s.sqlConnection);
            s.sqlAdapter = new SqlDataAdapter(s.sqlCommand);
            s.dataSet = new DataSet();
            s.sqlAdapter.Fill(s.dataSet);
            s.sqlConnection.Close();
            return s.dataSet;
        }

        public void updateRoom(roomDTO r)
        {
            s.sqlConnection.Open();
            string query = "update rooms set price = '"
                + r.Price + "', roomType = '"
                + r.RoomType + "', staffId = '"
                + r.StaffId + "' where roomNo = '"
                + r.RoomNo + "' ";
            s.sqlCommand = new SqlCommand(query, s.sqlConnection);
            s.sqlCommand.ExecuteNonQuery();
            s.sqlConnection.Close();
        }

        public void createRoom(roomDTO r)
        {
            s.sqlConnection.Open();
            string query = "insert into rooms values('"+ r.RoomNo + "','"
                                                       + r.Price + "','"
                                                       + r.RoomType + "','"
                                                       + r.StaffId + "')";
            s.sqlCommand = new SqlCommand(query, s.sqlConnection);
            s.sqlCommand.ExecuteNonQuery();
            s.sqlConnection.Close();
        }
        public void deleteRoom(roomDTO r)
        {
            s.sqlConnection.Open();
            string query = "delete from rooms where roomNo = '" + r.RoomNo + "'";
            s.sqlCommand = new SqlCommand(query, s.sqlConnection);
            s.sqlCommand.ExecuteNonQuery();
            s.sqlConnection.Close();
        }

    }
}
