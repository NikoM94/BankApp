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
    public partial class LoginFM : Form
    {
        private readonly CustomerRepository _repository;
        public LoginFM()
        {
            InitializeComponent();
            _repository = new CustomerRepository(new DataBaseConnection());
        }

        private void LoginFMLoginBT_Click(object sender, EventArgs e)
        {
            string userName = LoginFMUsernameTB.Text;
            string password = LoginFMPasswordTB.Text;

            bool result = _repository.Login(userName, password);
        }
    }
}
