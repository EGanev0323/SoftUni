using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses
{
    public class SquareRootPrecalculator
    {
        public const int MaxValue = 1000;
        private static double[] sqrtValues;
        //static field
        static SquareRootPrecalculator()
        {
            sqrtValues = new double[MaxValue + 1];
            for (int i = 1; i <=MaxValue; i++)
            {
                sqrtValues[i] = Math.Sqrt(i);
            }
            
        }
        public static double GetSqrt(int value)
        {
            return sqrtValues[value];
        }
    }
}
