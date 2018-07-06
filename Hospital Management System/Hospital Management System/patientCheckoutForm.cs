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
    public partial class patientCheckoutForm : Form
    {
        patientDAO pD = new patientDAO();
        patientDTO p;
        public patientCheckoutForm()
        {
            InitializeComponent();
            loadPatientsInfo();
        }

        public void loadPatientsInfo()
        {
            patientDataGridView.DataSource = pD.getPatients().Tables[0];
        }




        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm frm = new mainForm();
            frm.Show();

        }

        private void getBillButton_Click(object sender, EventArgs e)
        {
            if (patientDataGridView.SelectedRows.Count == 0) {
                MessageBox.Show("Please select a patient");
                return;
            }
            string checkoutDate = datePicker.Value.ToShortDateString();
            int medicineBill = Convert.ToInt32(medicineBox.Text == "" ? "0" : medicineBox.Text);
            int serviceBill = Convert.ToInt32(serviceBox.Text == "" ? "0" : serviceBox.Text );
            int testBill = Convert.ToInt32(testBox.Text == "" ? "0" : testBox.Text );
            int vatInPercentage = Convert.ToInt32(vatBox.Text == "" ? "0" : vatBox.Text);
            int roomBill = -1;
            string checkinDate = patientDataGridView.SelectedRows[0].Cells[9].Value.ToString() ;
            roomDAO rD = new roomDAO();
            DataSet ds = new DataSet();
            ds = rD.getRooms();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                string roomNo = row["roomNo"].ToString();
                if (roomNo == patientDataGridView.SelectedRows[0].Cells[6].Value.ToString()) {
                    roomBill = Convert.ToInt32(row["price"].ToString());
                    break;
                }
            }
            string[] value = checkinDate.Split('/');
            int year = Convert.ToInt32(value[2]);
            int month = Convert.ToInt32(value[0]);
            int day = Convert.ToInt32(value[1]);
            DateTime dT1 = new DateTime(year,month,day);

            value = checkoutDate.Split('/');
            year = Convert.ToInt32(value[2]);
            month = Convert.ToInt32(value[0]);
            day = Convert.ToInt32(value[1]);
            DateTime dT2 = new DateTime(year, month, day);

            int days = (dT2 - dT1).Days;
            //MessageBox.Show("room bill = " + roomBill + " days = " + days);
            roomBill = roomBill * days;

            int subTotal = roomBill + medicineBill + serviceBill + testBill;
            int vat = (int)((vatInPercentage / 100.0) * subTotal);
            int total = vat + subTotal;

            string name = patientDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            string gender = patientDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            string age = patientDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            string address = patientDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            string phone = patientDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            


            checkoutData c = new checkoutData(roomBill, medicineBill, serviceBill, testBill, subTotal, vat, total , name , gender , age , address , phone );
            this.Hide();
            BillForm frm = new BillForm(c);
            frm.Show();
            deletePatientForCheckout();


        }

        private void deletePatientForCheckout() {
            if (patientDataGridView.SelectedRows.Count == 0) return;
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
        
        }


        private void patientDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (patientDataGridView.SelectedRows.Count == 1) {
                testDAO tD = new testDAO();
                DataSet ds = new DataSet();
                ds = tD.getTests();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    string testId = row["testId"].ToString();
                    if (testId == patientDataGridView.SelectedRows[0].Cells[8].Value.ToString())
                    {
                        testBox.Text = row["price"].ToString();
                        break;
                    }
                }

            }

        }



    }
}
