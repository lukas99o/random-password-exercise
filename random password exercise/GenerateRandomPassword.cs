using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random_password_exercise
{
    internal static class GenerateRandomPassword
    {
        private static int _passwordLength;
        private static string _numbers = "0123456789";
        private static string _alphabet = "abcdefghijklmnopqrstuvwxyz"
        private static string _specials = "!?#%&@";
        private static string _password;
        public static int PasswordLength { get; set; }
        public static bool ContainsNumbers { get; set; }
        public static bool SpecialCharacters { get; set; }
        public static string Password { get; set; }

        public static string GenerateRandomString(int passwordLength, )
        {
            _password += _alphabet;

            if (ContainsNumbers)
            {
                _password += _numbers;
            }

            if (SpecialCharacters)
            {
                _password += _specials;
            }

            if (ContainsNumbers && SpecialCharacters)
            {
                _password += _specials;
                _password += _numbers;
            }

            var passwordLength = new Random();
            passwordLength.Next(0, PasswordLength);

            return _password;
        }
    }
}
