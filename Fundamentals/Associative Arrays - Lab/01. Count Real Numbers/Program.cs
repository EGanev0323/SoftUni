using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            SortedDictionary<double, int> count = new SortedDictionary<double, int>();

            foreach (var item in numbers)
            {
                if (!count.ContainsKey(item))
                {
                    count.Add(item, 0);
                }
                count[item]++;

            }

            foreach (var item in count)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
