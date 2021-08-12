using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> result = new List<int>();
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] > 0)
                {
                    result.Add(nums[i]);
                }
            }
            result.Reverse();
            if (result.Count > 1)
            {
                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
