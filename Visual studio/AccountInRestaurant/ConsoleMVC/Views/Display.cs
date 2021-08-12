using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMVC.Views
{
    class Display
    {
        public double Percent { get; set; }
        public double Amount { get; set; }
        public double Total { get; set; }
        public double TipAmount { get; set; }

        public Display()
        {
            Percent = 0;
            Amount = 0;
            Total = 0;
            TipAmount = 0;
            GetValue();
        }

        private void GetValue()
        {
            Console.Write("Въведете стойността на сметката:");
            Amount = double.Parse(Console.ReadLine());
            Console.Write("Въведете процента на бакшиша, който ще дадете:");
            Percent=double.Parse(Console.ReadLine());
        }
        public void ShowTipAndTotal()
        {
            Console.Write($"Вашият бакшиш е на стойност: {TipAmount:f2} лв.");
            Console.Write($"Цялата сметка е:{Total:f2} лв.");
        }
    }
}
