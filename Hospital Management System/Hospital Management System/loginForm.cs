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
    public partial class loginForm : Form
    {
        bool workingMode = false;
        bool testing = false;
        public loginForm()
        {
            InitializeComponent();
            if(testing){
                this.Hide();
                new BillForm().Show();
        
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            passwordDAO pD = new passwordDAO();
            string name = userNameBox.Text;
            string pass = passwordBox.Text;

            if (name == "admin" && pass == pD.getPassword().Tables[0].Rows[0]["password"].ToString() || workingMode)
            {
                mainForm frm = new mainForm();
                frm.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Enter correct username and password !");
            
            }

        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            
        }



    }
}
