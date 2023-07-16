using System;
using System.Text.RegularExpressions;

namespace matchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string input = Console.ReadLine();
            RegexOptions options = RegexOptions.Multiline;

            string result = "";
            foreach (Match m in Regex.Matches(input, pattern, options))
            {
                result += m.Value + " ";
            }

            Console.WriteLine(result.Trim());
        }
    }
}