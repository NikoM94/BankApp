using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Models
{
    public class Account
    {
        public double Balance { get; set; } = 0;
        public string AccountNumber { get; set; } = string.Empty;
        public AccountStatus Status { get; set; } = AccountStatus.Active;
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
        public int CustomerId { get; set; }
        public int Id { get; set; }

        public Account(double balance, string accountNumber, AccountStatus status, List<Transaction> transactions, int customerId)
        {
            Balance = balance;
            AccountNumber = accountNumber;
            Status = status;
            Transactions = transactions;
            CustomerId = customerId;
        }

        public Account() { }
    }
}

namespace BankApplication
{
    public enum AccountStatus
    {
        Active,
        Inactive,
    }
}