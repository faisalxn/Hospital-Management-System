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
    public partial class passwordChangeForm : Form
    {
        passwordDTO p;
        passwordDAO pD = new passwordDAO();
        public passwordChangeForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm frm = new mainForm();
            frm.Show();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            DataSet ds = pD.getPassword();
            string old = ds.Tables[0].Rows[0]["password"].ToString();
            if (oldBox.Text == old)
            {
                if (newBox.Text == confirmBox.Text)
                {
                    p = new passwordDTO(newBox.Text);
                    pD.updatePassword(p);
                    oldBox.Text = "";
                    newBox.Text = "";
                    confirmBox.Text = "";
                    MessageBox.Show("Password Changed !");
                }
                else
                {
                    MessageBox.Show("Passwords not matched !");
                }
            }
            else {
                MessageBox.Show("Incorrect password !");
            }


        }
    }
}
