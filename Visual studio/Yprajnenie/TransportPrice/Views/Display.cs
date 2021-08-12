using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrice.Views
{
     public class Display
    {
        public int Distance { get; set; }
        public string DayOrNight { get; set; }
        public double TransportPrice { get; set; }

        public Display()
        {
            Distance = 0;
            DayOrNight = "";
            TransportPrice = 0;
            GetValues();
        }
        private void GetValues()
        {
            Console.Write("Въведете растояние: ");
            Distance = int.Parse(Console.ReadLine());
            Console.Write("Въведете  day or night:");
            DayOrNight = Console.ReadLine();
        }
        public void ShowTransportPrice()
        {
            Console.WriteLine($"Цената на транспорта е {TransportPrice} ");
        }
    }
}
