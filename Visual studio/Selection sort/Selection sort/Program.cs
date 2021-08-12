using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 56, 1, 99, 67, 89, 23, 44, 12, 78, 34 };
            int n = arr.Length;

            Console.WriteLine("Selection sort");
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
            // Console.Write("Initial array is: ");
            SelectSort(arr);
            Console.WriteLine();
            Console.Write("Sorted array is: ");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
        }
        static void Swap(ref int first, ref int second)
        {

            int temp = first;
            first = second;
            second = temp;
        }

        static bool Less(int first, int second)
        {
            bool OK = false;
            if (first < second)
            {
                OK = true;
            }
            return OK;
        }

        static void SelectSort(int[] arr)
        {
            int n = arr.Length;
            int  smallest;
            for (int i = 0; i < n - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (Less(arr[j], arr[smallest]) == true)
                    {
                        smallest = j;
                    }

                }

                Swap( ref arr[smallest], ref arr[i]);
            }
        }
    }
}
    

