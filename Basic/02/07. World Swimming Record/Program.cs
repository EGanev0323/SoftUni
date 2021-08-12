using System;
using System.Xml.Schema;

namespace _07._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double secondForMeter = double.Parse(Console.ReadLine());
            double time = meters * secondForMeter;
            double slowAdd = Math.Floor(meters / 15) * 12.5;
            double totalTime = time + slowAdd;

            if (totalTime >= record)
            {
                double slowerTime = totalTime - record;
                Console.WriteLine($"No, he failed! He was {slowerTime:f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
        }
    }
}