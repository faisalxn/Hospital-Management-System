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
    public partial class doctorInformationForm : Form
    {
        doctorDAO dD = new doctorDAO();
        doctorDTO d;
        public doctorInformationForm()
        {
            InitializeComponent();
            loadDoctorsInfo();
        }

        public void loadDoctorsInfo() {
            doctorDataGridView.DataSource = dD.getDoctors().Tables[0]; 
        
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm frm = new mainForm();
            frm.Show();

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            addDoctorInformationForm frm = new addDoctorInformationForm();
            frm.Show();
        }

        private void doctorDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            bool blank = false;
            if (doctorDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString() == "") blank = true ;
            if (doctorDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString() == "") blank = true ;
            if (doctorDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString() == "") blank = true ;
            if (doctorDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString() == "") blank = true ;
            if (doctorDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString() == "") blank = true ;
            if (doctorDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString() == "") blank = true ;
            if (doctorDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString() == "") blank = true ;
            if (doctorDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString() == "") blank = true ;

            if (blank) {
                loadDoctorsInfo();
                return;
            }


            int doctorId = Convert.ToInt32(doctorDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            string name = doctorDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString() ;
            string age = doctorDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString() ;
            string gender = doctorDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString() ;
            string degree = doctorDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString() ;
            string specialistIn = doctorDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString() ;
            string phone = doctorDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString() ;
            string salary = doctorDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString() ;
            d = new doctorDTO(doctorId,name,age,gender,degree,specialistIn,phone,salary);
            dD.updateDoctor(d);
            loadDoctorsInfo();
        }

        private void doctorDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            dD.deleteDoctor(d);
            loadDoctorsInfo();

        }

        private void doctorDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int doctorId = Convert.ToInt32(doctorDataGridView.Rows[e.Row.Index].Cells[0].Value.ToString());
            string name = doctorDataGridView.Rows[e.Row.Index].Cells[1].Value.ToString();
            string age = doctorDataGridView.Rows[e.Row.Index].Cells[3].Value.ToString();
            string gender = doctorDataGridView.Rows[e.Row.Index].Cells[2].Value.ToString();
            string degree = doctorDataGridView.Rows[e.Row.Index].Cells[4].Value.ToString();
            string specialistIn = doctorDataGridView.Rows[e.Row.Index].Cells[5].Value.ToString();
            string phone = doctorDataGridView.Rows[e.Row.Index].Cells[6].Value.ToString();
            string salary = doctorDataGridView.Rows[e.Row.Index].Cells[7].Value.ToString();
            d = new doctorDTO(doctorId, name, age, gender, degree, specialistIn, phone, salary);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (doctorDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a row from table");
                return;
            }
            int idx = doctorDataGridView.SelectedRows[0].Index;

            int doctorId = Convert.ToInt32(doctorDataGridView.Rows[idx].Cells[0].Value.ToString());
            string name = doctorDataGridView.Rows[idx].Cells[1].Value.ToString();
            string age = doctorDataGridView.Rows[idx].Cells[3].Value.ToString();
            string gender = doctorDataGridView.Rows[idx].Cells[2].Value.ToString();
            string degree = doctorDataGridView.Rows[idx].Cells[4].Value.ToString();
            string specialistIn = doctorDataGridView.Rows[idx].Cells[5].Value.ToString();
            string phone = doctorDataGridView.Rows[idx].Cells[6].Value.ToString();
            string salary = doctorDataGridView.Rows[idx].Cells[7].Value.ToString();
            d = new doctorDTO(doctorId, name, age, gender, degree, specialistIn, phone, salary);
            dD.deleteDoctor(d);
            loadDoctorsInfo();

        }


    }
}
