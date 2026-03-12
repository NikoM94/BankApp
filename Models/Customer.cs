using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public Customer
        (
            string firstName,
            string lastName,
            string address,
            string city,
            string zipcode,
            string email,
            string phone,
            string userName,
            string password
        )
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            ZipCode = zipcode;
            Email = email;
            Phone = phone;
            UserName = userName;
            Password = password;
        }
    }
}
