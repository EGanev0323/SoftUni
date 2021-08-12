using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMVC.Views
{
    public class Display
    {
        public double PriceVegetables { get; set; }
        public double PriceFruits { get; set; }
        public int Kilogramvegetables { get; set; }
        public int KilogramFruits { get; set; }
        public double WholeAccountInEuros { get; set; }

        public Display()
        {
            PriceVegetables = 0.0;
            PriceFruits = 0.0;
            Kilogramvegetables = 0;
            KilogramFruits = 0;
            WholeAccountInEuros = 0.0;
            GetValuesFromKeyBoard();
        }
        private void GetValuesFromKeyBoard()
        {
            Console.Write("Въведете цената за килограм зеленчуци: ");
            PriceVegetables = double.Parse(Console.ReadLine());
            Console.Write("Въведете цената за килограм плодове: ");
            PriceFruits = double.Parse(Console.ReadLine());
            Console.Write("Въведете килограм на зеленчуци: ");
            Kilogramvegetables = int.Parse(Console.ReadLine());
            Console.Write("Въведете килограм на плодове:");
            KilogramFruits = int.Parse(Console.ReadLine());
        }

        public void ShowAllFruitsAndVegetablesInEuros()
        {
            Console.WriteLine( $"{WholeAccountInEuros:f2}");
        }
    }
}
