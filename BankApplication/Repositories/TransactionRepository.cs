using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApplication.Data;
using FluentResults;
using BankApplication.Models;

namespace BankApplication.Repositories
{
    public class TransactionRepository
    {
        private readonly BankDbContext _db;

        public TransactionRepository(BankDbContext db)
        {
            _db = db;
        }

        public Result<List<Transaction>> GetTransactionsForAccount(int accountIdFrom)
        {
            var result = _db.Transactions.Where(tr => tr.AccountIdFrom == accountIdFrom).ToList();
            if (result.Any())
            {
                return Result.Ok(result);
            }
            return Result.Fail("Failed to get list of accounts for customer");
        }

        public bool Add(Transaction newTransaction)
        {
            _db.Transactions.Add(newTransaction);
            return _db.SaveChanges() > 0;
        }

        public bool Delete(int id) 
        { 
            var account = _db.Transactions.Find(id);
            if (account == null) { return false; }
            _db.Transactions.Remove(account);
            return _db.SaveChanges() > 0;
        }
    }
}
