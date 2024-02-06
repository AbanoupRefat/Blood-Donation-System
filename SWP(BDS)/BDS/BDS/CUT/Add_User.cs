using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BDS.CUT
{
    public partial class Add_User : UserControl
    {
        public Add_User()
        {
            InitializeComponent();
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            User currentUser = new User();
            currentUser.Username = UserNameTxtb.Text;
            currentUser.Password = Password1Txtb.Text;
            currentUser.Name = EmployeeNameTxtb.Text;
            currentUser.Address = EmployeeAdressTxtb.Text;
            currentUser.Phone = EmployeePhoneTxtb.Text;

            // Now you can use the currentUser object as needed, for example, save it to a database
            // You might also consider more secure ways to handle passwords, such as hashing and salting
            // Store the currentUser object in a database or perform other actions with it
            SaveUserToDatabase(currentUser);

            MessageBox.Show("User information saved successfully!");
        }

        private void SaveUserToDatabase(User user)
        {
            // Your logic to save the user to the database goes here
            // This could involve using ADO.NET, Entity Framework, or another data access technology
            // Example: Save user information to a Users table in a SQL Server database
            string query = $"INSERT INTO Users (Username, Password, Name, Phone, Address) " +
                           $"VALUES ('{user.Username}', '{user.Password}', '{user.Name}', '{user.Phone}', '{user.Address}')";

            string connectionString = "Data Source=MSI;Initial Catalog=BloodDonationSystem;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
