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
        List<Transaction> transactionsForAccount = new List<Transaction>();

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
                transactionsForAccount = _transactionRepository
                    .GetTransactionsForAccount(selectedAccount.Id).Value;

                AccountsDG.DataSource = transactionsForAccount.Select(t => new
                {
                    Amount = t.Amount.ToString("C"),
                    t.Message,
                    Date = t.Date.ToString()
                }).ToList();
            }
        }

        private void SearchTransactionBT_Click(object sender, EventArgs e)
        {
            var dateFrom = SearchFromDTP.Value;
            var dateTo = SearchToDTP.Value;
            bool searchText = SearchOptionsTextRB.Checked;
            bool searchFromTo = SearchOptionsFromToRB.Checked;
            string pattern = SearchTransactionsTB.Text;
            var filteredTransactions = new List<Transaction>();

            if (!searchText && !searchFromTo)
            {
                MessageBox.Show("Select search options", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!searchText && searchFromTo)
            {
                if (dateFrom < dateTo)
                {
                    filteredTransactions = transactionsForAccount.Where(t => t.Date >= dateFrom && t.Date <= dateTo).ToList();
                }
                else
                {
                    MessageBox.Show("Search from must be before search to", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                AccountsDG.DataSource = filteredTransactions;
                return;
            }
            if (searchText && !searchFromTo)
            {
                if (pattern != "")
                {
                    filteredTransactions = transactionsForAccount.Where(t => t.Message.Contains(pattern)).ToList();
                }
                else
                {
                    MessageBox.Show("Enter a text to search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                AccountsDG.DataSource = filteredTransactions;
                return;
            }
            else
            {
                if (pattern != "" && dateFrom < dateTo)
                {
                    filteredTransactions = transactionsForAccount.Where(t => t.Message.Contains(pattern) && t.Date >= dateFrom && t.Date <= dateTo).ToList();
                }
                else
                {
                    MessageBox.Show("Enter a text to search and select valid dates", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                AccountsDG.DataSource = filteredTransactions;
            }
        }
    }
}
