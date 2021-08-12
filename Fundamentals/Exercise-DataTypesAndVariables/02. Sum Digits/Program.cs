using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            int sum = 0;
            while (inputNum>0)
            {
                sum+=inputNum % 10;
                inputNum /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
