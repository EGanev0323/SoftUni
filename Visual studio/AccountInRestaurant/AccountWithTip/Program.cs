using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountWithTip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете стойността на сметката: ");
            double amount = double.Parse(Console.ReadLine());
            Console.Write("Въведете процента на бакшиша:");
            double percentageTip = double.Parse(Console.ReadLine());

            if (percentageTip>1)
            {
                percentageTip /= 100;
            }

            double tip = amount * percentageTip;
            double total = amount + tip;
            Console.WriteLine($"Стойността на бакшиша е:{tip:f2}");
            Console.WriteLine($"Крайната цена е:{total:f2}");
        }
    }
}
