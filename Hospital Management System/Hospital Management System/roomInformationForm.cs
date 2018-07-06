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
    public partial class roomInformationForm : Form
    {
        roomDAO rD = new roomDAO();
        roomDTO r;

        public roomInformationForm()
        {
            InitializeComponent();
            loadRoomsInfo();
        }
        public void loadRoomsInfo() {
            roomDataGridView.DataSource = rD.getRooms().Tables[0];
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
            addRoomInformationForm frm = new addRoomInformationForm();
            frm.Show();

        }

        

        private void roomDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            rD.deleteRoom(r);
            loadRoomsInfo();

        }

        private void roomDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string roomNo = roomDataGridView.Rows[e.Row.Index].Cells[0].Value.ToString();
            int price = Convert.ToInt32(roomDataGridView.Rows[e.Row.Index].Cells[1].Value.ToString());
            string roomType = roomDataGridView.Rows[e.Row.Index].Cells[2].Value.ToString();
            int staffId = Convert.ToInt32(roomDataGridView.Rows[e.Row.Index].Cells[3].Value.ToString());

            r = new roomDTO(roomNo,price,roomType,staffId);

        }

        private void roomDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            bool blank = false;
            if (roomDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString() == "") blank = true ;
            if (roomDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString() == "") blank = true ;
            if (roomDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString() == "") blank = true ;
            if (roomDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString() == "") blank = true ;

            if (blank) {
                loadRoomsInfo();
                return;
            }

            string roomNo = roomDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            int price = Convert.ToInt32(roomDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
            string roomType = roomDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            int staffId = Convert.ToInt32(roomDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());

            DataSet ds = new DataSet();
            roomDAO rD = new roomDAO();
            staffDAO sD = new staffDAO();
            ds = sD.getStaffs();
            bool flag = false;
            foreach (DataRow row in ds.Tables[0].Rows) {
                int sI = Convert.ToInt32(row["staffId"].ToString());
                if (staffId == sI) { 
                    flag = true ;
                    break ;
                }

            }

            if(flag==false){
                loadRoomsInfo();
                return;
            }

            r = new roomDTO(roomNo,price,roomType,staffId);
            rD.updateRoom(r);
            loadRoomsInfo();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (roomDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a row from table");
                return;
            }
            int idx = roomDataGridView.SelectedRows[0].Index;
            string roomNo = roomDataGridView.Rows[idx].Cells[0].Value.ToString();
            int price = Convert.ToInt32(roomDataGridView.Rows[idx].Cells[1].Value.ToString());
            string roomType = roomDataGridView.Rows[idx].Cells[2].Value.ToString();
            int staffId = Convert.ToInt32(roomDataGridView.Rows[idx].Cells[3].Value.ToString());

            r = new roomDTO(roomNo, price, roomType, staffId);
            rD.deleteRoom(r);
            loadRoomsInfo();

        }
    }
}
