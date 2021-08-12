using System;

namespace _05._Christmas_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int adultCount = 0;
            int kidsCount = 0;

            while (input != "Christmas")
            {
                int age = int.Parse(input);
                if (age <= 16)
                {
                    kidsCount++;
                }
                else if (age > 16)
                {
                    adultCount++;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Number of adults: {adultCount}");
            Console.WriteLine($"Number of kids: {kidsCount}");
            Console.WriteLine($"Money for toys: {kidsCount * 5}");
            Console.WriteLine($"Money for sweaters: {adultCount * 15}");
        }
    }
}
