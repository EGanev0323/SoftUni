using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                int theNum = i;
                int sum = 0;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }

                bool isSpecial = false;
                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", theNum, isSpecial);
                sum = 0;
                i = theNum;
            }

        }
    }
}
