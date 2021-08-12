using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double numPower = double.Parse(Console.ReadLine());
            Console.WriteLine(NumPower(num,numPower));
        }
        public static double NumPower(double num, double numPower)
        {
            return Math.Pow(num, numPower);
        }
    }
}
