﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();
            for (int i = 0; i < nums.Count / 2; i++)
            {
                int left = nums[i];
                int right= nums[nums.Count - 1 - i];
                int sum = left + right;
                result.Add(sum);

            }
            if (nums.Count%2==1)
            {
                int element = nums[nums.Count / 2];
                result.Add(element);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
