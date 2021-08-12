using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];
            for (int i = 0; i < n; i++)
            {

                int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int firstNum = array[0];
                int secondNum = array[1];
                if (i % 2 == 0)
                {
                    arr1[i] = firstNum;
                    arr2[i] = secondNum;
                }
                else
                {
                    arr1[i] = secondNum;
                    arr2[i] = firstNum;
                }

            }

            Console.WriteLine(string.Join(" ", arr1));
            Console.WriteLine(string.Join(" ", arr2));
        }
    }
}
