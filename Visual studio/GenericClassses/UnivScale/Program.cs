using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnivScale
{
    class Program
    {
        static void Main(string[] args)
        {
            Scale<int> intscale = new Scale<int>(5, 6);
            Console.WriteLine(  intscale.GetHeavier());

            Scale<double> doublescale = new Scale<double>(5.3, 5.4);
            Console.WriteLine(doublescale.GetHeavier());

            Scale<string> stringscale = new Scale<string>("sdaas", "sda" +
                "s");
            Console.WriteLine(stringscale.GetHeavier());
        }
    }
}
