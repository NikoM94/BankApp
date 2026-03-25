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

namespace BankApplication.Controls
{
    public partial class AccountCardControl : UserControl
    {
        public AccountCardControl()
        {
            InitializeComponent();
        }

        public void UpdateData(Account account)
        {
            AccountNumberLB.Text = account.AccountNumber;
            BalanceLB.Text = $"{account.Balance:F2} €"; // Kaksi desimaalia

            BalanceLB.ForeColor = account.Balance < 0 ? Color.Red : Color.Green;
        }
    }
}
