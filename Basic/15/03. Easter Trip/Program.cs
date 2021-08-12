using System;

namespace _03._Easter_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string date = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            int pricePerNight = 0;
            switch (destination)
            {
                case "France":
                    if (date == "21-23")
                    {
                        pricePerNight = 30;
                    }
                    else if (date == "24-27")
                    {
                        pricePerNight = 35;
                    }
                    else if (date == "28-31")
                    {
                        pricePerNight = 40;
                    }
                    break;

                case "Italy":
                    if (date == "21-23")
                    {
                        pricePerNight = 28;
                    }
                    else if (date == "24-27")
                    {
                        pricePerNight = 32;
                    }
                    else if (date == "28-31")
                    {
                        pricePerNight = 39;
                    }
                    break;

                case "Germany":
                    if (date == "21-23")
                    {
                        pricePerNight = 32;
                    }
                    else if (date == "24-27")
                    {
                        pricePerNight = 37;
                    }
                    else if (date == "28-31")
                    {
                        pricePerNight = 43;
                    }
                    break;
            }
            double totalPrice = pricePerNight * nights;
            Console.WriteLine($"Easter trip to {destination} : {totalPrice:f2} leva.");

        }
    }
}
