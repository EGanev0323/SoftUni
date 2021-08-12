using System;

namespace _04._Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string unitNum = Console.ReadLine();
            string unitOut =Console.ReadLine();

            if (unitNum == "mm" && unitOut == "m")
            {
                num = num / 1000;
            }
            else if (unitNum == "m" && unitOut == "cm")
            {
                num = num * 100;
            }
            else if (unitNum == "cm" && unitOut == "mm")
            {
                num = num * 10;
            }
            else if (unitNum=="mm"&&unitOut=="cm")
            {
                num = num / 10;
            }
            else if (unitNum=="cm"&&unitOut=="m")
            {
                num = num / 100;
            }
            else if (unitNum == "m" && unitOut == "mm")
            {
                num = num * 1000;
            }

            Console.WriteLine($"{num:f3}");
        }
    }
}
