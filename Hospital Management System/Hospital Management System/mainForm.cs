using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Hospital_Management_System
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            loginForm frm = new loginForm();
            frm.Show();
            this.Hide();
        }

        private void patientRegistrationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            patientRegistrationForm frm = new patientRegistrationForm();
            frm.Show();

        }

        private void PatientInformationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            patientInformationForm frm = new patientInformationForm();
            frm.Show();
        }

        private void PatientCheckoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            patientCheckoutForm frm = new patientCheckoutForm();
            frm.Show();
        }

        private void doctorInformationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            doctorInformationForm frm = new doctorInformationForm();
            frm.Show();
        }

        private void staffInformationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            staffInformationForm frm = new staffInformationForm();
            frm.Show();
        }

        private void roomInformationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            roomInformationForm frm = new roomInformationForm();
            frm.Show();
        }

        private void testInformationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            testInformationForm frm = new testInformationForm();
            frm.Show();
        }

        private void chagePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            passwordChangeForm frm = new passwordChangeForm();
            frm.Show();
        }

        

        
        



    }
}
