using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Models
{
    public class Transaction
    {
        public int AccountIdFrom { get; set; }
        public int AccountIdTo { get; set; }
        public double? Amount { get; set; }
        public DateTime? Date { get; set; }
        public string? Details { get; set; }
        public int Id { get; set; }

        public Transaction(int accountIdFrom, int accountIdTo, double amount, DateTime date, string details) 
        { 
            this.AccountIdFrom = accountIdFrom;
            this.Amount = amount;
            this.Date = date;
            this.Details = details;
            this.AccountIdTo = accountIdTo;
        }

        public Transaction() { }
    }
}
