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
    public partial class testInformationForm : Form
    {
        testDAO tD = new testDAO();
        testDTO t;
        public testInformationForm()
        {
            InitializeComponent();
            loadTestsInfo();
        }
        public void loadTestsInfo() {
            testDataGridView.DataSource = tD.getTests().Tables[0];
                

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm frm = new mainForm();
            frm.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            addTestInformationForm frm = new addTestInformationForm();
            frm.Show();

        }

        private void testDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            bool blank = false ;
            if (testDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString() == "") blank = true ;
            if (testDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString() == "") blank = true ;
            if (testDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString() == "") blank = true ;
            if (testDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString() == "") blank = true ;
            
            if (blank) {
                loadTestsInfo();
                //MessageBox.Show("Error in here");
                return;
            }


            int testId = Convert.ToInt32(testDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            string name = testDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            string category = testDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            string roomNo = testDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            int price = Convert.ToInt32(testDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString());

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
            if (flag == false)
            {
                loadTestsInfo();
                //MessageBox.Show("went to middle");
                return;

            }


            t = new testDTO(testId , name, category, roomNo, price);
            tD.updateTest(t);
            loadTestsInfo();
            //MessageBox.Show("went to last");
        }

        private void testDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int testId = Convert.ToInt32(testDataGridView.Rows[e.Row.Index].Cells[0].Value.ToString());
            string name = testDataGridView.Rows[e.Row.Index].Cells[1].Value.ToString();
            string category = testDataGridView.Rows[e.Row.Index].Cells[2].Value.ToString();
            string roomNo = testDataGridView.Rows[e.Row.Index].Cells[3].Value.ToString();
            int price = Convert.ToInt32(testDataGridView.Rows[e.Row.Index].Cells[4].Value.ToString());
            t = new testDTO(testId, name, category, roomNo, price);
        }

        private void testDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            tD.deleteTest(t);
            loadTestsInfo();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (testDataGridView.SelectedRows.Count == 0) {
                MessageBox.Show("Select a row from table");
                return;
            }

            int idx = testDataGridView.SelectedRows[0].Index;
            int testId = Convert.ToInt32(testDataGridView.Rows[idx].Cells[0].Value.ToString());
            string name = testDataGridView.Rows[idx].Cells[1].Value.ToString();
            string category = testDataGridView.Rows[idx].Cells[2].Value.ToString();
            string roomNo = testDataGridView.Rows[idx].Cells[3].Value.ToString();
            int price = Convert.ToInt32(testDataGridView.Rows[idx].Cells[4].Value.ToString());
            t = new testDTO(testId, name, category, roomNo, price);
            tD.deleteTest(t);
            loadTestsInfo();
        }


    }
}
