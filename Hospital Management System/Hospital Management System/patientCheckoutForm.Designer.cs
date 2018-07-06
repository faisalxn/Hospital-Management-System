namespace Hospital_Management_System
{
    partial class patientCheckoutForm
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
            this.testBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.getBillButton = new System.Windows.Forms.Button();
            this.vatBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.serviceBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.medicineBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.patientDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Hospital_Management_System.Properties.Resources.main_background5;
            this.panel1.Controls.Add(this.testBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Controls.Add(this.getBillButton);
            this.panel1.Controls.Add(this.vatBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.serviceBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.medicineBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.datePicker);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.patientDataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 650);
            this.panel1.TabIndex = 0;
            // 
            // testBox
            // 
            this.testBox.Location = new System.Drawing.Point(172, 573);
            this.testBox.Name = "testBox";
            this.testBox.ReadOnly = true;
            this.testBox.Size = new System.Drawing.Size(200, 20);
            this.testBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(53, 577);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Test Bill";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(1015, 573);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 12;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // getBillButton
            // 
            this.getBillButton.Location = new System.Drawing.Point(666, 572);
            this.getBillButton.Name = "getBillButton";
            this.getBillButton.Size = new System.Drawing.Size(75, 23);
            this.getBillButton.TabIndex = 10;
            this.getBillButton.Text = "Get Bill";
            this.getBillButton.UseVisualStyleBackColor = true;
            this.getBillButton.Click += new System.EventHandler(this.getBillButton_Click);
            // 
            // vatBox
            // 
            this.vatBox.Location = new System.Drawing.Point(666, 424);
            this.vatBox.Name = "vatBox";
            this.vatBox.Size = new System.Drawing.Size(200, 20);
            this.vatBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(527, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vat In Percentage";
            // 
            // serviceBox
            // 
            this.serviceBox.Location = new System.Drawing.Point(172, 527);
            this.serviceBox.Name = "serviceBox";
            this.serviceBox.Size = new System.Drawing.Size(200, 20);
            this.serviceBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(53, 530);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Service Bill";
            // 
            // medicineBox
            // 
            this.medicineBox.Location = new System.Drawing.Point(172, 479);
            this.medicineBox.Name = "medicineBox";
            this.medicineBox.Size = new System.Drawing.Size(200, 20);
            this.medicineBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(53, 482);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Medicine Bill";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(172, 431);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(53, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Checkout Date";
            // 
            // patientDataGridView
            // 
            this.patientDataGridView.AllowUserToAddRows = false;
            this.patientDataGridView.AllowUserToDeleteRows = false;
            this.patientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientDataGridView.Location = new System.Drawing.Point(56, 45);
            this.patientDataGridView.Name = "patientDataGridView";
            this.patientDataGridView.ReadOnly = true;
            this.patientDataGridView.Size = new System.Drawing.Size(1034, 345);
            this.patientDataGridView.TabIndex = 1;
            this.patientDataGridView.SelectionChanged += new System.EventHandler(this.patientDataGridView_SelectionChanged);
            // 
            // patientCheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 650);
            this.Controls.Add(this.panel1);
            this.Name = "patientCheckoutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Management System";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button getBillButton;
        private System.Windows.Forms.TextBox vatBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox serviceBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox medicineBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView patientDataGridView;
        private System.Windows.Forms.TextBox testBox;
        private System.Windows.Forms.Label label5;
    }
}