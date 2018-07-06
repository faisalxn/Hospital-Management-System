using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient ;
using System.Data;


namespace Hospital_Management_System
{
    class sqlDatabase
    {
        public string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=HMS_DB;Integrated Security=True;Pooling=False";
        public SqlConnection sqlConnection;
        public SqlCommand sqlCommand;
        public SqlDataAdapter sqlAdapter;
        public DataSet dataSet;

        public sqlDatabase(){
            sqlConnection = new SqlConnection(connectionString);
        }

    }
}
