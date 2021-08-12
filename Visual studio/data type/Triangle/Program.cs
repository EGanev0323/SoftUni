using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //вх.-а, б-цели
            //изход-периметър, лице, диагонал
            //на правоъгълник
            Console.Write("Въъведи а: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Въведи б: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Периметър= {2*a+2*b}");
            Console.WriteLine($"Лице= {a*b}");
            Console.WriteLine($"c={Math.Sqrt(a*a+b*b):f2}");
        }
    }
}
