using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Models
{
    public class Transaction
    {
        public string AccountNumberFrom { get; set; }
        public string AccountNumberTo { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public string Details { get; set; }

        public Transaction(string accountNumberFrom, string accountNumberTo, double amount, DateTime date, string details) 
        { 
            this.AccountNumberTo = accountNumberTo;
            this.Amount = amount;
            this.Date = date;
            this.Details = details;
            this.AccountNumberFrom = accountNumberFrom;
        }

        public void MakeTransaction()
        {
        }
    }
}
