using System;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banWords = Console.ReadLine().Split(", ");
            string text =Console.ReadLine();
            foreach (var item in banWords)
            {
                if (text.Contains(item))
                {
                     text = text.Replace(item, new string('*', item.Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}
