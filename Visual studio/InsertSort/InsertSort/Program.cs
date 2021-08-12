using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 23, 9, 85, 12, 99, 34, 60, 15, 100, 1 };
            int n = 10, i, j;
            Console.WriteLine("Insertion Sort");
            Console.Write("Initial array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            InsertSortAscending(arr, 0, n / 2);
            InsertSortDescending(arr, n / 2, n);
            //for (i = 1; i < n; i++)
            //{
            //    val = arr[i];
            //    flag = 0;
            //    for (j = i - 1; j >= 0 && flag != 1;)
            //    {
            //        if (val > arr[j])
            //        {
            //            arr[j + 1] = arr[j];
            //            j--;
            //            arr[j + 1] = val;
            //        }
            //        else flag = 1;
            //    }
            //}
            Console.Write("\nSorted Array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }

        }
        static void InsertSortAscending(int[]arr, int start, int end)
        {
            int temp = 0;
            for (int j = start; j < end; j++)
            {
                for (int i = start; i < end; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
        }
        static void InsertSortDescending(int[] arr, int start, int end)
        {
            int temp = 0;
            for (int j = start; j < end; j++)
            {
                for (int i = start; i < end - 1; i++)
                {
                    if (arr[i + 1] > arr[i])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
        }
    }
}
