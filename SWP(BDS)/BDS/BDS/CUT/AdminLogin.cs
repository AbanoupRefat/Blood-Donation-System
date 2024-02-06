using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BDS.CUT
{
    public partial class AdminLogin : UserControl
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void AD_login_Load(object sender, EventArgs e)
        {

        }

        private void ADMINLOGINBTN(object sender, EventArgs e)
        {
            // Retrieve entered username and password from textboxes
            string enteredUsername = AdminNameTxtb.Text;
            string enteredPassword = AdminPasswordTxtb.Text;

            // Create an instance of the Admin class
            Admin currentAdmin = new Admin();

            // Populate properties of the Admin class with data from the UI
            currentAdmin.Username = enteredUsername;
            currentAdmin.Password = enteredPassword;

            // Validate admin credentials against the database
            if (ValidateAdmin(currentAdmin))
            {
                // Successful login
                MessageBox.Show("Admin login successful!");

                this.Hide();
                Adminform adminform=new Adminform();
                adminform.Show();
            }
            else
            {
                // Invalid username or password
                MessageBox.Show("Invalid admin credentials. Please try again.");
            }
        }

        private bool ValidateAdmin(Admin admin)
        {

            string connectionString = "Data Source=MSI;Initial Catalog=BloodDonationSystem;Integrated Security=True;";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"SELECT COUNT(*) FROM Admins WHERE Username = @Username AND Password = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Use parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@Username", admin.Username);
                    command.Parameters.AddWithValue("@Password", admin.Password);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    // If count is greater than 0, admin is valid
                    return count > 0;
                }
            }
        }

       
    }
}
