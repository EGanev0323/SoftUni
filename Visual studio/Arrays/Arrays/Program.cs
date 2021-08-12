using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Input(arr, n);
            Output(arr, n);
            SelectSort(arr);
            Console.WriteLine();
            Output(arr, n);
            Console.WriteLine();
            Console.WriteLine($"Sum= {Sum(arr)}");
            
        }
        static void Input(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element: ");
                arr[i] = int.Parse(Console.ReadLine());
               
            }
        }
        static void Output(int[] arr, int n)
        {
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
            int smallest;
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

                Swap(ref arr[smallest], ref arr[i]);
            }
        }
        static int Sum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

            }
            return sum;
        }


    }
}
