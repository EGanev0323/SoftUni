using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            for (int i = 0; i < nums.Length; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                nums[i] = numbers;
            }
            for (int j = nums.Length - 1; j >= 0; j--)
            {
                Console.Write($"{nums[j]} ");
            }
        }
    }
}
