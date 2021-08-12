using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([=\/])(?<name>[A-Z][A-Za-z]{2,})\1";
            string input =Console.ReadLine();
            MatchCollection matchedItems = Regex.Matches(input, pattern);
            int points = 0;
            for (int i = 0; i < matchedItems.Count; i++)
            {
                points += matchedItems[i].Length-2;
            }

            Console.Write("Destinations: ");
            List<string> names = new List<string>();
            foreach (Match item in matchedItems)
            {
                string name = item.Groups["name"].Value;
                names.Add(name);
            }
            Console.WriteLine(string.Join(", ",names));
            Console.WriteLine($"Travel Points: {points}");
            
        }
    }
}
