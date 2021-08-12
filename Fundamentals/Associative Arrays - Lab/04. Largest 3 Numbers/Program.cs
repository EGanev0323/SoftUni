using System;
using System.Linq;

namespace _04._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] sortedNums = nums.OrderByDescending(n => n).ToArray();

            if (sortedNums.Length<3)
            {
                foreach (var item in sortedNums)
                {
                    Console.Write($"{item} ");
                }
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(sortedNums[i] + " ");
                }
            }
            
        }
    }
}
