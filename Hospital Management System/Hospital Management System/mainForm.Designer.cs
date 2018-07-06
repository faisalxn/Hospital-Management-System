namespace Hospital_Management_System
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.patientRegistrationButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.PatientInformationButton = new System.Windows.Forms.Button();
            this.testInformationButton = new System.Windows.Forms.Button();
            this.PatientCheckoutButton = new System.Windows.Forms.Button();
            this.roomInformationButton = new System.Windows.Forms.Button();
            this.doctorInformationButton = new System.Windows.Forms.Button();
            this.staffInformationButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chagePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Hospital_Management_System.Properties.Resources.main_background5;
            this.panel1.Controls.Add(this.patientRegistrationButton);
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Controls.Add(this.PatientInformationButton);
            this.panel1.Controls.Add(this.testInformationButton);
            this.panel1.Controls.Add(this.PatientCheckoutButton);
            this.panel1.Controls.Add(this.roomInformationButton);
            this.panel1.Controls.Add(this.doctorInformationButton);
            this.panel1.Controls.Add(this.staffInformationButton);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 650);
            this.panel1.TabIndex = 10;
            // 
            // patientRegistrationButton
            // 
            this.patientRegistrationButton.Location = new System.Drawing.Point(116, 92);
            this.patientRegistrationButton.Name = "patientRegistrationButton";
            this.patientRegistrationButton.Size = new System.Drawing.Size(131, 23);
            this.patientRegistrationButton.TabIndex = 1;
            this.patientRegistrationButton.Text = "Patient Registration";
            this.patientRegistrationButton.UseVisualStyleBackColor = true;
            this.patientRegistrationButton.Click += new System.EventHandler(this.patientRegistrationButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(116, 540);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(131, 23);
            this.logoutButton.TabIndex = 9;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // PatientInformationButton
            // 
            this.PatientInformationButton.Location = new System.Drawing.Point(116, 153);
            this.PatientInformationButton.Name = "PatientInformationButton";
            this.PatientInformationButton.Size = new System.Drawing.Size(131, 23);
            this.PatientInformationButton.TabIndex = 2;
            this.PatientInformationButton.Text = "Patients Manage";
            this.PatientInformationButton.UseVisualStyleBackColor = true;
            this.PatientInformationButton.Click += new System.EventHandler(this.PatientInformationButton_Click);
            // 
            // testInformationButton
            // 
            this.testInformationButton.Location = new System.Drawing.Point(116, 474);
            this.testInformationButton.Name = "testInformationButton";
            this.testInformationButton.Size = new System.Drawing.Size(131, 23);
            this.testInformationButton.TabIndex = 8;
            this.testInformationButton.Text = "Test Information";
            this.testInformationButton.UseVisualStyleBackColor = true;
            this.testInformationButton.Click += new System.EventHandler(this.testInformationButton_Click);
            // 
            // PatientCheckoutButton
            // 
            this.PatientCheckoutButton.Location = new System.Drawing.Point(116, 212);
            this.PatientCheckoutButton.Name = "PatientCheckoutButton";
            this.PatientCheckoutButton.Size = new System.Drawing.Size(131, 23);
            this.PatientCheckoutButton.TabIndex = 3;
            this.PatientCheckoutButton.Text = "Patient Checkout";
            this.PatientCheckoutButton.UseVisualStyleBackColor = true;
            this.PatientCheckoutButton.Click += new System.EventHandler(this.PatientCheckoutButton_Click);
            // 
            // roomInformationButton
            // 
            this.roomInformationButton.Location = new System.Drawing.Point(116, 403);
            this.roomInformationButton.Name = "roomInformationButton";
            this.roomInformationButton.Size = new System.Drawing.Size(131, 23);
            this.roomInformationButton.TabIndex = 7;
            this.roomInformationButton.Text = "Room Information";
            this.roomInformationButton.UseVisualStyleBackColor = true;
            this.roomInformationButton.Click += new System.EventHandler(this.roomInformationButton_Click);
            // 
            // doctorInformationButton
            // 
            this.doctorInformationButton.Location = new System.Drawing.Point(116, 273);
            this.doctorInformationButton.Name = "doctorInformationButton";
            this.doctorInformationButton.Size = new System.Drawing.Size(131, 23);
            this.doctorInformationButton.TabIndex = 5;
            this.doctorInformationButton.Text = "Doctor Information";
            this.doctorInformationButton.UseVisualStyleBackColor = true;
            this.doctorInformationButton.Click += new System.EventHandler(this.doctorInformationButton_Click);
            // 
            // staffInformationButton
            // 
            this.staffInformationButton.Location = new System.Drawing.Point(116, 331);
            this.staffInformationButton.Name = "staffInformationButton";
            this.staffInformationButton.Size = new System.Drawing.Size(131, 23);
            this.staffInformationButton.TabIndex = 6;
            this.staffInformationButton.Text = "Staff Information";
            this.staffInformationButton.UseVisualStyleBackColor = true;
            this.staffInformationButton.Click += new System.EventHandler(this.staffInformationButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chagePasswordToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1150, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chagePasswordToolStripMenuItem
            // 
            this.chagePasswordToolStripMenuItem.Name = "chagePasswordToolStripMenuItem";
            this.chagePasswordToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.chagePasswordToolStripMenuItem.Text = "Change Password";
            this.chagePasswordToolStripMenuItem.Click += new System.EventHandler(this.chagePasswordToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 650);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Management System";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button patientRegistrationButton;
        private System.Windows.Forms.Button PatientInformationButton;
        private System.Windows.Forms.Button PatientCheckoutButton;
        private System.Windows.Forms.Button doctorInformationButton;
        private System.Windows.Forms.Button staffInformationButton;
        private System.Windows.Forms.Button roomInformationButton;
        private System.Windows.Forms.Button testInformationButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chagePasswordToolStripMenuItem;
    }
}