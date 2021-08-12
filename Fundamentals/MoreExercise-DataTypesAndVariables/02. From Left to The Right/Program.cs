using System;

namespace _02._From_Left_to_The_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                int rightNum = int.Parse(Console.ReadLine());
                int sum = 0;
                if (num > rightNum)
                {
                    while (num > 0)
                    {
                        sum += num % 10;
                        num /= 10;
                    }
                    Console.WriteLine(sum);
                }
                else
                {
                    while(rightNum>0)
                    {
                        sum += rightNum % 10;
                        rightNum /= 10;
                    }
                    Console.WriteLine(sum);
                }
            }
        }
    }
}
