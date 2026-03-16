using BankApplication.Data;
using BankApplication.Models;
using FluentResults;

namespace BankApplication.Repositories
{
    public class CustomerRepository
    {
        private readonly BankDbContext _db;

        public CustomerRepository(BankDbContext db)
        {
            _db = db;
        }

        public Result<List<Customer>> GetAll()
        {
            var result = _db.Customers.ToList();
            if (result.Any())
            {
                return Result.Ok(result);
            }
            return Result.Fail("Failed to get customers");
        }

        public bool Delete(int id)
        {
            var customer = _db.Customers.Find(id);
            if (customer == null) { return false; }
            _db.Customers.Remove(customer);
            return _db.SaveChanges() > 0;
        }

        public bool Add(Customer customer)
        {
            customer.Password = BCrypt.Net.BCrypt.HashPassword(customer.Password);

            _db.Customers.Add(customer);
            return _db.SaveChanges() > 0;
        }

        public bool Update(int id, Customer updatedCustomer)
        {
            var existing = _db.Customers.Find(id);
            if (existing == null) return false;

            existing.FirstName = updatedCustomer.FirstName;
            existing.LastName = updatedCustomer.LastName;
            existing.Address = updatedCustomer.Address;
            existing.City = updatedCustomer.City;
            existing.ZipCode = updatedCustomer.ZipCode;
            existing.Email = updatedCustomer.Email;
            existing.Phone = updatedCustomer.Phone;

            return _db.SaveChanges() > 0;
        }

        public Result<Customer> Login(string userName, string password)
        {
            var customer = _db.Customers.FirstOrDefault(u => u.UserName == userName);

            if (customer == null)
                return Result.Fail<Customer>("Invalid username");

            bool isValid = BCrypt.Net.BCrypt.Verify(password, customer.Password);

            if (!isValid)
                return Result.Fail<Customer>("Invalid password");

            return Result.Ok(customer);
        }

        public bool CustomerExists(string userName)
        {
            return _db.Customers.Any(u => u.UserName == userName);
        }
    }
}
