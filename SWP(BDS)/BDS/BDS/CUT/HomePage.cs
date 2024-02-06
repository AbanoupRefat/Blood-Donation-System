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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            MedicalScreeningForm UC = new MedicalScreeningForm();
            addUserControle(UC);
        }
        private void addUserControle(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel_View2.Controls.Clear();
            panel_View2.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MedicalScreeningForm UC = new MedicalScreeningForm();
            addUserControle(UC);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            AddDonorForm UC = new AddDonorForm();
            addUserControle(UC);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            AddPatient UC = new AddPatient();
            addUserControle(UC);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            ViewDonationHistory UC = new ViewDonationHistory();
            addUserControle(UC);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            MakeAppointment makeAppointment = new MakeAppointment();
            addUserControle (makeAppointment);
        }

        private void Back_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 back = new Form1();
            back.Show();
        }

        private void exite_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
