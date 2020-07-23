using System;
using System.Text.RegularExpressions;

namespace AccountLibrary
{
    public class AccountPassword
    {
        private const int MINI_LENGTH = 8;
        private const string PATTERN = @"^[0-9a-zA-Z]*$";
        private const string NUMBER_PATTERN = @"[0-9]";
        private const string HALF_ALPHABET_PATTERN = @"[a-z]";
        private const string FULL_ALPHABET_PATTERN = @"[A-Z]";
        private readonly string value;

        public AccountPassword(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException(value);
            }

            if (value.Length < MINI_LENGTH)
            {
                throw new ArgumentException(value);
            }

            if (!Regex.IsMatch(value, PATTERN))
            {
                throw new ArgumentException(value);
            }

            if (!Regex.IsMatch(value, NUMBER_PATTERN))
            {
                throw new ArgumentException(value);
            }

            if (!Regex.IsMatch(value, HALF_ALPHABET_PATTERN))
            {
                throw new ArgumentException(value);
            }

            if (!Regex.IsMatch(value, FULL_ALPHABET_PATTERN))
            {
                throw new ArgumentException(value);
            }

            this.value = value;
        }

        public string Value => value;
    }
}
