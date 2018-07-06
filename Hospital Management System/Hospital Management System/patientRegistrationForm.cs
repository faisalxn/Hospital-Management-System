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
    public partial class patientRegistrationForm : Form
    {
        public patientRegistrationForm()
        {
            InitializeComponent();
            setComboBox();
            
        }


        private void setComboBox() {
            roomComboBox.Items.Clear();
            roomComboBox.Text = "";
            doctorComboBox.Items.Clear();
            doctorComboBox.Text = "";
            testComboBox.Items.Clear();
            testComboBox.Text = "";

            roomDAO rD = new roomDAO();
            DataSet ds = rD.getRooms();
            LinkedList<string> listOfAllRooms = new LinkedList<string>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                string roomNo = row["roomNo"].ToString();
                //roomComboBox.Items.Add(roomNo);
                listOfAllRooms.AddLast(roomNo);
            }
            patientDAO pD = new patientDAO();
            ds = pD.getPatients();
            LinkedList<string> listOfUsedRooms = new LinkedList<string>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                string roomNo = row["roomNo"].ToString();
                //roomComboBox.Items.Add(roomNo);
                listOfUsedRooms.AddLast(roomNo);
            }
            LinkedList<string> listOfUnUsedRooms = new LinkedList<string>();
            for (int i = 0; i < listOfAllRooms.Count; i++)
            {
                bool flag = true;
                for (int j = 0; j < listOfUsedRooms.Count; j++)
                {
                    string allRoom = listOfAllRooms.ElementAt(i);
                    string usedRoom = listOfUsedRooms.ElementAt(j);
                    if (allRoom == usedRoom)
                    {
                        flag = false;
                        break;
                    }

                }
                if (flag)
                {
                    listOfUnUsedRooms.AddLast(listOfAllRooms.ElementAt(i));

                }
            }
            for (int i = 0; i < listOfUnUsedRooms.Count; i++)
            {
                string roomNo = listOfUnUsedRooms.ElementAt(i);
                roomComboBox.Items.Add(roomNo);
            }


            if (roomComboBox.Items.Count > 0)
                roomComboBox.SelectedIndex = 0;

            doctorDAO dD = new doctorDAO();
            ds = dD.getDoctors();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                int doctorId = Convert.ToInt32(row["doctorId"].ToString());
                string name = row["name"].ToString();
                doctorComboBox.Items.Add(doctorId + "," + name);
            }
            if (doctorComboBox.Items.Count > 0)
                doctorComboBox.SelectedIndex = 0;

            testDAO tD = new testDAO();
            ds = tD.getTests();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                int testId = Convert.ToInt32(row["testId"].ToString());
                string name = row["name"].ToString();
                string category = row["category"].ToString();
                testComboBox.Items.Add(testId + "," + name + "," + category);
            }
            if (testComboBox.Items.Count > 0)
                testComboBox.SelectedIndex = 0;
        
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm frm = new mainForm();
            frm.Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (nameBox.Text == "" || genderBox.Text == "" || ageBox.Text == "" || addressBox.Text == "" || phoneBox.Text == "" || roomComboBox.Items.Count == 0 || doctorComboBox.Items.Count == 0 || testComboBox.Items.Count == 0)
            {
                MessageBox.Show("Please give all information");
                return;
            }

            string name = nameBox.Text;
            string gender = genderBox.Text;
            string age = ageBox.Text;
            string address = addressBox.Text;
            string phone = phoneBox.Text;
            string roomNo = roomComboBox.SelectedItem.ToString();
            string s = doctorComboBox.SelectedItem.ToString();
            string[] values = s.Split(',');
            int doctorId = Convert.ToInt32(values[0]);
            s = testComboBox.SelectedItem.ToString();
            values = s.Split(',');
            int testId = Convert.ToInt32(values[0]);
            string checkinDate = datePicker.Value.ToShortDateString();
            patientDTO p = new patientDTO(name, gender, age, address, phone, roomNo, doctorId, testId, checkinDate);
            patientDAO pD = new patientDAO();
            pD.createPatient(p);
            clearFields();
        }


        private void clearFields() {
            nameBox.Text = "";
            genderBox.Text = "";
            ageBox.Text = "";
            addressBox.Text = "";
            phoneBox.Text = "";
            setComboBox();
        }


    }
}
