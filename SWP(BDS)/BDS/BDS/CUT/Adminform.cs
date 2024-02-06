using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDS.CUT
{
    public partial class Adminform : Form
    {
        public Adminform()
        {
            InitializeComponent();
            Add_User addUser = new Add_User();
            addUserControle(addUser);
        }
        private void addUserControle(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel2_view.Controls.Clear();
            panel2_view.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void Admin_form_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ViewUsers us = new ViewUsers();
            addUserControle(us);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Add_User addUser = new Add_User();
            addUserControle(addUser);
        }

        private void exite_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
