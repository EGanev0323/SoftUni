using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    public class Dice
    {
        public int sides;
        private Random rnd = new Random();

        public int Roll()
        {
            int rollResult = rnd.Next(6);
            return rollResult;
        }
    }
}
