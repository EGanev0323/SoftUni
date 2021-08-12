using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            switch (typeOfGroup)
            {
                case "Students":
                    if (day == "Friday")
                    {
                        price = 8.45;
                    }
                    else if (day == "Saturday")
                    {
                        price = 9.80;
                    }
                    else if (day == "Sunday")
                    {
                        price = 10.46;
                    }
                    break;
                case "Business":
                    if (day == "Friday")
                    {
                        price = 10.90;
                    }
                    else if (day == "Saturday")
                    {
                        price = 15.60;
                    }
                    else if (day == "Sunday")
                    {
                        price = 16;
                    }
                    break;
                case "Regular":
                    if (day == "Friday")
                    {
                        price = 15;
                    }
                    else if (day == "Saturday")
                    {
                        price = 20;
                    }
                    else if (day == "Sunday")
                    {
                        price = 22.50;
                    }
                    break;
            }

            double midSum = price * people;
            if (typeOfGroup == "Students" && people >= 30)
            {
                midSum *= 0.85; 
            }
            else if (typeOfGroup == "Business" && people >= 100)
            {
                midSum = (people - 10) * price;
            }
            else if (typeOfGroup == "Regular" && people >= 10 && people <= 20)
            {
                midSum *= 0.95;
            }

            Console.WriteLine($"Total price: {midSum:f2}");

        }
    }
}
