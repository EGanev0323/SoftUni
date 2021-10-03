using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] matrix = new int[rows][];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
                matrix[i] = new int[nums.Length];
                for (int j = 0; j < nums.Length; j++)
                {
                    matrix[i][j] = nums[j];
                }
            }

            string command = Console.ReadLine();

            while (command != "END")
            {

                
                string[] splitted = command.Split();
                string cmd = splitted[0];
                int row = int.Parse(splitted[1]);
                int col = int.Parse(splitted[2]);
                int value = int.Parse(splitted[3]);
                if (row < 0 || row >= matrix.Length || col < 0 || col >= matrix[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    command = Console.ReadLine();
                    continue;
                }
                
                if (cmd == "Add")
                {
                    matrix[row][col] += value;
                }
                else if (cmd == "Subtract")
                {
                    matrix[row][col] -= value;
                }
                command = Console.ReadLine();
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i]));
            }
        }
    }
}
