using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Mirror_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(@(?<firstWord>[A-Za-z]{3,})@{2}(?<secondWord>[A-Za-z]{3,})@)|(#(?<firstWord>[A-Za-z]{3,})#{2}(?<secondWord>[A-Za-z]{3,})#)";
            string input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input, pattern);
            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }

            List<string> mirror = new List<string>();
            foreach (Match item in matches)
            {
                string firstWord = item.Groups["firstWord"].Value;
                string secondWord = item.Groups["secondWord"].Value;
                string reversed = string.Empty;
                for (int i = secondWord.Length - 1; i > -1; i--)
                {
                    reversed += secondWord[i];
                }

                if (reversed == firstWord)
                {
                    mirror.Add($"{firstWord} <=> {secondWord}");
                }
            }
            if (mirror.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine($"The mirror words are:");

                Console.WriteLine(string.Join(", ", mirror));


            }

        }
    }
}
