using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApplication;
using BankApplication.Models;
using Bogus;

namespace DataSeeder.Fakers
{

    public class AccountFaker : Faker<Account>
    {
        public AccountFaker(List<Customer> customers) : base("fi")
        {
            RuleFor(a => a.Id, f => 0);
            RuleFor(a => a.CustomerId, f => f.PickRandom(customers).Id);
            RuleFor(a => a.AccountNumber, f => f.Finance.Iban());
            RuleFor(a => a.Balance, f => f.Random.Double(0, 5000));
            RuleFor(a => a.Status, f => AccountStatus.Active);
            RuleFor(a => a.Transactions, f => new List<Transaction>());
        }
    }
}
