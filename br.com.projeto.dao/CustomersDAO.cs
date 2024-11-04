using salesControl.br.com.projeto.model;
using salesControl.br.com.views.customers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salesControl.br.com.projeto.dao
{
    public class CustomersDAO
    {   
        public void insertCustomer(Customers customers)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-81E0M5F\\SQLEXPRESS;Initial Catalog=sales_control;Integrated Security=True;";

                using (SqlConnection connection = new SqlConnection(connectionString)) 
                {
                    connection.Open();

                    string query = @"INSERT INTO Customers (name, rg, cpf, email, phone, postal_code, street, house_number, neighborhood, city, uf) 
                                    VALUES (@name, @rg, @cpf, @email, @phone, @postal_code, @street, @house_number, @neighborhood, @city, @uf)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", customers.Name);
                        command.Parameters.AddWithValue("@rg", customers.Rg);
                        command.Parameters.AddWithValue("@cpf", customers.Cpf);
                        command.Parameters.AddWithValue("@email", customers.Email);
                        command.Parameters.AddWithValue("@phone", customers.Phone);
                        command.Parameters.AddWithValue("@postal_code", customers.postalCode);
                        command.Parameters.AddWithValue("@street", customers.Street);
                        command.Parameters.AddWithValue("@house_number", customers.HouseNumber);
                        command.Parameters.AddWithValue("@neighborhood", customers.Neighborhood);
                        command.Parameters.AddWithValue("@city", customers.City);
                        command.Parameters.AddWithValue("@uf", customers.UF);

                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Erro: " + e.Message);
            }
        }
    }
}
