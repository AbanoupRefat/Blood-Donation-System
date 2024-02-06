namespace BDS.CUT
{
    partial class ViewDonationHistory
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewDonationHistory));
            this.ViewDonationHistoeyBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DonorIDTxtb = new Guna.UI2.WinForms.Guna2TextBox();
            this.DonorID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.donorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bloodDonationSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bloodDonationSystemDataSet = new BDS.BloodDonationSystemDataSet();
            this.donorsTableAdapter = new BDS.BloodDonationSystemDataSetTableAdapters.DonorsTableAdapter();
            this.donorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodDonationSystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodDonationSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewDonationHistoeyBtn
            // 
            this.ViewDonationHistoeyBtn.AutoRoundedCorners = true;
            this.ViewDonationHistoeyBtn.BackColor = System.Drawing.Color.Transparent;
            this.ViewDonationHistoeyBtn.BorderRadius = 25;
            this.ViewDonationHistoeyBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ViewDonationHistoeyBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ViewDonationHistoeyBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ViewDonationHistoeyBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ViewDonationHistoeyBtn.FillColor = System.Drawing.Color.RoyalBlue;
            this.ViewDonationHistoeyBtn.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold);
            this.ViewDonationHistoeyBtn.ForeColor = System.Drawing.Color.White;
            this.ViewDonationHistoeyBtn.Location = new System.Drawing.Point(911, 349);
            this.ViewDonationHistoeyBtn.Name = "ViewDonationHistoeyBtn";
            this.ViewDonationHistoeyBtn.Size = new System.Drawing.Size(418, 53);
            this.ViewDonationHistoeyBtn.TabIndex = 26;
            this.ViewDonationHistoeyBtn.Text = "View Donors";
            this.ViewDonationHistoeyBtn.UseTransparentBackground = true;
            this.ViewDonationHistoeyBtn.Click += new System.EventHandler(this.ViewDonorBtn_Click);
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
            this.DonorIDTxtb.Location = new System.Drawing.Point(932, 232);
            this.DonorIDTxtb.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.DonorIDTxtb.Name = "DonorIDTxtb";
            this.DonorIDTxtb.PasswordChar = '\0';
            this.DonorIDTxtb.PlaceholderText = "Enter Donor_ID";
            this.DonorIDTxtb.SelectedText = "";
            this.DonorIDTxtb.Size = new System.Drawing.Size(376, 44);
            this.DonorIDTxtb.TabIndex = 31;
            // 
            // DonorID
            // 
            this.DonorID.BackColor = System.Drawing.Color.Transparent;
            this.DonorID.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorID.ForeColor = System.Drawing.Color.Black;
            this.DonorID.Location = new System.Drawing.Point(1049, 187);
            this.DonorID.Name = "DonorID";
            this.DonorID.Size = new System.Drawing.Size(162, 37);
            this.DonorID.TabIndex = 30;
            this.DonorID.Text = "Donor_ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.donorIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.bloodTypeDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.donorsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(23, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(679, 544);
            this.dataGridView1.TabIndex = 32;
            // 
            // donorIDDataGridViewTextBoxColumn
            // 
            this.donorIDDataGridViewTextBoxColumn.DataPropertyName = "DonorID";
            this.donorIDDataGridViewTextBoxColumn.HeaderText = "DonorID";
            this.donorIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.donorIDDataGridViewTextBoxColumn.Name = "donorIDDataGridViewTextBoxColumn";
            this.donorIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.donorIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // bloodTypeDataGridViewTextBoxColumn
            // 
            this.bloodTypeDataGridViewTextBoxColumn.DataPropertyName = "BloodType";
            this.bloodTypeDataGridViewTextBoxColumn.HeaderText = "BloodType";
            this.bloodTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bloodTypeDataGridViewTextBoxColumn.Name = "bloodTypeDataGridViewTextBoxColumn";
            this.bloodTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // donorsBindingSource
            // 
            this.donorsBindingSource.DataMember = "Donors";
            this.donorsBindingSource.DataSource = this.bloodDonationSystemDataSetBindingSource;
            // 
            // bloodDonationSystemDataSetBindingSource
            // 
            this.bloodDonationSystemDataSetBindingSource.DataSource = this.bloodDonationSystemDataSet;
            this.bloodDonationSystemDataSetBindingSource.Position = 0;
            // 
            // bloodDonationSystemDataSet
            // 
            this.bloodDonationSystemDataSet.DataSetName = "BloodDonationSystemDataSet";
            this.bloodDonationSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // donorsTableAdapter
            // 
            this.donorsTableAdapter.ClearBeforeFill = true;
            // 
            // donorsBindingSource1
            // 
            this.donorsBindingSource1.DataMember = "Donors";
            this.donorsBindingSource1.DataSource = this.bloodDonationSystemDataSetBindingSource;
            // 
            // ViewDonationHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DonorIDTxtb);
            this.Controls.Add(this.DonorID);
            this.Controls.Add(this.ViewDonationHistoeyBtn);
            this.Name = "ViewDonationHistory";
            this.Size = new System.Drawing.Size(1447, 601);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodDonationSystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodDonationSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button ViewDonationHistoeyBtn;
        private Guna.UI2.WinForms.Guna2TextBox DonorIDTxtb;
        private Guna.UI2.WinForms.Guna2HtmlLabel DonorID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bloodDonationSystemDataSetBindingSource;
        private BloodDonationSystemDataSet bloodDonationSystemDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource donorsBindingSource;
        private BloodDonationSystemDataSetTableAdapters.DonorsTableAdapter donorsTableAdapter;
        private System.Windows.Forms.BindingSource donorsBindingSource1;
    }
}
