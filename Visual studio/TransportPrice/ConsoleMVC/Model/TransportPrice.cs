using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMVC.Model
{
    public class TransportPrice
    {
        const double taxiRateStart = 0.70;
        const double taxiRateNight = 0.90;
        const double taxiRateDay = 0.79;
        const double busRate = 0.09;
        const double trainRate = 0.06;

        private int distance;
        private string dayOrNight;

        public int Distance { get => distance; set => distance = value; }
        public string DayOrNight { get => dayOrNight; set => dayOrNight = value; }

        public TransportPrice(int distance, string dayOrNight)
        {
            Distance = distance;
            DayOrNight = dayOrNight;
        }
        public TransportPrice() : this(0, "") { }

        public double CalculateTransportPrice()
        {
            var taxiRate = taxiRateNight;
            if (dayOrNight == "day")
            {
                taxiRate = taxiRateDay;
            }
            if (distance < 20)
            {
                return taxiRateStart + distance * taxiRate;
            }
            else if (distance < 100)
            {
                return distance * busRate;
            }
            else
            {
                return distance * trainRate;
            }
        }
    }
}
