using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 8; i <= n; i++)
            {
                if (IsDevisableBy8(i) && ContainsOddNum(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool ContainsOddNum(int num)
        {
            while (num > 0)
            {
                int currentDigit = num % 10;
                if (currentDigit % 2 == 1)
                {
                    return true;
                }
                num /= 10;
            }
            return false;
        }

        private static bool IsDevisableBy8(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            bool isDevisible = sum % 8 == 0;
            return isDevisible;
        }
    }
}
