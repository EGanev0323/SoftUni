using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Input(arr, n);
            Output(arr, n);
            //SelectSort(arr);
            BubbleSort(arr);
            Console.WriteLine();
            Output(arr, n);
        }
        static void Input(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Въведи елемент:");
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

        static void Swap<T>(T[] arr, int from, int to)
        {
            T temp = arr[from];
            arr[from] = arr[to];
            arr[to] = temp;
        }

        static bool Less(IComparable first, IComparable second)
        {
            return first.CompareTo(second) < 0;
        }

        static void BubbleSort(int[] arr)
        {
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (Less(arr[i + 1], arr[i])) //(arr[i] > arr[i + 1])
                    {
                        //temp = arr[i + 1];
                        //arr[i + 1] = arr[i];
                        //arr[i] = temp;
                        Swap(arr, i + 1, i);
                    }
                }
            }
        }
    }
}
