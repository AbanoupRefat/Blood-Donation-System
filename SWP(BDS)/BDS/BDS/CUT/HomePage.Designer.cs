namespace BDS.CUT
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.viewDonationHistory = new Guna.UI2.WinForms.Guna2Button();
            this.MakeAppointment = new Guna.UI2.WinForms.Guna2Button();
            this.AddPationt = new Guna.UI2.WinForms.Guna2Button();
            this.AddDonor = new Guna.UI2.WinForms.Guna2Button();
            this.MedicalScrening = new Guna.UI2.WinForms.Guna2Button();
            this.panel_View2 = new System.Windows.Forms.Panel();
            this.Back = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.exite = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.exite);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1447, 72);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(72, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Blood Donating System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.viewDonationHistory);
            this.panel2.Controls.Add(this.MakeAppointment);
            this.panel2.Controls.Add(this.AddPationt);
            this.panel2.Controls.Add(this.AddDonor);
            this.panel2.Controls.Add(this.MedicalScrening);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1447, 73);
            this.panel2.TabIndex = 4;
            // 
            // viewDonationHistory
            // 
            this.viewDonationHistory.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.viewDonationHistory.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.viewDonationHistory.CheckedState.FillColor = System.Drawing.Color.White;
            this.viewDonationHistory.CheckedState.ForeColor = System.Drawing.Color.Red;
            this.viewDonationHistory.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.viewDonationHistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.viewDonationHistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.viewDonationHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.viewDonationHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.viewDonationHistory.FillColor = System.Drawing.Color.White;
            this.viewDonationHistory.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Bold);
            this.viewDonationHistory.ForeColor = System.Drawing.Color.Black;
            this.viewDonationHistory.Location = new System.Drawing.Point(1124, 0);
            this.viewDonationHistory.Name = "viewDonationHistory";
            this.viewDonationHistory.Size = new System.Drawing.Size(323, 73);
            this.viewDonationHistory.TabIndex = 3;
            this.viewDonationHistory.Text = "View Donors";
            this.viewDonationHistory.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // MakeAppointment
            // 
            this.MakeAppointment.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.MakeAppointment.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.MakeAppointment.CheckedState.FillColor = System.Drawing.Color.White;
            this.MakeAppointment.CheckedState.ForeColor = System.Drawing.Color.Red;
            this.MakeAppointment.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.MakeAppointment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MakeAppointment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MakeAppointment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MakeAppointment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MakeAppointment.FillColor = System.Drawing.Color.White;
            this.MakeAppointment.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Bold);
            this.MakeAppointment.ForeColor = System.Drawing.Color.Black;
            this.MakeAppointment.Location = new System.Drawing.Point(556, 0);
            this.MakeAppointment.Name = "MakeAppointment";
            this.MakeAppointment.Size = new System.Drawing.Size(284, 73);
            this.MakeAppointment.TabIndex = 2;
            this.MakeAppointment.Text = "Make Appointment";
            this.MakeAppointment.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // AddPationt
            // 
            this.AddPationt.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.AddPationt.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.AddPationt.CheckedState.FillColor = System.Drawing.Color.White;
            this.AddPationt.CheckedState.ForeColor = System.Drawing.Color.Red;
            this.AddPationt.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.AddPationt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddPationt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddPationt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddPationt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddPationt.FillColor = System.Drawing.Color.White;
            this.AddPationt.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Bold);
            this.AddPationt.ForeColor = System.Drawing.Color.Black;
            this.AddPationt.Location = new System.Drawing.Point(846, 0);
            this.AddPationt.Name = "AddPationt";
            this.AddPationt.Size = new System.Drawing.Size(282, 73);
            this.AddPationt.TabIndex = 3;
            this.AddPationt.Text = "Add Patient";
            this.AddPationt.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // AddDonor
            // 
            this.AddDonor.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.AddDonor.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.AddDonor.CheckedState.FillColor = System.Drawing.Color.White;
            this.AddDonor.CheckedState.ForeColor = System.Drawing.Color.Red;
            this.AddDonor.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.AddDonor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddDonor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddDonor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddDonor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddDonor.FillColor = System.Drawing.Color.White;
            this.AddDonor.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Bold);
            this.AddDonor.ForeColor = System.Drawing.Color.Black;
            this.AddDonor.Location = new System.Drawing.Point(274, 0);
            this.AddDonor.Name = "AddDonor";
            this.AddDonor.Size = new System.Drawing.Size(281, 73);
            this.AddDonor.TabIndex = 1;
            this.AddDonor.Text = "Add Donor";
            this.AddDonor.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // MedicalScrening
            // 
            this.MedicalScrening.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.MedicalScrening.Checked = true;
            this.MedicalScrening.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.MedicalScrening.CheckedState.FillColor = System.Drawing.Color.White;
            this.MedicalScrening.CheckedState.ForeColor = System.Drawing.Color.Red;
            this.MedicalScrening.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.MedicalScrening.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MedicalScrening.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MedicalScrening.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MedicalScrening.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MedicalScrening.FillColor = System.Drawing.Color.White;
            this.MedicalScrening.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Bold);
            this.MedicalScrening.ForeColor = System.Drawing.Color.Black;
            this.MedicalScrening.Location = new System.Drawing.Point(0, 0);
            this.MedicalScrening.Name = "MedicalScrening";
            this.MedicalScrening.Size = new System.Drawing.Size(277, 73);
            this.MedicalScrening.TabIndex = 0;
            this.MedicalScrening.Text = "Medical Screanning";
            this.MedicalScrening.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panel_View2
            // 
            this.panel_View2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_View2.Location = new System.Drawing.Point(0, 145);
            this.panel_View2.Name = "panel_View2";
            this.panel_View2.Size = new System.Drawing.Size(1447, 601);
            this.panel_View2.TabIndex = 5;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(1587, 283);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(113, 36);
            this.Back.TabIndex = 13;
            this.Back.Text = "Admin Login";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(667, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "Sign Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exite
            // 
            this.exite.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exite.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exite.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exite.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exite.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exite.ForeColor = System.Drawing.Color.White;
            this.exite.Location = new System.Drawing.Point(1322, 17);
            this.exite.Name = "exite";
            this.exite.Size = new System.Drawing.Size(84, 45);
            this.exite.TabIndex = 15;
            this.exite.Text = "Exit";
            this.exite.Click += new System.EventHandler(this.exite_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 746);
            this.Controls.Add(this.panel_View2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User_Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button MakeAppointment;
        private Guna.UI2.WinForms.Guna2Button MedicalScrening;
        private System.Windows.Forms.Panel panel_View2;
        private Guna.UI2.WinForms.Guna2Button viewDonationHistory;
        private Guna.UI2.WinForms.Guna2Button AddPationt;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button button1;
        public Guna.UI2.WinForms.Guna2Button AddDonor;
        private Guna.UI2.WinForms.Guna2Button exite;
    }
}