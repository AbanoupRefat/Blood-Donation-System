using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BDS.CUT
{
    public partial class AddPatient : UserControl
    {
        public AddPatient()
        {
            InitializeComponent();
        }

        private void A_P_Load(object sender, EventArgs e)
        {
            // Any additional initialization code can go here
        }

        private void AddPationtBtn_Click(object sender, EventArgs e)
        {
            // Validate input before proceeding
            if (ValidateInput())
            {
                // Create a new patient object with the entered information
                Patient patient = new Patient
                {
                    Name = PationtNameTxtb.Text,
                    Phone = PationtPhoneTxtb.Text,
                    Address = PationtAdressTxtb.Text,
                    BloodType = PationtBloodTypeCb.Text
                };

                // Save the patient information to the database
                patient.SaveToDatabase();

                // Optionally, you can show a message to indicate success or perform other actions.
                MessageBox.Show("Patient information saved successfully.");

                // Clear the form after saving
                ClearForm();
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(PationtNameTxtb.Text))
            {
                MessageBox.Show("Please enter the patient's name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(PationtPhoneTxtb.Text))
            {
                MessageBox.Show("Please enter the patient's phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Add more validations as needed

            // All validations passed
            return true;
        }

        private void ClearForm()
        {
            // Clear the textboxes and reset other controls
            PationtNameTxtb.Clear();
            PationtPhoneTxtb.Clear();
            PationtAdressTxtb.Clear();
            PationtBloodTypeCb.SelectedIndex = -1; // Assuming BloodType is a ComboBox
        }
    }

    internal class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string BloodType { get; set; }

        public void SaveToDatabase()
        {
            string connectionString = "Data Source=MSI;Initial Catalog=BloodDonationSystem;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Replace this query with the actual query to insert patient information into your Patients table
                string query = $"INSERT INTO Patients (Name, Phone, Address, BloodType) " +
                               $"VALUES ('{Name}', '{Phone}', '{Address}', '{BloodType}')";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Execute the query
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
