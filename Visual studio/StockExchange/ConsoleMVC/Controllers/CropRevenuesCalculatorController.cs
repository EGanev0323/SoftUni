using ConsoleMVC.Model;
using ConsoleMVC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMVC.Controllers
{
    public class CropRevenuesCalculatorController
    {
        private StockExchange stockExchange;
        private Display display;

        public CropRevenuesCalculatorController()
        {
            display = new Display();
            stockExchange = new StockExchange(display.PriceVegetables, display.PriceFruits, display.Kilogramvegetables, display.KilogramFruits);
            display.WholeAccountInEuros = stockExchange.CalculateAccountInEuro();
            display.ShowAllFruitsAndVegetablesInEuros();
        }
    }
}
