using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class patientInformationForm : Form
    {
        patientDAO pD = new patientDAO();
        patientDTO p ;
        public patientInformationForm()
        {
            InitializeComponent();
            loadPatientsInfo();
        }

        public void loadPatientsInfo() {
            patientDataGridView.DataSource = pD.getPatients().Tables[0];
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm frm = new mainForm();
            frm.Show();

        }

        

        private void patientDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            bool blank = false;
            if (patientDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString() == "") blank = true ;
            if (patientDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString() == "") blank = true ;
            if (patientDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString() == "") blank = true ;
            if (patientDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString() == "") blank = true ;
            if (patientDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString() == "") blank = true ;
            if (patientDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString() == "") blank = true ;
            if (patientDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString() == "") blank = true ;
            if (patientDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString() == "") blank = true ;
            if (patientDataGridView.Rows[e.RowIndex].Cells[8].Value.ToString() == "") blank = true ;
            if (patientDataGridView.Rows[e.RowIndex].Cells[9].Value.ToString() == "") blank = true ;

            if (blank) {
                loadPatientsInfo();
                return;
            }


            int patientId = Convert.ToInt32(patientDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            string name = patientDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            string gender = patientDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            string age = patientDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            string address = patientDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            string phone = patientDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            string roomNo = patientDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            int doctorId = Convert.ToInt32(patientDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString());
            int testId = Convert.ToInt32(patientDataGridView.Rows[e.RowIndex].Cells[8].Value.ToString());
            string checkinDate = patientDataGridView.Rows[e.RowIndex].Cells[9].Value.ToString();

            DataSet ds = new DataSet();
            roomDAO rD = new roomDAO();
            testDAO tD = new testDAO();
            doctorDAO dD = new doctorDAO();
            ds = rD.getRooms();
            bool flag = false ;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                string rN = row["roomNo"].ToString();
                if (roomNo == rN)
                {
                    flag = true;
                    break;
                }
            }
            if (flag == false) {
                loadPatientsInfo();
                return; 
            
            }


            ds = tD.getTests();
            flag = false;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                string tI = row["testId"].ToString();
                if (testId == Convert.ToInt32(tI))
                {
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                loadPatientsInfo();
                return;

            }

            ds = dD.getDoctors();
            flag = false;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                string dI = row["doctorId"].ToString();
                if (doctorId == Convert.ToInt32(dI))
                {
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                loadPatientsInfo();
                return;

            }



            p = new patientDTO(patientId, name, gender, age, address, phone, roomNo, doctorId, testId, checkinDate);
            pD.updatePatient(p);
            loadPatientsInfo();

        }

        private void patientDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            pD.deletePatient(p);
            loadPatientsInfo();
        }

        private void patientDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int patientId = Convert.ToInt32(patientDataGridView.Rows[e.Row.Index].Cells[0].Value.ToString());
            string name = patientDataGridView.Rows[e.Row.Index].Cells[1].Value.ToString();
            string gender = patientDataGridView.Rows[e.Row.Index].Cells[2].Value.ToString();
            string age = patientDataGridView.Rows[e.Row.Index].Cells[3].Value.ToString();
            string address = patientDataGridView.Rows[e.Row.Index].Cells[4].Value.ToString();
            string phone = patientDataGridView.Rows[e.Row.Index].Cells[5].Value.ToString();
            string roomNo = patientDataGridView.Rows[e.Row.Index].Cells[6].Value.ToString();
            int doctorId = Convert.ToInt32(patientDataGridView.Rows[e.Row.Index].Cells[7].Value.ToString());
            int testId = Convert.ToInt32(patientDataGridView.Rows[e.Row.Index].Cells[8].Value.ToString());
            string checkinDate = patientDataGridView.Rows[e.Row.Index].Cells[9].Value.ToString();

            p = new patientDTO(patientId, name, gender, age, address, phone, roomNo, doctorId, testId, checkinDate);
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (patientDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a row from table");
                return;
            }
            int idx = patientDataGridView.SelectedRows[0].Index;
            int patientId = Convert.ToInt32(patientDataGridView.Rows[idx].Cells[0].Value.ToString());
            string name = patientDataGridView.Rows[idx].Cells[1].Value.ToString();
            string gender = patientDataGridView.Rows[idx].Cells[2].Value.ToString();
            string age = patientDataGridView.Rows[idx].Cells[3].Value.ToString();
            string address = patientDataGridView.Rows[idx].Cells[4].Value.ToString();
            string phone = patientDataGridView.Rows[idx].Cells[5].Value.ToString();
            string roomNo = patientDataGridView.Rows[idx].Cells[6].Value.ToString();
            int doctorId = Convert.ToInt32(patientDataGridView.Rows[idx].Cells[7].Value.ToString());
            int testId = Convert.ToInt32(patientDataGridView.Rows[idx].Cells[8].Value.ToString());
            string checkinDate = patientDataGridView.Rows[idx].Cells[9].Value.ToString();

            p = new patientDTO(patientId, name, gender, age, address, phone, roomNo, doctorId, testId, checkinDate);
            pD.deletePatient(p);
            loadPatientsInfo();
        }

        
    }
}
