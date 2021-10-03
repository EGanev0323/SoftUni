using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string[,] matrix = new string[cordinates[0], cordinates[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] chars = Console.ReadLine().Split();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = chars[col];
                }
            }

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] splitted = command.Split();
                string cmd = splitted[0];
                

                if (cmd != "swap" || int.Parse(splitted[1]) > cordinates[0] || int.Parse(splitted[2]) > cordinates[1] || int.Parse(splitted[3]) > cordinates[0] || int.Parse(splitted[4]) > cordinates[1] || splitted.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    int row1 = int.Parse(splitted[1]);
                    int col1 = int.Parse(splitted[2]);
                    int row2 = int.Parse(splitted[3]);
                    int col2 = int.Parse(splitted[4]);

                    string firstCordinate = matrix[row1, col1];
                    string secondCordinate = matrix[row2, col2];
                    matrix[row2, col2] = firstCordinate;
                    matrix[row1, col1] = secondCordinate;

                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            Console.Write(matrix[row, col] + " ");
                        }
                        Console.WriteLine();
                    }

                }

                command = Console.ReadLine();
            }
        }
    }
}
