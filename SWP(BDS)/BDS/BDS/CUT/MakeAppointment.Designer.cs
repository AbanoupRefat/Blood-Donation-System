namespace BDS.CUT
{
    partial class MakeAppointment
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeAppointment));
            this.DonorIDTxtb = new Guna.UI2.WinForms.Guna2TextBox();
            this.DonorID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.MakeAppointmentBtn = new Guna.UI2.WinForms.Guna2Button();
            this.donationDateDte = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.donationDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // DonorIDTxtb
            // 
            this.DonorIDTxtb.AutoRoundedCorners = true;
            this.DonorIDTxtb.BackColor = System.Drawing.Color.Transparent;
            this.DonorIDTxtb.BorderColor = System.Drawing.Color.Black;
            this.DonorIDTxtb.BorderRadius = 21;
            this.DonorIDTxtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DonorIDTxtb.DefaultText = "";
            this.DonorIDTxtb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DonorIDTxtb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DonorIDTxtb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DonorIDTxtb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DonorIDTxtb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DonorIDTxtb.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Bold);
            this.DonorIDTxtb.ForeColor = System.Drawing.Color.Black;
            this.DonorIDTxtb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DonorIDTxtb.Location = new System.Drawing.Point(155, 118);
            this.DonorIDTxtb.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.DonorIDTxtb.Name = "DonorIDTxtb";
            this.DonorIDTxtb.PasswordChar = '\0';
            this.DonorIDTxtb.PlaceholderText = "Enter Donor_ID";
            this.DonorIDTxtb.SelectedText = "";
            this.DonorIDTxtb.Size = new System.Drawing.Size(376, 44);
            this.DonorIDTxtb.TabIndex = 32;
            // 
            // DonorID
            // 
            this.DonorID.BackColor = System.Drawing.Color.Transparent;
            this.DonorID.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorID.ForeColor = System.Drawing.Color.Black;
            this.DonorID.Location = new System.Drawing.Point(272, 73);
            this.DonorID.Name = "DonorID";
            this.DonorID.Size = new System.Drawing.Size(162, 37);
            this.DonorID.TabIndex = 31;
            this.DonorID.Text = "Donor_ID:";
            // 
            // MakeAppointmentBtn
            // 
            this.MakeAppointmentBtn.AutoRoundedCorners = true;
            this.MakeAppointmentBtn.BackColor = System.Drawing.Color.Transparent;
            this.MakeAppointmentBtn.BorderRadius = 27;
            this.MakeAppointmentBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MakeAppointmentBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MakeAppointmentBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MakeAppointmentBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MakeAppointmentBtn.FillColor = System.Drawing.Color.Red;
            this.MakeAppointmentBtn.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold);
            this.MakeAppointmentBtn.ForeColor = System.Drawing.Color.White;
            this.MakeAppointmentBtn.Location = new System.Drawing.Point(100, 425);
            this.MakeAppointmentBtn.Name = "MakeAppointmentBtn";
            this.MakeAppointmentBtn.Size = new System.Drawing.Size(494, 56);
            this.MakeAppointmentBtn.TabIndex = 30;
            this.MakeAppointmentBtn.Text = "Make Appointment";
            this.MakeAppointmentBtn.UseTransparentBackground = true;
            this.MakeAppointmentBtn.Click += new System.EventHandler(this.MakeAppointmentBtn_Click);
            // 
            // donationDateDte
            // 
            this.donationDateDte.AutoRoundedCorners = true;
            this.donationDateDte.BackColor = System.Drawing.Color.Transparent;
            this.donationDateDte.BorderRadius = 25;
            this.donationDateDte.Checked = true;
            this.donationDateDte.FillColor = System.Drawing.Color.White;
            this.donationDateDte.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donationDateDte.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.donationDateDte.Location = new System.Drawing.Point(133, 281);
            this.donationDateDte.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.donationDateDte.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.donationDateDte.Name = "donationDateDte";
            this.donationDateDte.Size = new System.Drawing.Size(436, 52);
            this.donationDateDte.TabIndex = 29;
            this.donationDateDte.UseTransparentBackground = true;
            this.donationDateDte.Value = new System.DateTime(2023, 12, 22, 1, 8, 1, 371);
            // 
            // donationDate
            // 
            this.donationDate.BackColor = System.Drawing.Color.Transparent;
            this.donationDate.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donationDate.ForeColor = System.Drawing.Color.Black;
            this.donationDate.Location = new System.Drawing.Point(226, 215);
            this.donationDate.Name = "donationDate";
            this.donationDate.Size = new System.Drawing.Size(236, 37);
            this.donationDate.TabIndex = 28;
            this.donationDate.Text = "Donation_Date";
            // 
            // MakeAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.DonorIDTxtb);
            this.Controls.Add(this.DonorID);
            this.Controls.Add(this.MakeAppointmentBtn);
            this.Controls.Add(this.donationDateDte);
            this.Controls.Add(this.donationDate);
            this.Name = "MakeAppointment";
            this.Size = new System.Drawing.Size(1447, 601);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox DonorIDTxtb;
        private Guna.UI2.WinForms.Guna2HtmlLabel DonorID;
        private Guna.UI2.WinForms.Guna2Button MakeAppointmentBtn;
        private Guna.UI2.WinForms.Guna2DateTimePicker donationDateDte;
        private Guna.UI2.WinForms.Guna2HtmlLabel donationDate;
    }
}
