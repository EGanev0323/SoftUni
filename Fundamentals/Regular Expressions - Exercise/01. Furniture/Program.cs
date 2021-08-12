using System;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {

            var regex = @"^>>(?<name>[A-Za-z]+)<<(?<price>[0-9]+\.{0,1}[0-9]{0,})!(?<quantity>[0-9]+)";
            string input = Console.ReadLine();
            decimal totalPrice = 0;

            Console.WriteLine("Bought furniture: ");
            while (input != "Purchase")
            {
                Match match = Regex.Match(input, regex);
                if (!match.Success)
                {
                    input = Console.ReadLine();
                    continue;
                }

                string name = match.Groups["name"].Value;
                decimal price = decimal.Parse(match.Groups["price"].Value);
                int quantity = int.Parse(match.Groups["quantity"].Value);
                totalPrice += price * quantity;
                Console.WriteLine(name);
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total money spend: {totalPrice:f2}");

        }
    }
}
