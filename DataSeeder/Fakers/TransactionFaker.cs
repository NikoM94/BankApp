using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApplication.Models;
using Bogus;

namespace DataSeeder.Fakers
{
    public class TransactionFaker : Faker<Transaction>
    {
        public TransactionFaker(List<Account> accounts) : base("fi")
        {
            RuleFor(t => t.Id, f => 0);
            RuleFor(t => t.AccountIdFrom, f => f.PickRandom(accounts).Id);
            RuleFor(t => t.AccountIdTo, (f, t) =>
            {
                int toId;
                do
                {
                    toId = f.PickRandom(accounts).Id;
                } while (toId == t.AccountIdFrom);

                return toId;
            });

            RuleFor(t => t.Amount, f => f.Random.Double(5, 500));
            RuleFor(t => t.Date, f => f.Date.Past(1));
            RuleFor(t => t.Message, f => f.Finance.TransactionType());
        }
    }
}
