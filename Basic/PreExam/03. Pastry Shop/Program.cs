using System;

namespace _03._Pastry_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string sweets = Console.ReadLine();
            int sweetsCount = int.Parse(Console.ReadLine());
            int date = int.Parse(Console.ReadLine());
            double sum = 0;
            switch (sweets)
            {
                case "Cake":
                    if (date <= 15)
                    {
                        sum += 24;
                    }
                    else if (date > 15)
                    {
                        sum += 28.70;
                    }
                    break;
                case "Souffle":
                    if (date <= 15)
                    {
                        sum += 6.66;
                    }
                    else if (date > 15)
                    {
                        sum += 9.80;
                    }
                    break;
                case "Baklava":
                    if (date <= 15)
                    {
                        sum += 12.60;
                    }
                    else if (date > 15)
                    {
                        sum += 16.98;
                    }
                    break;
            }
            double totalSum = sweetsCount * sum;
            double sumWithDiscount = 0;
            if (date <= 22)
            {
                if (totalSum >= 100 && totalSum <= 200)
                {
                    totalSum = totalSum - totalSum * 0.15;
                }
                else if (totalSum > 200)
                {
                    totalSum = totalSum - totalSum * 0.25;
                }

                if (date <= 15)
                {
                    sumWithDiscount = totalSum - totalSum * 0.1;
                }
                else
                {
                    sumWithDiscount += totalSum;
                }
                Console.WriteLine($"{sumWithDiscount:f2}");
            }
            else
            {
                Console.WriteLine($"{totalSum:f2}");
            }

        }
    }
}
