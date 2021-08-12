using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMVC.Model
{
    public class StockExchange
    {
        const double EURO_LEV = 1.94;

        private double priceVegetables;
        private double priceFruits;
        private int kilogramsVegetables;
        private int killogramsFruits;

        public double PriceVegetables { get; set; }
        public double PriceFruits { get; set; }
        public int KilogramsVegetables { get; set; }
        public int KillogramsFruits { get; set; }
    
        public StockExchange(double priceVegetables, double priceFruits, int kilogramsVegetables, int kilogramFruits)
        {
            this.PriceVegetables = priceVegetables;
            this.PriceFruits = priceFruits;
            this.KilogramsVegetables = kilogramsVegetables;
            this.KillogramsFruits = kilogramFruits;
        }
        public StockExchange() : this(0.0, 0.0, 0, 0)
        { }
        public double CalculateAccountInEuro()
        {
            return (PriceVegetables * KilogramsVegetables + PriceFruits * KillogramsFruits) / EURO_LEV;
        }
    }
}
