using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int row = size[0];
            int col = size[1];
            int[,] numbers = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                int[] nums = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < col; j++)
                {
                    numbers[i, j] = nums[j];
                }
            }

            int maxSum = 0;
            int startRow = 0;
            int startCol = 0;
            for (int i = 0; i < numbers.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < numbers.GetLength(1) - 2; j++)
                {
                    int currentSum = numbers[i, j] + numbers[i, j + 1] + numbers[i, j + 2] +
                        numbers[i + 1, j] + numbers[i + 1, j + 1] + numbers[i + 1, j + 2] +
                        numbers[i + 2, j] + numbers[i + 2, j + 1] + numbers[i + 2, j + 2];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        startRow = i;
                        startCol = j;

                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            for (int i = startRow; i <= startRow+2; i++)
            {
                for (int j = startCol; j <= startCol+2; j++)
                {
                    Console.Write($"{numbers[i,j]} ");
                }
                Console.WriteLine();
            }
           
        }

    }
}
