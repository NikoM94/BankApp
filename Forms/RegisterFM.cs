using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankApplication.Utils;
using BCrypt.Net;
using BankApplication.Models;
using BankApplication.Repositories;

namespace BankApplication.Forms
{
    public partial class RegisterFM : Form
    {
        private bool IsValidFirstName = false;
        private bool IsValidLastName = false;
        private bool IsValidAddress = false;
        private bool IsValidZipCode = false;
        private bool IsValidCity = false;
        private bool IsValidUsername = false;
        private bool IsValidPassword = false;
        private bool IsValidPhone = false;
        private bool IsValidEmail = false;
        private InputValidator _validator;
        private readonly CustomerRepository _repository;

        public RegisterFM()
        {
            _repository = new CustomerRepository(new Data.DataBaseConnection());
            _validator = new InputValidator();
            InitializeComponent();
        }

        private void firstNameTB_TextChanged(object sender, EventArgs e)
        {
            bool isValidFirstName = _validator.ValidateName(firstNameTB.Text);
            firstNameCheckPL.BackColor = isValidFirstName ? Color.Green : Color.Red;
            this.IsValidFirstName = isValidFirstName;
            CheckFormValidity();
        }

        private void lastNameTB_TextChanged(object sender, EventArgs e)
        {
            bool isValidLastName = _validator.ValidateName(lastNameTB.Text);
            lastNameCheckPL.BackColor = isValidLastName ? Color.Green : Color.Red;
            this.IsValidLastName = isValidLastName;
            CheckFormValidity();
        }

        private void addressTB_TextChanged(object sender, EventArgs e)
        {
            bool isValidAddress = _validator.ValidateAddress(addressTB.Text);
            addressCheckPL.BackColor = isValidAddress ? Color.Green : Color.Red;
            this.IsValidAddress = isValidAddress;
            CheckFormValidity();
        }

        private void zipCodeTB_TextChanged(object sender, EventArgs e)
        {
            bool isValidZipCode = _validator.ValidateZipCode(zipCodeTB.Text);
            zipCodeCheckPL.BackColor = isValidZipCode ? Color.Green : Color.Red;
            this.IsValidZipCode = isValidZipCode;
            CheckFormValidity();
        }

        private void cityTB_TextChanged(object sender, EventArgs e)
        {
            bool isValidCity = _validator.ValidateCity(cityTB.Text);
            cityCheckPL.BackColor = isValidCity ? Color.Green : Color.Red;
            this.IsValidCity = isValidCity;
            CheckFormValidity();
        }

        private void usernameTB_TextChanged(object sender, EventArgs e)
        {
            bool isValidUsername = _validator.ValidateUsername(usernameTB.Text);
            userNameCheckPL.BackColor = isValidUsername ? Color.Green : Color.Red;
            this.IsValidUsername = isValidUsername;
            CheckFormValidity();
        }

        private void passwordTB_TextChanged(object sender, EventArgs e)
        {
            bool isValidPassword = _validator.ValidatePassword(passwordTB.Text);
            passwordCheckPL.BackColor = isValidPassword ? Color.Green : Color.Red;
            this.IsValidPassword = isValidPassword;
            CheckFormValidity();
        }

        private void phoneTB_TextChanged(object sender, EventArgs e)
        {
            bool isValidPhone = _validator.ValidatePhone(phoneTB.Text);
            phoneCheckPL.BackColor = isValidPhone ? Color.Green : Color.Red;
            this.IsValidPhone = isValidPhone;
            CheckFormValidity();
        }

        private void emailTB_TextChanged(object sender, EventArgs e)
        {
            bool isValidEmail = _validator.ValidateEmail(emailTB.Text);
            emailCheckPL.BackColor = isValidEmail ? Color.Green : Color.Red;
            this.IsValidEmail = isValidEmail;
            CheckFormValidity();
        }
        private void CheckFormValidity()
        {
            RegisterUserBT.Enabled = IsValidFirstName && IsValidLastName && IsValidAddress &&
                                     IsValidZipCode && IsValidCity && IsValidUsername &&
                                     IsValidPassword && IsValidPhone && IsValidEmail;
        }

        private void RegisterUserBT_Click(object sender, EventArgs e)
        {
            string password = passwordTB.Text;
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
            Customer toAdd = new Customer(firstNameTB.Text, lastNameTB.Text, addressTB.Text, cityTB.Text, zipCodeTB.Text, emailTB.Text, phoneTB.Text, usernameTB.Text, passwordHash);
            _repository.Add(toAdd);
        }
    }
}
