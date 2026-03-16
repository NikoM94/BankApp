using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using BankApplication.Models;

namespace DataSeeder.Fakers
{
    public class CustomerFaker : Faker<Customer>
    {
        public CustomerFaker() : base("fi")
        {
            RuleFor(c => c.FirstName, (f, c) => f.Name.FirstName());
            RuleFor(c => c.LastName, (f, c) => f.Name.LastName());
            RuleFor(c => c.Address, (f, c) => f.Address.StreetAddress());
            RuleFor(c => c.City, (f, c) => f.Address.City());
            RuleFor(c => c.ZipCode, (f, c) => f.Address.ZipCode());
            RuleFor(c => c.Email, (f, c) => f.Internet.Email(c.FirstName, c.LastName));
            RuleFor(c => c.Phone, (f, c) => f.Phone.PhoneNumber());
            RuleFor(c => c.UserName, (f, c) => f.Internet.UserName());
            RuleFor(c => c.Password, (f, c) => "qwer123");
        }
    }
}
