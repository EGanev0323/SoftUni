using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int[], int> minValue = num =>
            {
                int min = int.MaxValue;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (num[i] < min)
                    {
                        min = num[i];
                    }

                }

                return min;
            };

            Console.WriteLine(minValue(nums));
        }
    }
}
