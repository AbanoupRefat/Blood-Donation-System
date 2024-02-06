namespace BDS.CUT
{
    partial class Adminform
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ViewUsersBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AddUserBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel2_view = new System.Windows.Forms.Panel();
            this.exite = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.exite);
            this.panel1.Controls.Add(this.label2);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.ViewUsersBtn);
            this.panel2.Controls.Add(this.AddUserBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1447, 70);
            this.panel2.TabIndex = 4;
            // 
            // ViewUsersBtn
            // 
            this.ViewUsersBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ViewUsersBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.ViewUsersBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.ViewUsersBtn.CheckedState.ForeColor = System.Drawing.Color.Red;
            this.ViewUsersBtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.ViewUsersBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ViewUsersBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ViewUsersBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ViewUsersBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ViewUsersBtn.FillColor = System.Drawing.Color.White;
            this.ViewUsersBtn.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold);
            this.ViewUsersBtn.ForeColor = System.Drawing.Color.Black;
            this.ViewUsersBtn.Location = new System.Drawing.Point(734, 0);
            this.ViewUsersBtn.Name = "ViewUsersBtn";
            this.ViewUsersBtn.Size = new System.Drawing.Size(713, 70);
            this.ViewUsersBtn.TabIndex = 1;
            this.ViewUsersBtn.Text = "View_Users";
            this.ViewUsersBtn.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.AddUserBtn.Checked = true;
            this.AddUserBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.AddUserBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.AddUserBtn.CheckedState.ForeColor = System.Drawing.Color.Red;
            this.AddUserBtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.AddUserBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddUserBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddUserBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddUserBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddUserBtn.FillColor = System.Drawing.Color.White;
            this.AddUserBtn.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold);
            this.AddUserBtn.ForeColor = System.Drawing.Color.Black;
            this.AddUserBtn.Location = new System.Drawing.Point(0, 0);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Size = new System.Drawing.Size(732, 70);
            this.AddUserBtn.TabIndex = 0;
            this.AddUserBtn.Text = "Add_User";
            this.AddUserBtn.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panel2_view
            // 
            this.panel2_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2_view.Location = new System.Drawing.Point(0, 142);
            this.panel2_view.Name = "panel2_view";
            this.panel2_view.Size = new System.Drawing.Size(1447, 604);
            this.panel2_view.TabIndex = 5;
            // 
            // exite
            // 
            this.exite.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exite.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exite.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exite.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exite.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exite.ForeColor = System.Drawing.Color.White;
            this.exite.Location = new System.Drawing.Point(1322, 12);
            this.exite.Name = "exite";
            this.exite.Size = new System.Drawing.Size(84, 45);
            this.exite.TabIndex = 16;
            this.exite.Text = "Exit";
            this.exite.Click += new System.EventHandler(this.exite_Click);
            // 
            // Adminform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 746);
            this.Controls.Add(this.panel2_view);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Adminform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Admin_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel2_view;
        private Guna.UI2.WinForms.Guna2Button ViewUsersBtn;
        private Guna.UI2.WinForms.Guna2Button AddUserBtn;
        private Guna.UI2.WinForms.Guna2Button exite;
    }
}