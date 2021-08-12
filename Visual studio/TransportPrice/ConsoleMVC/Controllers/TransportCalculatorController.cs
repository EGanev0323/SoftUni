using ConsoleMVC.Model;
using ConsoleMVC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMVC.Controllers
{
    public class TransportCalculatorController
    {
        private TransportPrice transportPrice;
        private Display display;

        public TransportCalculatorController()
        {
            display = new Display();
            transportPrice = new TransportPrice(display.Distance, display.DayOrNight);
            display.TransportPrice = transportPrice.CalculateTransportPrice();
            display.ShowTransportPrice();
        }
    }
}
