using System;
using System.Linq;

namespace _01._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();
            Random rnd = new Random();
            for (int i = 0; i < words.Length-1; i++)
            {
               int pos= rnd.Next(words.Length);
                string temp = words[i];
                words[i]= words[pos];
                words[pos] = temp;
            }
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
