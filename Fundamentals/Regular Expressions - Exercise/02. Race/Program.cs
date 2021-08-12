using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> racers = new Dictionary<string, int>();
            string lettersPat = "[A-Za-z]";
            string digitsPat = "[0-9]";
            string[] names = Console.ReadLine().Split(", ");
            
            foreach (var item in names)
            {
                racers.Add(item, 0);
            }

            string input = Console.ReadLine();
            while (input!="end of race")
            {
                
                string currentName = "";
                int currentSum = 0;
                MatchCollection matchedNames = Regex.Matches(input, lettersPat);
                foreach (Match item in matchedNames)
                {
                    currentName += item;
                }

                if (!names.Contains(currentName))
                {
                    input =Console.ReadLine();
                    continue;
                }

                MatchCollection matchedDigits = Regex.Matches(input, digitsPat);
                foreach (Match item in matchedDigits)
                {
                    currentSum += int.Parse(item.Value);
                }

                racers[currentName] += currentSum;

                input =Console.ReadLine();
            }

            int counter = 1;
            foreach (var item in racers.OrderByDescending(x => x.Value))
            {
                if (counter == 1)
                {
                    Console.WriteLine($"1st place: {item.Key} ");
                }
                else if(counter == 2)
                {
                    Console.WriteLine($"2nd place: {item.Key} ");
                }
                else if (counter == 3)
                {
                    Console.WriteLine($"3rd place: {item.Key} ");
                }
                if (counter==3)
                {
                    break;
                }
                counter++;
            }
        }
    }
}
