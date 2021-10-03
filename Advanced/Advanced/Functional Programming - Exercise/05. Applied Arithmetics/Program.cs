using System;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int[]> add = num =>
            {
                for (int i = 0; i < num.Length; i++)
                {
                    num[i] += 1;
                }
                return num;
            };
            Action<int[]> multiply = num =>
            {
                for (int i = 0; i < num.Length; i++)
                {
                    num[i] *= 2;
                }

            };
            Action<int[]> subtract = num =>
            {
                for (int i = 0; i < num.Length; i++)
                {
                    num[i] -= 1;
                }

            };
            Action<int[]> print = num => Console.WriteLine(string.Join(" ", num));

            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            while (command != "end")
            {
                if (command == "add")
                {
                    add(nums);
                }
                else if (command == "multiply")
                {
                    multiply(nums);
                }
                else if (command == "subtract")
                {
                    subtract(nums);
                }

                command = Console.ReadLine();
            }

            print(nums);
        }
    }
}
