using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Matrix(n);
        }
        public static void Matrix(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(n+" ");
                for (int j = 1; j < n; j++)
                {
                    Console.Write(n+" ");
                }
                Console.WriteLine();
            }
        }

    }
}
