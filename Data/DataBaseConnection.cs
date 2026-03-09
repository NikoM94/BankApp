using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BankApplication.Data
{
    public class DataBaseConnection
    {
        private readonly string connectionString = "datasource=localhost; port=3306;username=root;password=;database=bank";

        public MySqlConnection CreateConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
