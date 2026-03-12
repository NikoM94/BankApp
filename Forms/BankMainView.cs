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

namespace BankApplication.Forms
{
    public partial class BankMainView : Form
    {
        Customer _loggedInCustomer;
        public BankMainView(Customer loggedInCustomer)
        {
            InitializeComponent();
            _loggedInCustomer = loggedInCustomer;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
