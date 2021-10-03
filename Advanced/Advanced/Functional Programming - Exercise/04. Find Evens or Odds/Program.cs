using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isEven = num => num % 2 == 0;
            Action<int[]> print = num =>Console.WriteLine(string.Join(" ",num));
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> numbers = Enumerable.Range(nums[0], nums[1]-nums[0]+1).ToList();
            string oddOrEven =Console.ReadLine();
            if (oddOrEven=="even")
            {
                print(numbers.FindAll(isEven).ToArray());
            }
            else
            {
                print(numbers.FindAll(x => !isEven(x)).ToArray());
            }
            
        }
    }
}
