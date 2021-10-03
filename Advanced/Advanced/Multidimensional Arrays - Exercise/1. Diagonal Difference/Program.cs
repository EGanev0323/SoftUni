
using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = nums[j];
                }

            }

            int upDiagonalSum = 0;
            int downDiagonalSum = 0;

            for (int i = 0; i < n; i++)
            {
                upDiagonalSum += matrix[i, i];
            }
            int counter = 0;

            for (int row = n - 1; row >= 0; row--)
            {
                downDiagonalSum += matrix[row, counter];
                counter++;
            }

            Console.WriteLine(Math.Abs(upDiagonalSum - downDiagonalSum));
        }
    }
}
