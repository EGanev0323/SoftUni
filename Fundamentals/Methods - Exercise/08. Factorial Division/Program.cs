using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            long factorialA = Factorial(a);
            long factorialB = Factorial(b);
            double result = (double)factorialA / factorialB;
            Console.WriteLine($"{result:f2}");

        }
        public static long Factorial(int x)
        {
            long result = 1;
            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
