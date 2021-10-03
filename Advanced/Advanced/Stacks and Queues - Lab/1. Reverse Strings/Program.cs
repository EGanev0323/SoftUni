using System;
using System.Collections.Generic;

namespace _1._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> reversedChars = new Stack<char>();
            string input = Console.ReadLine();
            foreach (char item in input)
            {
                reversedChars.Push(item);

            }
            while (reversedChars.Count > 0)
            {
                Console.Write(reversedChars.Pop());
            }
        }
    }
}
