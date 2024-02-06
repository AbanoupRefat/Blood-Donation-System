using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDS
{
    internal class Donor
    { 
        public int Id { get; set; }
            public string Name { get; set; }
            public string BloodType { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
        DateTime DonationDate { set; get; }
        public void SaveToDatabase()
        {
            string connectionString = "Data Source=MSI;Initial Catalog=BloodDonationSystem;Integrated Security=True;";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Replace this query with the actual query to insert donor information into your Donors table
                string query = $"INSERT INTO Donors (Name, BloodType, Phone, Address) VALUES ('{Name}', '{BloodType}', '{Phone}', '{Address}')";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Execute the query
                    command.ExecuteNonQuery();
                }
            }
        }
    }
    }

