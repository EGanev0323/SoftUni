using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int maxElement = 0;
            int currentElements = 1;
            int element = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i]==array[j])
                    {
                        currentElements++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (currentElements>maxElement)
                {
                    maxElement = currentElements;
                    element = array[i];
                }
                currentElements=1;
            }

            for (int i = 0; i < maxElement; i++)
            {
                Console.Write($"{element} ");
            }
        }
    }
}
