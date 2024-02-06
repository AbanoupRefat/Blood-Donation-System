using BDS.CUT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AdminLogin aD = new AdminLogin();
            addUserControle(aD);
        }
        private void addUserControle(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel_view.Controls.Clear();
            panel_view.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AdminLogin aD = new AdminLogin();
            addUserControle(aD);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UserLogin aD = new UserLogin();
            addUserControle(aD);
        }

        private void exite_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
