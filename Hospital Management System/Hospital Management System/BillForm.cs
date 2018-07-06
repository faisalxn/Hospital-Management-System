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
    public partial class BillForm : Form
    {
        public BillForm() {
            InitializeComponent();
        
        }

        public BillForm(checkoutData c)
        {
            
            InitializeComponent();
            nameLabel.Text = c.Name;
            genderLabel.Text = c.Gender;
            ageLabel.Text = c.Age;
            phoneLabel.Text = c.Phone;
            addressLabel.Text = c.Address;
            roomLabel.Text = c.RoomBill+"";
            medicineLabel.Text = c.MedicineBill+"";
            serviceLabel.Text = c.ServiceBill + "";
            testLabel.Text = c.TestBill + "";
            subLabel.Text = c.SubTotal + "";
            vatLabel.Text = c.Vat + "";
            totalLabel.Text = c.Total + "";
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            patientCheckoutForm frm = new patientCheckoutForm();
            frm.Show();

        }

        
        


    }
}
