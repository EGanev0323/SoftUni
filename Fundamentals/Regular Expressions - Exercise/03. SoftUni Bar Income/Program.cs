using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"%(?<name>[A-Z][a-z]+)%[^|$%.0-9]*<(?<product>[A-Za-z]+)>[^|$%.0-9]*\|(?<count>[0-9])\|[^|$%.0-9]*(?<price>[0-9]+\.[0-9])\$";
            //string regex = @"^%(?<name>[A-Z][a-z]+)%[^|$%.0-9]*?<(?<product>\w+)>[^|$%.0-9]*?\|(?<count>\d+)\|[^|$%.0-9]*?(?<price>[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?)\$";
            string input =Console.ReadLine();
            double income = 0;
            while (input != "end of shift")
            {
                double midSum = 0;
              Match match = Regex.Match(input, regex);
                if (!match.Success)
                {
                    input = Console.ReadLine();
                    continue;

                }

                string name = match.Groups["name"].Value;
                string product = match.Groups["product"].Value;
                int count = int.Parse(match.Groups["count"].Value);
                double price = double.Parse(match.Groups["price"].Value);

                midSum = count * price;

                Console.WriteLine($"{name}: {product} - {midSum:f2}");
                income += midSum;

                input =Console.ReadLine();

            }

            Console.WriteLine($"Total income: {income:f2}");
        }
    }
}
