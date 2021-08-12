using System;

namespace _03._Energy_Booster
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int setCount = int.Parse(Console.ReadLine());
            double totalSum = 0;
            if (size == "small")
            {
                if (fruit == "Watermelon")
                {
                    double midSum = 2 * 54;
                    totalSum = midSum * setCount;
                }
                else if (fruit == "Mango")
                {
                    double midSum = 2 * 36.66;
                    totalSum = midSum * setCount;
                }
                else if (fruit == "Pineapple")
                {
                    double midSum = 2 * 42.10;
                    totalSum = midSum * setCount;
                }
                else
                {
                    double midSum = 2 * 20;
                    totalSum = midSum * setCount;
                }
            }
            else
            {
                if (fruit == "Watermelon")
                {
                    double midSum = 5 * 28.70;
                    totalSum = midSum * setCount;
                }
                else if (fruit == "Mango")
                {
                    double midSum = 5 * 19.60;
                    totalSum = midSum * setCount;
                }
                else if (fruit == "Pineapple")
                {
                    double midSum = 5 * 24.80;
                    totalSum = midSum * setCount;
                }
                else
                {
                    double midSum = 5 * 15.20;
                    totalSum = midSum * setCount;
                }
            }
            double sumWithPers = 0;
            if (totalSum >= 400 && totalSum <= 1000)
            {
                sumWithPers = totalSum - totalSum * 0.15;
            }
            else if (totalSum > 1000)
            {
                sumWithPers = totalSum - totalSum * 0.5;
            }
            else
            {
                sumWithPers = totalSum;
            }
            Console.WriteLine($"{sumWithPers:f2} lv.");
        }
    }
}
