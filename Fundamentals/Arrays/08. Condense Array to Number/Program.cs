using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] condenced = new int[array.Length - 1];
            if (array.Length==1)
            {
                Console.WriteLine(array[0]);
                return;
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < condenced.Length - i; j++)
                {
                    condenced[j] = array[j] +   array[j + 1];
                }
                array = condenced;
            }
            Console.WriteLine(condenced[0]);
        }
    }
}
