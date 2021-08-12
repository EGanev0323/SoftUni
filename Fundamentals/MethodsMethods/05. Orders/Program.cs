using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            TotalSum(input, quantity);
        }

        private static void TotalSum(string input, int quantity)
        {
            //if (input == "coffee")
            //{
            //    Console.WriteLine($"{1.50 * quantity:f2}");
            //}
            //else if (input == "coke")
            //{
            //    Console.WriteLine($"{1.40 * quantity:f2}");
            //}
            //else if (input == "water")
            //{
            //    Console.WriteLine($"{1.00 * quantity:f2}");
            //}
            //else if (input == "snack")
            //{
            //    Console.WriteLine($"{2.00 * quantity:f2}");
            //}
            switch (input)
            {
                case "coffee":
                    Console.WriteLine($"{quantity*1.50:f2}");
                    break;
                case "coke":
                    Console.WriteLine($"{quantity * 1.40:f2}");
                    break;
                case "water":
                    Console.WriteLine($"{quantity * 1.00:f2}");
                    break;
                case "snack":
                    Console.WriteLine($"{quantity * 2.00:f2}");
                    break;
                default:
                    break;
            }
        }
    }
}
