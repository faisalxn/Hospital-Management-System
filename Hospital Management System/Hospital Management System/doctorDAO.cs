using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Hospital_Management_System
{
    class doctorDAO
    {
        sqlDatabase s;
        public doctorDAO()
        {
            s = new sqlDatabase();
        }

        public DataSet getDoctors() {
            s.sqlConnection.Open();
            string query = "select * from doctors";
            s.sqlCommand = new SqlCommand(query, s.sqlConnection);
            s.sqlAdapter = new SqlDataAdapter(s.sqlCommand);
            s.dataSet = new DataSet();
            s.sqlAdapter.Fill(s.dataSet);
            s.sqlConnection.Close();
            return s.dataSet;
        }

        public void updateDoctor(doctorDTO d)
        {
            s.sqlConnection.Open();
            string query = "update doctors set name = '"
                + d.Name + "', gender = '"
                + d.Gender + "', age = '"
                + d.Age + "', phone = '"
                + d.Phone + "', degree = '"
                + d.Degree + "', specialistIn = '"
                + d.SpecialistIn + "', salary = '"
                + d.Salary +  "' where doctorId = '"
                + d.DoctorId + "' ";
            s.sqlCommand = new SqlCommand(query, s.sqlConnection);
            s.sqlCommand.ExecuteNonQuery();
            s.sqlConnection.Close();
        }

        public void createDoctor(doctorDTO d)
        {
            s.sqlConnection.Open();
            string query = "insert into doctors(name,gender,age,phone,degree,specialistIn,salary) values('"+ d.Name + "','"
                                                               + d.Gender + "','"
                                                               + d.Age + "','"
                                                               + d.Phone + "','"
                                                               + d.Degree + "','"
                                                               + d.SpecialistIn + "','"
                                                               + d.Salary + "')";
            s.sqlCommand = new SqlCommand(query, s.sqlConnection);
            s.sqlCommand.ExecuteNonQuery();
            s.sqlConnection.Close();
        }
        public void deleteDoctor(doctorDTO d)
        {
            s.sqlConnection.Open();
            string query = "delete from doctors where doctorId = '" + d.DoctorId + "'";
            s.sqlCommand = new SqlCommand(query, s.sqlConnection);
            s.sqlCommand.ExecuteNonQuery();
            s.sqlConnection.Close();
        }
    }
}
