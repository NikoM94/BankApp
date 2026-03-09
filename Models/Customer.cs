using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Models
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public List<Account> Accounts { get; set; }

        public readonly record struct CustomerParams
        {
            public readonly string FirstName;
            public readonly string LastName;
            public readonly string Address;
            public readonly string City;
            public readonly string PostCode;
            public readonly string Email;
            public readonly string Phone;
            public readonly List<string> AccountIDs;
        }
        public Customer(string firstName, string lastName, string address, string city, string postcode, string email, string phone, List<Account> accounts)
        { 
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.City = city;
            this.PostCode = postcode;
            this.Email = email;
            this.Phone = phone;
            this.Accounts = accounts;
        }

        public void AddAccount(Account account)
        {
            this.Accounts.Add(account);
            // UPDATE query here
        }

        public void RemoveAccount(Account account)
        {
            // Remove this customers foreign key from the account
        }

        public void EditCustomer(CustomerParams customerParams)
        {
            // UPDATE query here
        }
    }
}
