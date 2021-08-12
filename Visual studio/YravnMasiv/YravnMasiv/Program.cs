using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YravnMasiv
{
    class Program
    {
        static void Main(string[] args)
        {
            // масив от н бр цели числа
            // първата половина на масива се сортира възходящо
            //стора половина низходящо

            int[] arr = new int[] { 4, 2, 6, 3, 8, 1, 7, 4, 2, 9 };
            int n = arr.Length;
            BubbleSortAscending(arr, 0, n/2 );
            BubbleSortDescending(arr, n/2, n);
            //for (int j = 0; j <= n/2- 2; j++)
            //{
            //    for (int i = 0; i <=n/2 - 2; i++)
            //    {
            //        if (arr[i] > arr[i + 1])
            //        {
            //           temp = arr[i + 1];
            //            arr[i + 1] = arr[i];
            //            arr[i] = temp;
            //        }
            //    }
            //}
            //for (int j = n / 2; j <= arr.Length - 2; j++)
            //{
            //    for (int i = n / 2; i <= arr.Length - 2; i++)
            //    {
            //        if (arr[i + 1] > arr[i])
            //        {
            //            temp = arr[i + 1];
            //            arr[i + 1] = arr[i];
            //            arr[i] = temp;
            //        }
            //    }
            //}
            foreach (var item in arr)
            {
                Console.Write($"{item }, ");
            }
            Console.WriteLine();
        }
        static void BubbleSortAscending(int[] arr, int start, int end)
        {
            int temp = 0;
            for (int j = start; j < end; j++)
            {
                for (int i = start; i <end; i++)
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

            static void BubbleSortDescending(int[] arr, int start, int end)
            {
            int temp = 0;
                for (int j = start; j < end ; j++)
                {
                    for (int i = start; i < end-1; i++)
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
