
using System;

namespace _01._Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputString = Console.ReadLine().Split();
            Action<string[]> print = input => Console.WriteLine(string.Join("\n",input));
            print(inputString);
        }
    }
}
