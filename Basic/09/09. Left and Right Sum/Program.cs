using System;

namespace _09._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumLeft = 0;
            int sumRight = 0;
            for (int i = 0; i < n; i++)
            {
                int numLeft = int.Parse(Console.ReadLine());
                sumLeft += numLeft;
            }
            for (int i = 0; i < n; i++)
            {
                int numright = int.Parse(Console.ReadLine());
                sumRight += numright;
            }
            if (sumLeft==sumRight)
            {
                Console.WriteLine($"Yes, sum = {sumLeft}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sumRight-sumLeft)}");
            }
        }
    }
}
