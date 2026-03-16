using BankApplication.Data;
using BankApplication.Models;
using DataSeeder.Fakers;
using Microsoft.EntityFrameworkCore;

namespace DataSeeder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string connectionString = "server=localhost;user=root;password=;database=bank";
            var serverVersion = ServerVersion.AutoDetect(connectionString);

            var optionsBuilder = new DbContextOptionsBuilder<BankDbContext>();
            optionsBuilder.UseMySql(connectionString, serverVersion);

            using (var context = new BankDbContext(optionsBuilder.Options))
            {
                Console.WriteLine("Preparing database...");
                context.Database.EnsureCreated();

                Console.WriteLine("Cleaning old data...");
                context.Transactions.ExecuteDelete();
                context.Accounts.ExecuteDelete();
                context.Customers.ExecuteDelete();

                Console.WriteLine("Generating new test data...");

                var customers = new CustomerFaker().Generate(10);
                context.Customers.AddRange(customers);
                context.SaveChanges();

                Console.WriteLine("Asiakkaat tallennettu. Luodaan tilejä...");
                var savedCustomers = context.Customers.ToList();
                var accounts = new AccountFaker(savedCustomers).Generate(20);

                Console.WriteLine("Tilit generoitu muistiin. Luodaan transaktioita...");

                context.Accounts.AddRange(accounts);
                context.SaveChanges();

                var transactions = new TransactionFaker(accounts).Generate(50);
                context.Transactions.AddRange(transactions);
                Console.WriteLine("Transaktiot luotu.");

                context.SaveChanges();
                Console.WriteLine("Transaktiot tallennettu.");

                var testUser = customers.First();
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("SEEDING DONE!");
                Console.WriteLine($"Created: {customers.Count} customers, {accounts.Count} accounts.");
                Console.WriteLine($"Example customer: {testUser.FirstName} {testUser.LastName}");
                Console.WriteLine($"Username: {testUser.UserName}");
                Console.WriteLine("-----------------------------------------");
            }

            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}
