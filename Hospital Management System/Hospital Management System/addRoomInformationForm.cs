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
    public partial class addRoomInformationForm : Form
    {
        public addRoomInformationForm()
        {
            InitializeComponent();
            staffDAO sD = new staffDAO();
            DataSet ds = sD.getStaffs();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                int staffId = Convert.ToInt32(row["staffId"].ToString());
                string name = row["name"].ToString();
                staffComboBox.Items.Add(staffId + "," + name);
            }
            if(staffComboBox.Items.Count>0)
                staffComboBox.SelectedIndex = 0;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            roomInformationForm frm = new roomInformationForm();
            frm.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (roomNoBox.Text == "" || priceBox.Text == "" || roomTypeBox.Text == "" || staffComboBox.Items.Count == 0) {
                MessageBox.Show("Please give all information");
                return;
            }


            string roomNo = roomNoBox.Text;
            int price = Convert.ToInt32(priceBox.Text);
            string roomType = roomTypeBox.Text;
            string s = staffComboBox.SelectedItem.ToString();
            string[] values = s.Split(',');
            int staffId = Convert.ToInt32(values[0]);
            roomDTO r = new roomDTO(roomNo, price, roomType, staffId);
            roomDAO rD = new roomDAO();
            rD.createRoom(r);
            clearFields();
        }

        private void clearFields() {
            roomNoBox.Text = "";
            priceBox.Text = "";
            roomTypeBox.Text = "";

        
        }



    }
}
