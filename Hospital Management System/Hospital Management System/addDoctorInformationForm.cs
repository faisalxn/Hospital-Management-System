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
    public partial class addDoctorInformationForm : Form
    {
        public addDoctorInformationForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            doctorInformationForm frm = new doctorInformationForm();
            frm.Show();

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text;
            string age = ageBox.Text;
            string gender = genderBox.Text;
            string degree = DegreeBox.Text;
            string specialistIn = specialistBox.Text;
            string phone = phoneBox.Text;
            string salary = salaryBox.Text;
            doctorDTO d = new doctorDTO(name, age, gender, degree, specialistIn, phone, salary);
            doctorDAO dD = new doctorDAO();
            dD.createDoctor(d);
            clearFields();
        }

        private void clearFields() {
            nameBox.Text = "";
            ageBox.Text = "";
            genderBox.Text = "";
            DegreeBox.Text = "";
            specialistBox.Text = "";
            phoneBox.Text = "";
            salaryBox.Text = "";
        
        }


    }
}
