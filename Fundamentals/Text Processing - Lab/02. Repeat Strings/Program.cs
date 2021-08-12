using System;
using System.Linq;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            string newString = "";

            foreach (string word in words)
            {

                int repeatTimes = word.Length;

                for (int i = 0; i < repeatTimes; i++)
                {
                    newString += word;
                }
            }

            Console.WriteLine(newString);
        }
    }
}
