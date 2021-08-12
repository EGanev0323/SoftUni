using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {

                for (int j = i + 1; j < array.Length; j++)
                {

                    rightSum += array[j];
                }
                if (leftSum == rightSum)
                {
                    index = i;
                    break;
                }
                leftSum += array[i];
                rightSum = 0;
            }
            if (rightSum != leftSum)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine(index);
            }
        }

    }
}
