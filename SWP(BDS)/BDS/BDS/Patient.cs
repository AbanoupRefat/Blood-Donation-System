using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BDS
{
    internal class Patient
    {
        string Name { set; get; }
        string Phone { set; get; }
        string address { set; get; }
        string bloodType { set; get; }

        public void SaveToDatabase()
        {
            
            string connectionString = "Data Source=MSI;Initial Catalog=BloodDonationSystem;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Replace this query with the actual query to insert patient information into your Patients table
                string query = $"INSERT INTO Patients (Name, Phone, Address, BloodType) " +
                               $"VALUES ('{Name}', '{Phone}', '{address}', '{bloodType}')";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Execute the query
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
