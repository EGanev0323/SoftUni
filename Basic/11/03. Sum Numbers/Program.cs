using System;

namespace _03._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumNumber = int.Parse(Console.ReadLine());
            //int number = int.Parse(Console.ReadLine());
            int sum = 0;
            while (sum <sumNumber)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;
            } 
                Console.WriteLine(sum);
        }
    }
}
