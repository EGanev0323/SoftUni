using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayString = ArrayCreator.Create(3, "Pesho");    
            Console.WriteLine(string.Join(" ",arrayString));

            int []arrayInt = ArrayCreator.Create(4,56 );
            Console.WriteLine(string.Join(" ",arrayInt));

            double[] arrayDouble = ArrayCreator.Create(4, 6.54);
            Console.WriteLine(string.Join(" ",arrayDouble));
        }
    }
}
