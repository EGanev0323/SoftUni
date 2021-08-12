using System;

namespace _7.TheatrePromotions
{
    class Program
    {
        static void Main(string[] args)
        {
            string day =Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());
            double sum = 0;
            switch (day)
            {
                case"weekday":
                    if (age>=0&&age<=18)
                    {
                        sum = 12;
                    }
                    else if (age>18&&age<=64)
                    {
                        sum = 18;
                    }
                    else if (age > 64 && age <= 122)
                    {
                        sum = 12;
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                        return;
                    }
                   
                    break;
                case "weekend":
                    if (age >= 0 && age <= 18)
                    {
                        sum = 15;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        sum = 20;
                    }
                    else if (age > 64 && age <= 122)
                    {
                        sum = 15;
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                        return;
                    }
                    break;
                case "holiday":
                    if (age >= 0 && age <= 18)
                    {
                        sum = 5;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        sum = 12;
                    }
                    else if (age > 64 && age <= 122)
                    {
                        sum = 10;
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                        return;
                    }
                    break;
            }

            Console.WriteLine($"{sum}$");

        }
    }
}
