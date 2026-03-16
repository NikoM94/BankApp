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
using FluentResults;

namespace BankApplication.Forms
{
    public partial class LoginFM : Form
    {
        private readonly CustomerRepository _repository;
        public LoginFM()
        {
            InitializeComponent();
            _repository = new CustomerRepository(new BankDbContext());
        }

        private void LoginFMLoginBT_Click(object sender, EventArgs e)
        {
            string userName = LoginFMUsernameTB.Text.Trim();
            string password = LoginFMPasswordTB.Text.Trim();

            Result<Customer> customer = _repository.Login(userName, password);
            if (customer.IsSuccess)
            {
                BankMainView mainView = new BankMainView(customer.Value);
                this.Hide();
                mainView.Show();
            }
            else
            {
                string errorMessage = customer.Errors.FirstOrDefault()?.Message ?? "Unknown error";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
