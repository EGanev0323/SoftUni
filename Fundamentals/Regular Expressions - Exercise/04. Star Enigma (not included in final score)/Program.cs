using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma__not_included_in_final_score_
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> planets = new Dictionary<string, List<string>>();
            planets.Add("Attacked", new List<string>());
            planets.Add("Destroyed", new List<string>());

            for (int i = 0; i < n; i++)
            {
                StringBuilder sb = new StringBuilder();
                string input = Console.ReadLine();
                string keyPat = "[starSTAR]";
                int count = Regex.Matches(input, keyPat).Count;
                foreach (var item in input)
                {
                    sb.Append((char)(item - count));
                }

                string regex = @"@(?<name>[A-Za-z]+)[^@\-!:>]*:(?<population>[0-9]+)[^@\-!:>]*(?<type>!A!|!D!)[^@\-!:>]*->(?<sodier>[0-9]+)+";
                Match planetMatch = Regex.Match(sb.ToString(), regex);
                if (!planetMatch.Success)
                {
                    continue;
                }

                string planetName = planetMatch.Groups["name"].Value;
                string type = planetMatch.Groups["type"].Value;

                if (type == "!D!")
                {
                    planets["Destroyed"].Add(planetName);
                }
                else if (type == "!A!")
                {
                    planets["Attacked"].Add(planetName);
                }
            }

            foreach (var item in planets)
            {
                Console.WriteLine($"{item.Key} planets: {item.Value.Count}");
                foreach (var planetName in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-> {planetName}");
                }
            }

            //int n = int.Parse(Console.ReadLine());
            //List<string> attacked = new List<string>();
            //List<string> destroyed = new List<string>();


            //for (int i = 0; i < n; i++)
            //{
            //    StringBuilder sb = new StringBuilder();
            //    string input = Console.ReadLine();
            //    string keyPat = "[starSTAR]";
            //    int count = Regex.Matches(input, keyPat).Count;
            //    foreach (var item in input)
            //    {
            //        sb.Append((char)(item - count));
            //    }

            //    string regex = @"@(?<name>[A-Za-z]+)[^@\-!:>]*:(?<population>[0-9]+)[^@\-!:>]*(?<type>!A!|!D!)[^@\-!:>]*->(?<sodier>[0-9]+)+";
            //    Match planetMatch = Regex.Match(sb.ToString(), regex);
            //    if (!planetMatch.Success)
            //    {
            //        continue;
            //    }

            //    string planetName = planetMatch.Groups["name"].Value;
            //    string type = planetMatch.Groups["type"].Value;

            //    if (type == "!D!")
            //    {
            //        destroyed.Add(planetName);
            //    }
            //    else if (type == "!A!")
            //    {
            //        attacked.Add(planetName);
            //    }
            //}

            //Console.WriteLine($"Attacked planets: {attacked.Count}");
            //foreach (var item in attacked.OrderBy(x => x))
            //{
            //    Console.WriteLine($"-> {item}");
            //}

            //Console.WriteLine($"Destroyed planets: {destroyed.Count}");
            //foreach (var item in destroyed.OrderBy(x => x))
            //{
            //    Console.WriteLine($"-> {item}");
            //}
        }
    }
}
