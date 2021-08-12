using System;

namespace _06._Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int cookers = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffels = int.Parse(Console.ReadLine());
            int pancaces = int.Parse(Console.ReadLine());

            double cakesPrice = cakes * 45;
            double waffelsPrice = waffels * 5.80;
            double pancacesPrice = pancaces * 3.20;

            double sumForDay = (cakesPrice + waffelsPrice
                + pancacesPrice) * cookers;
            double fullCampainSum = sumForDay * days;
            double TotalPrice = fullCampainSum- fullCampainSum / 8;

            Console.WriteLine(TotalPrice);

        }
    }
}
