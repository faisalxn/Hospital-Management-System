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
    public partial class addStaffInformationForm : Form
    {
        public addStaffInformationForm()
        {
            InitializeComponent();
            setComboBox();
        }


        private void setComboBox() {
            roomDAO rD = new roomDAO();
            DataSet ds = rD.getRooms();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                string roomNo = row["roomNo"].ToString();
                roomComboBox.Items.Add(roomNo);
            }
            if (roomComboBox.Items.Count > 0)
                roomComboBox.SelectedIndex = 0;
        
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            staffInformationForm frm = new staffInformationForm();
            frm.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (nameBox.Text == "" || genderBox.Text == "" || ageBox.Text == "" || phoneBox.Text == "" || salaryBox.Text == "" ) {
                MessageBox.Show("Please give all information");
                return;
            }

            string name = nameBox.Text;
            string gender = genderBox.Text;
            string age = ageBox.Text;
            string roomNo ;
            if (roomComboBox.Items.Count == 0)
            {
                roomNo = "";
            }
            else {
                roomNo = roomComboBox.SelectedItem.ToString();
            
            }


            string phone = phoneBox.Text;
            string salary = salaryBox.Text;

            staffDTO st = new staffDTO(name, gender, age, roomNo, phone, salary);
            staffDAO sD = new staffDAO();
            sD.createStaff(st);
            clearFields();
        }

        private void clearFields() {
            nameBox.Text = "";
            genderBox.Text = "";
            ageBox.Text = "";
            phoneBox.Text = "";
            salaryBox.Text = "";
            setComboBox();
        }



    }
}
