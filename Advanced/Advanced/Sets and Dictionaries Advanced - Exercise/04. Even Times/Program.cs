using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> numbers = new Dictionary<int, int>();


            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(num))
                {
                    numbers.Add(num, 0);

                }
                numbers[num]++;
            }


            Console.WriteLine(numbers.OrderByDescending(x => x.Value).Where( x=>x.Value % 2 == 0).First().Key);
        }
    }
}
