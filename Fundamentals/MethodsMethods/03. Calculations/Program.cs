using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (input == "add")
            {
                Add(a, b);
            }
            else if (input == "multiply")
            {
                Multiply(a, b);
            }
            else if (input == "subtract")
            {
                Subtract(a, b);
            }
            else if (input == "divide")
            {
                Divide(a, b);
            }
        }
        public static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public static void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public static void Divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }


    }
}
