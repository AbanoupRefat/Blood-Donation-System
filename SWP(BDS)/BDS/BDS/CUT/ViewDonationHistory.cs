using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BDS.CUT
{
    public partial class ViewDonationHistory : UserControl
    {
        private DataTable donorDataTable;

        public ViewDonationHistory()
        {
            InitializeComponent();

            // Initialize DataTable
            donorDataTable = new DataTable();

            // Set up columns in the DataTable
            donorDataTable.Columns.Add("DonorID", typeof(int));
            donorDataTable.Columns.Add("Name", typeof(string));
            donorDataTable.Columns.Add("BloodType", typeof(string));
            donorDataTable.Columns.Add("Phone", typeof(string));
            donorDataTable.Columns.Add("Address", typeof(string));

            // Bind DataTable to DataGridView
            dataGridView1.DataSource = donorDataTable;
        }

        private void ViewDonorBtn_Click(object sender, EventArgs e)
        {
            // Clear previous data
            donorDataTable.Rows.Clear();

            // Retrieve entered donor ID from the textbox
            if (int.TryParse(DonorIDTxtb.Text, out int donorID))
            {
                // Create a connection string
                string connectionString = "Data Source=MSI;Initial Catalog=BloodDonationSystem;Integrated Security=True;";

                // Create a SQL query to select donor information by ID
                string query = "SELECT * FROM Donors WHERE DonorID = @DonorID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add a parameter for the donor ID
                        command.Parameters.AddWithValue("@DonorID", donorID);

                        // Execute the query
                        SqlDataReader reader = command.ExecuteReader();

                        // Check if a donor was found
                        if (reader.Read())
                        {
                            // Add the donor data to the DataTable
                            donorDataTable.Rows.Add(
                                reader["DonorID"],
                                reader["Name"],
                                reader["BloodType"],
                                reader["Phone"],
                                reader["Address"]
                            );
                        }
                        else
                        {
                            MessageBox.Show("Donor not found with the provided ID.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric Donor ID.");
            }
        }
    }
}
