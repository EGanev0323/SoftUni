using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nSX = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nSX[0];
            int s = nSX[1];
            int x = nSX[2];

            Stack<int> nums = new Stack<int>(n);
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                nums.Push(numbers[i]);
            }
            
            for (int i = 0; i < s; i++)
            {
                nums.Pop();
            }
            int minNum = int.MaxValue;
            foreach (var item in nums)
            {
                if (item<minNum)
                {
                    minNum = item;
                }
            }

            if (nums.Count==0)
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
