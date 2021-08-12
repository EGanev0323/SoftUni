using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split().Reverse().ToArray();
            for (int i = 0; i < elements.Length; i++)
            {
                Console.Write($"{elements[i]} ");
            }
        }
    }
}
