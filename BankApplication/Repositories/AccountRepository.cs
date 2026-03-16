using BankApplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApplication.Models;
using FluentResults;

namespace BankApplication.Repositories
{
    public class AccountRepository
    {
        private readonly BankDbContext _db;

        public AccountRepository(BankDbContext db)
        {
            _db = db;
        }

        public Result<List<Account>> GetAccountsForCustomer(int customerId)
        {
            var result = _db.Accounts.Where(acc => acc.CustomerId == customerId).ToList();
            if (result.Any())
            {
                return Result.Ok(result);
            }
            return Result.Fail("Failed to get list of accounts for customer");
        }

        public bool Add(Account newAccount)
        {
            _db.Accounts.Add(newAccount);
            return _db.SaveChanges() > 0;
        }

        public bool Update(int id, Account updatedAccount)
        {
            var existing = _db.Accounts.Find(id);
            if (existing == null) return false;

            existing.Balance = updatedAccount.Balance;
            existing.AccountNumber = updatedAccount.AccountNumber;
            existing.Status = updatedAccount.Status;
            existing.Transactions = updatedAccount.Transactions;

            return _db.SaveChanges() > 0;
        }

        public bool Delete(int id) 
        { 
            var account = _db.Accounts.Find(id);
            if (account == null) { return false; }
            _db.Accounts.Remove(account);
            return _db.SaveChanges() > 0;
        }
    }
}
