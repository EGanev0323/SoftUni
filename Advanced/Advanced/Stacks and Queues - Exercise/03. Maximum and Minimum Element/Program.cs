using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();
            
            for (int i = 0; i < n; i++)
            {
                int[] command = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int cmd = command[0];
                if (cmd==1)
                {
                    int x = command[1];
                    numbers.Push(x);
                }
                else if (cmd==2)
                {
                    if (numbers.Count==0)
                    {
                        continue;
                    }
                    else
                    {
                        numbers.Pop();
                    }
                }
                else if (cmd==3)
                {
                    int maxNum = 0;

                    if (numbers.Count == 0)
                    {
                        continue;
                    }
                    else
                    {
                        foreach (var item in numbers)
                        {
                            if (item > maxNum)
                            {
                                maxNum = item;
                            }

                        }

                        Console.WriteLine(maxNum);
                    }
                    
                }
                else if (cmd==4)
                {
                    int minNum = int.MaxValue;
                    if (numbers.Count == 0)
                    {
                        continue;
                    }
                    else
                    {
                        foreach (var item in numbers)
                        {
                            if (item < minNum)
                            {
                                minNum = item;
                            }

                        }

                        Console.WriteLine(minNum);
                    }
                     
                }

            }

            Console.WriteLine(string.Join(", ", numbers));  
        }
    }
}
