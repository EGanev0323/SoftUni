using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Dictionary<double, int> numbersDic = new Dictionary<double, int>();
            foreach (var item in numbers)
            {
                if (!numbersDic.ContainsKey(item))
                {
                    numbersDic.Add(item, 0);
                }
                numbersDic[item] += 1;
            }

            foreach (var item in numbersDic)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
