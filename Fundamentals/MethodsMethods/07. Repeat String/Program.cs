using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(StringRepeater(input,n));
        }
        private static string StringRepeater(string input, int n)
        {
            string result = "";
            for (int i = 0; i < n; i++)
            {
                result += input;
            }
            return result;
        }
    }
}
