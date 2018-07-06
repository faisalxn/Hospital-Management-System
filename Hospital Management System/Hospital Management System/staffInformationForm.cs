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
    public partial class staffInformationForm : Form
    {
        staffDAO sD = new staffDAO();
        staffDTO st;

        public staffInformationForm()
        {
            InitializeComponent();
            loadStaffsInfo();
        }
        public void loadStaffsInfo() {
            staffDataGridView.DataSource = sD.getStaffs().Tables[0]; 
        
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
            addStaffInformationForm frm = new addStaffInformationForm();
            frm.Show();
        }

        private void staffDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            bool blank = false;
            if (staffDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString() == "") blank = true;
            if (staffDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString() == "") blank = true;
            if (staffDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString() == "") blank = true;
            if (staffDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString() == "") blank = true;
            if (staffDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString() == "") {  }
            if (staffDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString() == "") blank = true;
            if (staffDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString() == "") blank = true;

            if (blank) {
                loadStaffsInfo();
                return;
            }


            int staffId = Convert.ToInt32(staffDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            string name = staffDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            string gender = staffDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString() ;
            string age = staffDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString() ;
            string roomNo = staffDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString() ;
            string phone = staffDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString() ;
            string salary = staffDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString() ;


            DataSet ds = new DataSet();
            roomDAO rD = new roomDAO();
            ds = rD.getRooms();
            bool flag = false;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                string rN = row["roomNo"].ToString();
                if (roomNo == rN)
                {
                    flag = true;
                    break;
                }
            }
            if (flag == false && roomNo!="")
            {
                loadStaffsInfo();
                return;

            }


            st = new staffDTO(staffId, name, gender, age, roomNo, phone, salary);
            sD.updateStaff(st);
            loadStaffsInfo();
        }

        private void staffDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int staffId = Convert.ToInt32(staffDataGridView.Rows[e.Row.Index].Cells[0].Value.ToString());
            string name = staffDataGridView.Rows[e.Row.Index].Cells[1].Value.ToString();
            string gender = staffDataGridView.Rows[e.Row.Index].Cells[2].Value.ToString();
            string age = staffDataGridView.Rows[e.Row.Index].Cells[3].Value.ToString();
            string roomNo = staffDataGridView.Rows[e.Row.Index].Cells[4].Value.ToString();
            string phone = staffDataGridView.Rows[e.Row.Index].Cells[5].Value.ToString();
            string salary = staffDataGridView.Rows[e.Row.Index].Cells[6].Value.ToString();
            st = new staffDTO(staffId, name, gender, age, roomNo, phone, salary);

        }

        private void staffDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            sD.deleteStaff(st);
            loadStaffsInfo();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (staffDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a row from table");
                return;
            }
            int idx = staffDataGridView.SelectedRows[0].Index;
            int staffId = Convert.ToInt32(staffDataGridView.Rows[idx].Cells[0].Value.ToString());
            string name = staffDataGridView.Rows[idx].Cells[1].Value.ToString();
            string gender = staffDataGridView.Rows[idx].Cells[2].Value.ToString();
            string age = staffDataGridView.Rows[idx].Cells[3].Value.ToString();
            string roomNo = staffDataGridView.Rows[idx].Cells[4].Value.ToString();
            string phone = staffDataGridView.Rows[idx].Cells[5].Value.ToString();
            string salary = staffDataGridView.Rows[idx].Cells[6].Value.ToString();
            st = new staffDTO(staffId, name, gender, age, roomNo, phone, salary);
            sD.deleteStaff(st);
            loadStaffsInfo();

        }
    }
}
