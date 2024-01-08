using System.Text.RegularExpressions;
using static LicenseHubApp.Utils.ListStoredInStringParser;

namespace LicenseHubApp.Utils
{
    public static class DataValidator
    {
        public static bool IsNipValid(string nip)
        {
            if (nip == "0")
                return true;

            if (nip.Length != 10 || nip.Any(chr => !Char.IsDigit(chr)))
                return false;

            int[] weights = [6, 5, 7, 2, 3, 4, 5, 6, 7, 0];
            var sum = nip.Zip(weights, (digit, weight) => (digit - '0') * weight).Sum();

            return (sum % 11) == (nip[9] - '0');
        }

        public static bool ArePhoneNumbersValid(string phoneNumbers)
        {
            var listOfPhoneNumbers = ParseSingleLineToList(phoneNumbers);
            const string pattern = @"^\+?(48)? ?\d{9}$";

            return listOfPhoneNumbers.All(phoneNumber => Regex.IsMatch(phoneNumber, pattern));
        }

        public static bool AreEmailsValid(string emails)
        {
            var listOfEmails = ParseSingleLineToList(emails);
            const string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            return listOfEmails.All(emailAddress => Regex.IsMatch(emailAddress, pattern));

        }
    }
}
