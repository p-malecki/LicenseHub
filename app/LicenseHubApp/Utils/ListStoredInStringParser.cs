using System.Text;

namespace LicenseHubApp.Utils
{
    public static class ListStoredInStringParser
    {
        private const char Separator = '#';

        public static string ParseSingleLineToMultiline(string singleLineInput)
        {
            var sb = new StringBuilder(singleLineInput);
            sb.Replace(Separator.ToString(), Environment.NewLine);

            var multilineLineOutput = sb.ToString();
            return multilineLineOutput;
        }

        public static string ParseMultilineToSingleLine(string multilineInput)
        {
            var lines = multilineInput.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            var singleLineOutput = string.Join(Separator, lines);
            return singleLineOutput;
        }

        public static List<string> ParseSingleLineToList(string singleLineInput)
        {
            var listOutput = singleLineInput.Split(Separator).ToList();
            return listOutput;
        }

        public static string ParseListToSingleLine(List<string> listInput)
        {
            var sb = new StringBuilder();
            var singleLineOutput = sb.AppendJoin(Separator, listInput).ToString();
            return singleLineOutput;
        }
    }
}
