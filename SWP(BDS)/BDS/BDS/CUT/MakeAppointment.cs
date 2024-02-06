using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDS.CUT
{
    public partial class MakeAppointment : UserControl
    {
        public MakeAppointment()
        {
            InitializeComponent();
        }

        private void MakeAppointmentBtn_Click(object sender, EventArgs e)
        {
            string donorID = DonorIDTxtb.Text.Trim();

            // Validate that the donor ID is not empty
            if (string.IsNullOrWhiteSpace(donorID))
            {
                MessageBox.Show("Please enter a valid Donor ID.");
                return;
            }

            // Check if the donor ID exists in the database
            if (DonorIDExists(donorID))
            {
                // If donor ID exists, show a message box with the entered date and donor ID
                DateTime selectedDate = donationDateDte.Value;
                string message = $"Donor ID: {donorID}\nAppointment Date: {selectedDate}\nAn email has been sent to the donor.";
                MessageBox.Show(message);

              
            }
            else
            {
                // If donor ID doesn't exist, show an error message
                MessageBox.Show("Invalid Donor ID. Please enter a valid ID.");
            }
        }

        // Check if the donor ID exists in the database (placeholder method)
        private bool DonorIDExists(string donorID)
        {
            string connectionString = "Data Source=MSI;Initial Catalog=BloodDonationSystem;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Example query: Adjust this based on your database schema
                string query = $"SELECT COUNT(*) FROM Donors WHERE DonorID = '{donorID}'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }

    }

