using System;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([:*])\1(?<emoji>[A-Z][a-z]{2,})\1{2}";
            string text = Console.ReadLine();
            long threshhold = 1;


            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsDigit(text[i]))
                {
                    threshhold *= text[i] - 48;
                }

            }

            Console.WriteLine($"Cool threshold: {threshhold}");
            MatchCollection matches = Regex.Matches(text, pattern);
            Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");
            foreach (Match item in matches)
            {
                int coolness = 0;
                string emoji = item.Groups["emoji"].Value;
                for (int i = 0; i < emoji.Length; i++)
                {
                    coolness += emoji[i];
                }

                if (coolness>=threshhold)
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}
