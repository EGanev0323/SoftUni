using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();
            Dictionary<char, int> count = new Dictionary<char, int>();

            for (int i = 0; i < words.Length; i++)
            {

                if (!count.ContainsKey(words[i])&&words[i]!=' ')
                {
                    count.Add(words[i], 0);
                }
                if (words[i]!=' ')
                {
                    count[words[i]]++;
                }
                
            }
            foreach (var item in count)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
