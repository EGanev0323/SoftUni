using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int numA = int.Parse(Console.ReadLine());
            string mathOperation=Console.ReadLine();
            int numB = int.Parse(Console.ReadLine());
            Console.WriteLine($"{Calculate(numA,mathOperation,numB)}");
        }
        private static double Calculate(int numA, string mathOperationn, int numB)
        {
            double result = 0;
            switch (mathOperationn)
            {
                case "/":
                    result = numA / numB;
                    break;
                case "*":
                    result = numA * numB;
                    break;
                case "+":
                    result = numA + numB;
                    break;
                case "-":
                    result = numA - numB;
                    break;
            }
            return result;
        }
    }
}
