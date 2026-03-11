using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BankApplication.Utils
{
    public class InputValidator
    {
        private const string NameRegex = @"^[a-zA-ZåäöÅÄÖ]{1,25}$";
        private const string AddressRegex = @"^[a-zA-ZäöåÄÖÅ0-9\s,\.]{5,100}$";
        private const string CityRegex = @"^[a-zA-ZåäöÅÄÖ\s]{2,25}$";
        private const string ZipCodeRegex = @"^\d{5}$";
        private const string UsernameRegex = @"^[a-zA-Z0-9åäöÅÄÖ]{3,25}$";
        private const string PasswordRegex = @"^.{12,25}$";
        private const string EmailRegex = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        private const string PhoneRegex = @"^\+?[0-9]{7,15}$";

        public InputValidator() 
        {
        }

        public bool ValidateName(string name) => Regex.IsMatch(name, NameRegex);
        public bool ValidateAddress(string address) => Regex.IsMatch(address, AddressRegex);

        public bool ValidateZipCode(string zipCode) => Regex.IsMatch(zipCode, ZipCodeRegex);

        public bool ValidateCity(string city) => Regex.IsMatch(city, CityRegex);

        public bool ValidateUsername(string username) => Regex.IsMatch(username, UsernameRegex);

        public bool ValidatePassword(string password) => Regex.IsMatch(password, PasswordRegex);

        public bool ValidatePhone(string phone) => Regex.IsMatch(phone, PhoneRegex);

        public bool ValidateEmail(string email) => Regex.IsMatch(email, EmailRegex, RegexOptions.IgnoreCase);
    }
}
