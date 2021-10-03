using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] size = Console.ReadLine().Split(", ");
            int row = int.Parse(size[0]);
            int col = int.Parse(size[1]);

            int[,] matrix = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < elements.Length; j++)
                {
                    matrix[i, j] = elements[j];
                }
            }

            
            
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                int sum = 0;
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    sum += matrix[j, i];
                }
                Console.WriteLine(sum);
            }

        }
    }
}
