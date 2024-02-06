namespace BDS
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UserLoginBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AdminLoginBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel_view = new System.Windows.Forms.Panel();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.exite = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(730, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.exite);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1447, 72);
            this.panel1.TabIndex = 2;
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
            this.panel2.Controls.Add(this.UserLoginBtn);
            this.panel2.Controls.Add(this.AdminLoginBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1447, 71);
            this.panel2.TabIndex = 3;
            // 
            // UserLoginBtn
            // 
            this.UserLoginBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.UserLoginBtn.CheckedState.BorderColor = System.Drawing.Color.Red;
            this.UserLoginBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.UserLoginBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.UserLoginBtn.CheckedState.ForeColor = System.Drawing.Color.Red;
            this.UserLoginBtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.UserLoginBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UserLoginBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UserLoginBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UserLoginBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UserLoginBtn.FillColor = System.Drawing.Color.White;
            this.UserLoginBtn.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLoginBtn.ForeColor = System.Drawing.Color.Black;
            this.UserLoginBtn.Location = new System.Drawing.Point(723, 0);
            this.UserLoginBtn.Name = "UserLoginBtn";
            this.UserLoginBtn.Size = new System.Drawing.Size(724, 68);
            this.UserLoginBtn.TabIndex = 1;
            this.UserLoginBtn.Text = "User_Login";
            this.UserLoginBtn.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // AdminLoginBtn
            // 
            this.AdminLoginBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.AdminLoginBtn.Checked = true;
            this.AdminLoginBtn.CheckedState.BorderColor = System.Drawing.Color.Red;
            this.AdminLoginBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.AdminLoginBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.AdminLoginBtn.CheckedState.ForeColor = System.Drawing.Color.Red;
            this.AdminLoginBtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.AdminLoginBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AdminLoginBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AdminLoginBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AdminLoginBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AdminLoginBtn.FillColor = System.Drawing.Color.White;
            this.AdminLoginBtn.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLoginBtn.ForeColor = System.Drawing.Color.Black;
            this.AdminLoginBtn.Location = new System.Drawing.Point(0, 0);
            this.AdminLoginBtn.Name = "AdminLoginBtn";
            this.AdminLoginBtn.Size = new System.Drawing.Size(724, 68);
            this.AdminLoginBtn.TabIndex = 0;
            this.AdminLoginBtn.Text = "Admin_Login";
            this.AdminLoginBtn.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panel_view
            // 
            this.panel_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_view.Location = new System.Drawing.Point(0, 143);
            this.panel_view.Name = "panel_view";
            this.panel_view.Size = new System.Drawing.Size(1447, 603);
            this.panel_view.TabIndex = 4;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // exite
            // 
            this.exite.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exite.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exite.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exite.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exite.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exite.ForeColor = System.Drawing.Color.White;
            this.exite.Location = new System.Drawing.Point(1336, 12);
            this.exite.Name = "exite";
            this.exite.Size = new System.Drawing.Size(84, 45);
            this.exite.TabIndex = 16;
            this.exite.Text = "Exit";
            this.exite.Click += new System.EventHandler(this.exite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 746);
            this.Controls.Add(this.panel_view);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_view;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button AdminLoginBtn;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button UserLoginBtn;
        private Guna.UI2.WinForms.Guna2Button exite;
    }
}

