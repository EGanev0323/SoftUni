using System;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> synonimDict = new Dictionary<string, List<string>>();
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonim = Console.ReadLine();
                if (!synonimDict.ContainsKey(word))
                {
                    synonimDict.Add(word, new List<string>());
                }

                synonimDict[word].Add(synonim);
            }
            foreach (var item in synonimDict)
            {
                Console.WriteLine($"{item.Key} - {String.Join(", ",item.Value)}");
            }

        }
    }
}
