using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nSX = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nSX[0];
            int s = nSX[1];
            int x = nSX[2];

            Queue<int> nums = new Queue<int>(n);
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                nums.Enqueue(numbers[i]);
            }

            for (int i = 0; i < s; i++)
            {
                nums.Dequeue();
            }
            int minNum = int.MaxValue;
            foreach (var item in nums)
            {
                if (item < minNum)
                {
                    minNum = item;
                }
            }

            if (nums.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                if (nums.Contains(x))
                {
                    Console.WriteLine("true");
                }
                else
                {

                    Console.WriteLine(minNum);
                }
            }
        }
    }
}
