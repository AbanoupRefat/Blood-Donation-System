using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BDS.CUT
{
    public partial class UserLogin : UserControl
    {
        public UserLogin()
        {
            InitializeComponent();
        }
        private bool ValidateUser(string username, string password)
        {
            string connectionString = "Data Source=MSI;Initial Catalog=BloodDonationSystem;Integrated Security=True;";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

               
                string query = $"SELECT COUNT(*) FROM Users WHERE Username = '{username}' AND Password = '{password}'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    // If count is greater than 0, user is valid
                    return count > 0;
                }
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            // Create an instance of the User class
            User currentUser = new User();

            // Populate properties of the User class with data from the UI
            currentUser.Username = UserNameTxtb.Text;
            currentUser.Password = PasswordTxtb.Text;

            if (ValidateUser(currentUser.Username, currentUser.Password))
            {
                // Successful login, hide the current login window
                this.Hide();

                // Open the "User_Form" window
                HomePage userForm = new HomePage();
                userForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        
    }
}
 