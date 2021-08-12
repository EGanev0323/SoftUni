using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceForTrip = double.Parse(Console.ReadLine());
            double ownedMoney = double.Parse(Console.ReadLine());
            int daysCounter = 0;
            int spenddingCounter = 0;
            while ( ownedMoney<priceForTrip&&daysCounter<5)
            {
                string command =Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                daysCounter++;
            }
        }
    }
}
