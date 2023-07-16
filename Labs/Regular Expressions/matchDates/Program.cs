using System;
using System.Text.RegularExpressions;

namespace matchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<Day>\d{2})(?<Separator>.|-|/)?(?<Month>[A-Z][a-z]{2})\<Separator>(?<Year>\d{4})";
            string input = Console.ReadLine();

            var dates = Regex.Matches(input, pattern);

            foreach (Match date in dates)
            {
                var day = date.Groups["Day"].Value;
                var month = date.Groups["Month"].Value;
                var year = date.Groups["Year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}