using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankApplication.Models;
using BankApplication.Repositories;
using BankApplication.Data;

namespace BankApplication.Forms
{
    public partial class BankMainView : Form
    {
        Customer _loggedInCustomer;
        AccountRepository _accountRepository;
        TransactionRepository _transactionRepository;

        public BankMainView(Customer loggedInCustomer, BankDbContext _context)
        {
            InitializeComponent();
            _loggedInCustomer = loggedInCustomer;
            _accountRepository = new AccountRepository(_context);
            _transactionRepository = new TransactionRepository(_context);
            _loggedInCustomer.Accounts = _accountRepository.GetAccountsForCustomer(_loggedInCustomer.Id).Value;
        }

        private void BankMainView_Load(object sender, EventArgs e)
        {
            PopulateAccountsCB();
        }

        private void PopulateAccountsCB()
        {

            AccountsCB.DataSource = _loggedInCustomer.Accounts;
            AccountsCB.DisplayMember = "AccountNumber";
        }

        private void AccountsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AccountsCB.SelectedItem is Account selectedAccount)
            {
                var transactionsForAccount = _transactionRepository
                    .GetTransactionsForAccount(selectedAccount.Id).Value;

                AccountsDG.DataSource = transactionsForAccount.Select(t => new
                {
                    Amount = t.Amount.ToString("C"),
                    t.Message,
                    Date = t.Date.ToString()
                }).ToList();
            }
        }
    }
}
