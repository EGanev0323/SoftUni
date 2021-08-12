using System;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                int people = int.Parse(Console.ReadLine());
                arr[i] += people;
            }
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine(arr.Sum());
        }
    }
}
