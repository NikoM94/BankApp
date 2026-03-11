using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApplication.Forms
{
    public partial class StartUpFM : Form
    {
        public StartUpFM()
        {
            InitializeComponent();
        }

        private void LoginBT_Click(object sender, EventArgs e)
        {
            LoginFM loginFm = new LoginFM();
            this.Hide();
            loginFm.Show();
        }

        private void RegisterBT_Click(object sender, EventArgs e)
        {
            RegisterFM registerFm = new RegisterFM();
            this.Hide();
            registerFm.Show();
        }

        private void RecoveryBT_Click(object sender, EventArgs e)
        {
        }
    }
}
