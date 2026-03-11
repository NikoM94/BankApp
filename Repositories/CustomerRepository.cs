using BankApplication.Data;
using BankApplication.Models;
using MySql.Data.MySqlClient;

namespace BankApplication.Repositories
{
    public class CustomerRepository
    {
        private readonly DataBaseConnection dbConn;

        public CustomerRepository(DataBaseConnection dbConn)
        {
            this.dbConn = dbConn;
        }

        public bool Delete(int id)
        {
            var connection = dbConn.CreateConnection();
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
            var connection = dbConn.CreateConnection();
            connection.Open();
            var command = new MySqlCommand("INSERT INTO customers " +
                "(firstname, lastname, address, city, postcode, email, phone) " +
                "VALUES (@fn, @ln, @addr, @city, @pcode, @email, @phone)", connection);

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
            var connection = dbConn.CreateConnection();
            connection.Open();
            var command = new MySqlCommand("UPDATE Customers SET " +
                "firstname = @fname " +
                "lastname = @lname " +
                "address = @addr " +
                "city = @city " +
                "postcode = @pcode " +
                "email = @email " +
                "phone = @phone " +
                " WHERE id = @id", connection);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = customerParams.FirstName;
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = customerParams.LastName;
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = customerParams.Address;
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = customerParams.City;
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = customerParams.PostCode;
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = customerParams.Email;
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = customerParams.Phone;

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
