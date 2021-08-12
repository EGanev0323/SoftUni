using System;
using System.Linq;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(GetMultipleOfEvenAndOdds(num));
        }

        static int GetSumOfEvenDigids(int num)
        {
            int evenSum = 0;
            while (num>0)
            {
                int nextNum = num % 10;
                num /= 10;
                if (nextNum%2==0)
                {
                    evenSum += nextNum;
                }
            }
            return evenSum;
        }
        static int GetSumOfOddDigits(int num)
        {
            int oddSum = 0;
            while (num > 0)
            {
                int nextNum = num % 10;
                num /= 10;
                if (nextNum % 2 != 0)
                {
                    oddSum += nextNum;
                }
            }
            return oddSum;
        }
        static int GetMultipleOfEvenAndOdds(int num) 
        {
            int result = GetSumOfEvenDigids(num) * GetSumOfOddDigits(num);
            return result;
        }
    }
}
