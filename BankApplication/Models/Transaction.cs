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
        public double Amount { get; set; }
        public DateTime? Date { get; set; }
        public string Message { get; set; }
        public int Id { get; set; }
        public Account AccountFrom { get; set; } = null!;
        public Account AccountTo { get; set; } = null!;

        public Transaction(int accountIdFrom, int accountIdTo, double amount, DateTime date, string message) 
        { 
            AccountIdFrom = accountIdFrom;
            Amount = amount;
            Date = date;
            Message = message;
            AccountIdTo = accountIdTo;
        }

        public Transaction() { }
    }
}
