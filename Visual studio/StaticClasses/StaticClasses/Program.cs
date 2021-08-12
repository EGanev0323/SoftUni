using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a, b;
            //Console.Write("Enter a= ");
            //a = int.Parse(Console.ReadLine());
            //Console.Write("Enter b= ");
            //b = int.Parse(Console.ReadLine());

            //Console.WriteLine(Aritmetics.Add(a,b));
            //Console.WriteLine(Aritmetics.Multiply(a, b));

            int value = int.Parse(Console.ReadLine());
            Console.WriteLine(SquareRootPrecalculator.GetSqrt(value));

        }
    }
}
