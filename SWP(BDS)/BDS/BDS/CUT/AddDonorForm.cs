using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace BDS.CUT
{
    public partial class AddDonorForm : UserControl
    {
        public AddDonorForm()
        {
            InitializeComponent();
        }

        private void A_D_F_Load(object sender, EventArgs e)
        {
            // You can perform any initialization logic here
        }

        private void Adddonor_Click(object sender, EventArgs e)
        {
            // Get donor information from the form
            string name = DonorNameTxtb.Text;
            string bloodType = DonorBloodTypeCb.Text;
            string phone = DonorPhoneTxtb.Text;
            string address = DonorAdressTxtb.Text;

            // Validate input
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(bloodType) || string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Please fill in all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop further processing if validation fails
            }

            // Validate phone number (you can add more sophisticated validation)
            if (!IsValidPhoneNumber(phone))
            {
                MessageBox.Show("Please enter a valid phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop further processing if validation fails
            }

            // Create a new Donor object
            Donor donor = new Donor
            {
                Name = name,
                BloodType = bloodType,
                Phone = phone,
                Address = address
            };

            // Save the donor information to the database
            donor.SaveToDatabase();
            MessageBox.Show("Donor added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Optionally, you can clear the form fields after saving
            ClearForm();
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // You can implement more sophisticated phone number validation here
            // For simplicity, this example checks if the phone number contains only digits
            return !string.IsNullOrEmpty(phoneNumber) && phoneNumber.All(char.IsDigit);
        }

        private void ClearForm()
        {
            // Add code here to clear the form fields
            DonorNameTxtb.Clear();
            DonorBloodTypeCb.SelectedIndex = -1;
            DonorPhoneTxtb.Clear();
            DonorAdressTxtb.Clear();
        }


     
    }
}
