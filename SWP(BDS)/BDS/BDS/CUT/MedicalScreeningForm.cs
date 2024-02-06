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
    public partial class MedicalScreeningForm : UserControl
    {
        public MedicalScreeningForm()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void checkScreening(object sender, EventArgs e)
        {
            // Perform validation before allowing entry to the Add Donor page
            if (ValidateMedicalScreening())
            {
                // If validation is successful, navigate to the Add Donor page or perform other actions
                MessageBox.Show("Validation successful! Proceed to Add Donor page.");
                this.Hide();
                AddDonorForm addDonorForm = new AddDonorForm();
                addDonorForm.Show();
            }
            else
            {
                // If validation fails, show an error message or take appropriate action
                MessageBox.Show("Validation failed. Please check your inputs.");
            }
        }
        private bool ValidateMedicalScreening()
        {
            // Perform validation checks on the input values

            // Example: Check if Hemoglobin value is within a valid range
            if (!double.TryParse(HemoglobinTxt.Text, out double hemoglobin) || hemoglobin < 10 || hemoglobin > 20)
            {
                MessageBox.Show("Invalid Hemoglobin value. Please enter a valid value between 10 and 20.");
                return false;
            }

            // Example: Check if Pulse value is within a valid range
            if (!int.TryParse(PulseTxtb.Text, out int pulse) || pulse < 60 || pulse > 100)
            {
                MessageBox.Show("Invalid Pulse value. Please enter a valid value between 60 and 100.");
                return false;
            }

            // Example: Check if Blood Pressure value is within a valid range
            if (!int.TryParse(BloodPressureTxtb.Text, out int bloodPressure) || bloodPressure < 80 || bloodPressure > 120)
            {
                MessageBox.Show("Invalid Blood Pressure value. Please enter a valid value between 80 and 120.");
                return false;
            }

            // Example: Check if Temperature value is within a valid range
            if (!double.TryParse(TempTxtb.Text, out double temperature) || temperature < 36.0 || temperature > 37.5)
            {
                MessageBox.Show("Invalid Temperature value. Please enter a valid value between 36.0 and 37.5.");
                return false;
           
            }
            // If all validation checks pass, return true
            return true;
        }

    }
}
