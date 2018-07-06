using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;



namespace Hospital_Management_System
{
    class patientDAO
    {
        sqlDatabase s;
        public patientDAO()
        {
            s = new sqlDatabase();
        }

        public DataSet getPatients() {
            s.sqlConnection.Open();
            string query = "select * from patients";
            s.sqlCommand = new SqlCommand(query, s.sqlConnection);
            s.sqlAdapter = new SqlDataAdapter(s.sqlCommand);
            s.dataSet = new DataSet();
            s.sqlAdapter.Fill(s.dataSet);
            s.sqlConnection.Close();
            return s.dataSet;
        }

        public void updatePatient(patientDTO p)
        {
            s.sqlConnection.Open();
            string query = "update patients set name = '"
                + p.Name + "', gender = '"
                + p.Gender + "', age = '"
                + p.Age + "', address = '"
                + p.Address + "', phone = '"
                + p.Phone + "', roomNo = '"
                + p.RoomNo + "', doctorId = '"
                + p.DoctorId + "', testId = '"
                + p.TestId + "', checkinDate = '"
                + p.CheckinDate + "' where patientId = '"
                + p.PatientId + "' ";
            s.sqlCommand = new SqlCommand(query, s.sqlConnection);
            s.sqlCommand.ExecuteNonQuery();
            s.sqlConnection.Close();
        }

        public void createPatient(patientDTO p)
        {
            s.sqlConnection.Open();
            string query = "insert into patients(name,gender,age,address,phone,roomNo,doctorId,testId,checkinDate) values('"+ p.Name + "','"
                                                               + p.Gender + "','"
                                                               + p.Age + "','"
                                                               + p.Address + "','"
                                                               + p.Phone + "','"
                                                               + p.RoomNo + "','"
                                                               + p.DoctorId + "','"
                                                               + p.TestId + "','"
                                                               + p.CheckinDate + "')";
            s.sqlCommand = new SqlCommand(query, s.sqlConnection);
            s.sqlCommand.ExecuteNonQuery();
            s.sqlConnection.Close();
        }
        public void deletePatient(patientDTO p)
        {
            s.sqlConnection.Open();
            string query = "delete from patients where patientId = '" + p.PatientId + "'";
            s.sqlCommand = new SqlCommand(query, s.sqlConnection);
            s.sqlCommand.ExecuteNonQuery();
            s.sqlConnection.Close();
        }




    }
}
