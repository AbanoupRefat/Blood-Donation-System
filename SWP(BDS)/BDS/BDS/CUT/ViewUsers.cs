using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace BDS.CUT
{
    public partial class ViewUsers : UserControl
    {
        private readonly DataTable usersTable = new DataTable();

        public ViewUsers()
        {
            InitializeComponent();

            // Sample columns (replace with your actual database columns)
            usersTable.Columns.Add("Username", typeof(string));
            usersTable.Columns.Add("FullName", typeof(string));
            usersTable.Columns.Add("Email", typeof(string));

            // Fetch data from the database
            FetchUserData();

            // Assign the data source to the DataGridView
            dataGridView1.DataSource = usersTable;

            // Event handlers
            Search.Click += Search_Click;
            
        }

        private void FetchUserData()
        {
            try
            {
                
                string connectionString = "Data Source=MSI;Initial Catalog=BloodDonationSystem;Integrated Security=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    
                    using (SqlCommand command = new SqlCommand("SELECT * FROM Users", connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(usersTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            
            string searchTerm = UserViewSearchTxtb.Text.Trim();
           
            DataView dv = new DataView(usersTable);
            dv.RowFilter = $"Username LIKE '%{searchTerm}%' OR FullName LIKE '%{searchTerm}%' OR Email LIKE '%{searchTerm}%'";
            dataGridView1.DataSource = dv.ToTable();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Retrieve values from the selected row
                string username = selectedRow.Cells["Username"].Value.ToString();
                string fullName = selectedRow.Cells["FullName"].Value.ToString();
                string email = selectedRow.Cells["Email"].Value.ToString();

                // Open a form for editing/updating the user
                // Example: OpenUpdateUserForm(username, fullName, email);
            }
            else
            {
                MessageBox.Show("Please select a user to update.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void Delete_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Retrieve values from the selected row
                string username = selectedRow.Cells["Username"].Value.ToString();

                // Confirm the delete operation
                DialogResult result = MessageBox.Show($"Are you sure you want to delete the user '{username}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Call a method to delete the user from the database
                    if (DeleteUser(username))
                    {
                        // Remove the row from the DataGridView
                        dataGridView1.Rows.Remove(selectedRow);
                        MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error deleting user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private bool DeleteUser(string username)
        {
            try
            {
                // Implement logic to delete the user from the database
                // Replace connection string and query with your actual values
                string connectionString = "YourConnectionStringHere";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Replace "Users" with the actual name of your users table
                    using (SqlCommand command = new SqlCommand($"DELETE FROM Users WHERE Username = '{username}'", connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

       
    }
}
