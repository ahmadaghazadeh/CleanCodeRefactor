using AhmadAghazadeh.Shop.CustomerContext.Domain.Customers.Exceptions;
using System.Text.RegularExpressions;

namespace Refactor
{
    public class User
    {
        public string UserName { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public string Password { get; private set; }
        public User(UserDto userDto)
        {
            SetUserName(userDto.UserName);
            SetFirstName(userDto.FirstName);
            SeLastName(userDto.LastName);
            SetPassword(userDto.Password);
        }

        private void SetUserName(string userName)
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
                throw new UserNameRequiredException();
            }
            UserName = userName;           
        }

        private void SetFirstName(string firstName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new FirstNameRequiredException();
            }
            FirstName = firstName;
        }

        private void SeLastName(string lastName)
        {
            if (string.IsNullOrWhiteSpace(lastName))
            {
                throw new LastNameRequiredException();
            }
            LastName = lastName;
        }

        private void SetPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new PasswordRequiredException();
            }

            if (password.Length < 8)
            {
                throw new PasswordLengthLessThanEightException();
            }

            if (!Regex.IsMatch(password, @"^(?=.*[@$!%#])[A-Za-z\d@$!%#]{8,}$"))
            {
                throw new PasswordInvalidFormatException();
            }

            Password = password;
        }
    }
}

