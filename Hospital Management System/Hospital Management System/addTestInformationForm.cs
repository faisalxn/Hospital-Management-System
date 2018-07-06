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
    public partial class addTestInformationForm : Form
    {
        public addTestInformationForm()
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

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            testInformationForm frm = new testInformationForm();
            frm.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (testNameBox.Text == "" || testCategoryBox.Text == "" || testPriceBox.Text == "" || roomComboBox.Items.Count==0) {
                MessageBox.Show("Please give all information");
                return;
            }

            string name = testNameBox.Text;
            string category = testCategoryBox.Text;
            string roomNo = roomComboBox.SelectedItem.ToString();
            int price = Convert.ToInt32(testPriceBox.Text);
            testDTO t = new testDTO(name, category, roomNo, price);
            testDAO tD = new testDAO();
            tD.createTest(t);
            clearFields();
        }


        private void clearFields() {
            testNameBox.Text = "";
            testCategoryBox.Text = "";
            testPriceBox.Text = "";
            setComboBox();
        
        }


    }
}
