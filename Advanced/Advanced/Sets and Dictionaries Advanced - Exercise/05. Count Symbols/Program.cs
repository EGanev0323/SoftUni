using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> symbolCounter = new Dictionary<char, int>();
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {

                if (!symbolCounter.ContainsKey(text[i]))
                {
                    symbolCounter.Add(text[i], 0);

                }
                symbolCounter[text[i]]++;
            }

            foreach (var item in symbolCounter.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
