using System;

namespace _04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = start; i <= stop; i++)
            {
                for (int j = start; j <= stop; j++)
                {
                    counter++;
                    if (i + j == magicNum)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = { magicNum})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
        }
    }
}
