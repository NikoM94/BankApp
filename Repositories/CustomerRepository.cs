using BankApplication.Data;
using BankApplication.Models;
using MySql.Data.MySqlClient;
using BCrypt.Net;

namespace BankApplication.Repositories
{
    public class CustomerRepository
    {
        private readonly DataBaseConnection _dbConn;

        public CustomerRepository(DataBaseConnection dbConn)
        {
            _dbConn = dbConn;
        }

        public bool Delete(int id)
        {
            var connection = _dbConn.CreateConnection();
            var command = new MySqlCommand("DELETE FROM customers WHERE id = @id", connection);

            command.Parameters.Add("@id", MySqlDbType.Int32, id);

            connection.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                connection.Close();
                return true;
            }
            connection.Close();
            return false;
        }

        public bool Add(Customer customer)
        {
            var connection = _dbConn.CreateConnection();
            var command = new MySqlCommand("INSERT INTO customers " +
                "(firstname, lastname, address, city, zipcode, email, phone, username, password) " +
                "VALUES (@fn, @ln, @addr, @city, @zip, @email, @phone, @usrn, @pw)", connection);

            command.Parameters.AddWithValue("@fn", customer.FirstName);
            command.Parameters.AddWithValue("@ln", customer.LastName);
            command.Parameters.AddWithValue("@addr", customer.Address);
            command.Parameters.AddWithValue("@city", customer.City);
            command.Parameters.AddWithValue("@zip", customer.ZipCode);
            command.Parameters.AddWithValue("@email", customer.Email);
            command.Parameters.AddWithValue("@phone", customer.Phone);
            command.Parameters.AddWithValue("@usrn", customer.UserName);
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(customer.Password);
            command.Parameters.AddWithValue("@pw", passwordHash);

            connection.Open();

            if (command.ExecuteNonQuery() == 1)
            {
                connection.Close();
                return true;
            }
            connection.Close();
            return false;
        }

        public bool Update(int id, Customer customer)
        {
            var connection = _dbConn.CreateConnection();
            connection.Open();
            var command = new MySqlCommand("UPDATE Customers SET " +
                "firstname = @fn " +
                "lastname = @ln " +
                "address = @addr " +
                "city = @city " +
                "zipcode = @zip " +
                "email = @email " +
                "phone = @phone " +
                " WHERE id = @id", connection);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = customer.FirstName;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = customer.LastName;
            command.Parameters.Add("@addr", MySqlDbType.VarChar).Value = customer.Address;
            command.Parameters.Add("@ciy", MySqlDbType.VarChar).Value = customer.City;
            command.Parameters.Add("@zip", MySqlDbType.VarChar).Value = customer.ZipCode;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = customer.Email;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = customer.Phone;

            connection.Open();

            if (command.ExecuteNonQuery() == 1)
            {
                connection.Close();
                return true;
            }
            connection.Close();
            return false;
        }
    }
}
