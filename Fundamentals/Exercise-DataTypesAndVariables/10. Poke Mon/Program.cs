using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int originalN = n;
            int targets = 0;
            while (n >= m)
            {
                n -= m;
                if (n*2==originalN&&y>0)
                {
                    n /= y;
                }
                targets++;
            }

            Console.WriteLine(n);
            Console.WriteLine(targets);
        }
    }
}
