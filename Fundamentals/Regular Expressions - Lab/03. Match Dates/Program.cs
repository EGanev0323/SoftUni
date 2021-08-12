using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"(?<day>[0-9]{2})(?<separator>.)(?<month>[A-Z][a-z]{2})+\k<separator>(?<year>[0-9]{4})";
            var input =Console.ReadLine();
            MatchCollection matchedDates = Regex.Matches(input, regex);

            foreach (Match item in matchedDates)
            {
                var day = item.Groups["day"].Value;
                var month = item.Groups["month"].Value;
                var year = item.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
