using System;
using System.Text.RegularExpressions;

namespace AccountLibrary
{
    public class AccountId
    {
        private string value;
        private const int FIXED_LENGTH = 10;
        private const string PATTERN = @"^[a-zA-Z0-9]*$";
        private const string ALPHABET_PATTERN = @"[a-zA-Z]";
        private const string NUMBER_PATTERN = @"[0-9]";

        public AccountId(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(value);
            }

            if (value.Length != FIXED_LENGTH)
            {
                throw new ArgumentOutOfRangeException(value);
            }

            var regex = new Regex(PATTERN);
            if (!regex.IsMatch(value))
            {
                throw new ArgumentException(value);
            }

            var alphabetRegex = new Regex(ALPHABET_PATTERN);
            if (!alphabetRegex.IsMatch(value))
            {
                throw new ArgumentException(value);
            }

            var numberRegex = new Regex(NUMBER_PATTERN);
            if (!numberRegex.IsMatch(value))
            {
                throw new ArgumentException(value);
            }

            this.value = value;
        }

        public string Value => value;
    }
}
