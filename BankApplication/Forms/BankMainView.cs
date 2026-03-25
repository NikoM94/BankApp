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
using System.Text.RegularExpressions;

namespace BankApplication.Forms
{
    public partial class BankMainView : Form
    {
        Customer _loggedInCustomer;
        AccountRepository _accountRepository;
        TransactionRepository _transactionRepository;
        List<Transaction> transactionsForAccount = new List<Transaction>();
        Control activeControl; 

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
            activeControl = AccountListingPL;
        }

        private void PopulateAccountsCB()
        {

            AccountsCB.DataSource = _loggedInCustomer.Accounts;
            AccountsCB.DisplayMember = "AccountNumber";
        }

        private void AccountsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowAllTransactionsForSelectedAccount();
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

        private void ResetSearchBT_Click(object sender, EventArgs e)
        {
            ShowAllTransactionsForSelectedAccount();
        }

        private void ShowAllTransactionsForSelectedAccount()
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

        private void SwitchDisplayedControl(Control controlToDisplay)
        {
            activeControl.Hide();
            activeControl = controlToDisplay;
            activeControl.Show();
        }

        private void transferFundsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchDisplayedControl(CreateTransactionPL);
            TransferFromCB.DataSource = _loggedInCustomer.Accounts;
            TransferFromCB.DisplayMember = "AccountNumber";
        }

        private void viewAllTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchDisplayedControl(AccountListingPL);
        }

        private void TransferBT_Click(object sender, EventArgs e)
        {
            string amount = TransferAmountTB.Text.Trim();
            if (!ValidateAmount(amount))
            {
                string? accountFromIBAN = TransferFromCB.Text.Trim();
                string accountToIBAN = TransferToTB.Text;
                string message = TransferMessageRTB.Text.Trim();
                double validAmount = Convert.ToDouble(amount);
                int AccountToId = _accountRepository.FindByAccountNumber(accountToIBAN).Value.Id;
                int AccountFromId = _accountRepository.FindByAccountNumber(accountFromIBAN).Value.Id;
                Transaction newTransaction = new Transaction(AccountFromId, AccountToId, validAmount, DateTime.Now, message);
                bool result = _transactionRepository.Add(newTransaction);
                if (result)
                {
                    MessageBox.Show("Transaction successful", "Succees", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Transaction unsuccessful", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateAmount(string amount)
        {
            string pattern = @"^\d{1,5},\d{2}$";
            Regex re = new Regex(pattern);
            if (re.IsMatch(amount))
            {
                return true;
            }
            return false;
        }
    }
}
