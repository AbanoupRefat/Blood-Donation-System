namespace BDS.CUT
{
    partial class UserLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
            this.LoginBtn = new Guna.UI2.WinForms.Guna2Button();
            this.PasswordTxtb = new Guna.UI2.WinForms.Guna2TextBox();
            this.UserNameTxtb = new Guna.UI2.WinForms.Guna2TextBox();
            this.Password = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.UserName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // LoginBtn
            // 
            this.LoginBtn.AutoRoundedCorners = true;
            this.LoginBtn.BackColor = System.Drawing.Color.Transparent;
            this.LoginBtn.BorderRadius = 21;
            this.LoginBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoginBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoginBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoginBtn.FillColor = System.Drawing.Color.Crimson;
            this.LoginBtn.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold);
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Location = new System.Drawing.Point(719, 389);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(180, 45);
            this.LoginBtn.TabIndex = 11;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseTransparentBackground = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // PasswordTxtb
            // 
            this.PasswordTxtb.AutoRoundedCorners = true;
            this.PasswordTxtb.BackColor = System.Drawing.Color.Transparent;
            this.PasswordTxtb.BorderColor = System.Drawing.Color.Black;
            this.PasswordTxtb.BorderRadius = 28;
            this.PasswordTxtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTxtb.DefaultText = "";
            this.PasswordTxtb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTxtb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTxtb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTxtb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTxtb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTxtb.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Bold);
            this.PasswordTxtb.ForeColor = System.Drawing.Color.Black;
            this.PasswordTxtb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTxtb.Location = new System.Drawing.Point(604, 252);
            this.PasswordTxtb.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.PasswordTxtb.Name = "PasswordTxtb";
            this.PasswordTxtb.PasswordChar = '\0';
            this.PasswordTxtb.PlaceholderText = "Enter Your Password";
            this.PasswordTxtb.SelectedText = "";
            this.PasswordTxtb.Size = new System.Drawing.Size(475, 58);
            this.PasswordTxtb.TabIndex = 10;
            // 
            // UserNameTxtb
            // 
            this.UserNameTxtb.AutoRoundedCorners = true;
            this.UserNameTxtb.BackColor = System.Drawing.Color.Transparent;
            this.UserNameTxtb.BorderColor = System.Drawing.Color.Black;
            this.UserNameTxtb.BorderRadius = 28;
            this.UserNameTxtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserNameTxtb.DefaultText = "";
            this.UserNameTxtb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UserNameTxtb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UserNameTxtb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserNameTxtb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserNameTxtb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserNameTxtb.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Bold);
            this.UserNameTxtb.ForeColor = System.Drawing.Color.Black;
            this.UserNameTxtb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserNameTxtb.Location = new System.Drawing.Point(604, 168);
            this.UserNameTxtb.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.UserNameTxtb.Name = "UserNameTxtb";
            this.UserNameTxtb.PasswordChar = '\0';
            this.UserNameTxtb.PlaceholderText = "Enter Your User_Name";
            this.UserNameTxtb.SelectedText = "";
            this.UserNameTxtb.Size = new System.Drawing.Size(475, 58);
            this.UserNameTxtb.TabIndex = 9;
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.White;
            this.Password.Location = new System.Drawing.Point(402, 273);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(163, 37);
            this.Password.TabIndex = 8;
            this.Password.Text = "Password:";
            // 
            // UserName
            // 
            this.UserName.BackColor = System.Drawing.Color.Transparent;
            this.UserName.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.Color.White;
            this.UserName.Location = new System.Drawing.Point(368, 189);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(197, 37);
            this.UserName.TabIndex = 7;
            this.UserName.Text = "User_Name\r\n\r\n:";
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PasswordTxtb);
            this.Controls.Add(this.UserNameTxtb);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.Name = "UserLogin";
            this.Size = new System.Drawing.Size(1447, 603);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button LoginBtn;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTxtb;
        private Guna.UI2.WinForms.Guna2TextBox UserNameTxtb;
        private Guna.UI2.WinForms.Guna2HtmlLabel Password;
        private Guna.UI2.WinForms.Guna2HtmlLabel UserName;
    }
}
