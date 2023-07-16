using System;
using System.Text.RegularExpressions;

namespace matchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"( |\+359)( |-)?2\2\d{3}\2\d{4}\b";
            string input = Console.ReadLine();
            RegexOptions options = RegexOptions.Multiline;

            string result = "";
            foreach (Match m in Regex.Matches(input, pattern, options))
            {
                result += m.Value + ", ";
            }
            int indexToRemove = result.LastIndexOf(", ");
            result = result.Remove(indexToRemove);
            Console.WriteLine(result);
        }
    }
}