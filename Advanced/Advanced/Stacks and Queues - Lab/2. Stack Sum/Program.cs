using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            Stack<int> intigersStack = new Stack<int>(nums);
            string command =Console.ReadLine().ToLower();
            while (command!="end")
            {
                string[] splitted = command.Split();
                string cmd = splitted[0];
                if (cmd=="add")
                {
                    int firstNum = int.Parse(splitted[1]);
                    int secondNum = int.Parse(splitted[2]);
                    intigersStack.Push(firstNum);
                    intigersStack.Push(secondNum);

                }
                else if (cmd=="remove")
                {
                    int countOfNums = int.Parse(splitted[1]);
                    if (countOfNums<=intigersStack.Count)
                    {
                        for (int i = 0; i < countOfNums; i++)
                        {
                            intigersStack.Pop();
                        }
                    }
                    
                }
                 command = Console.ReadLine().ToLower();
            }

            int sum = 0;
            foreach (var item in intigersStack)
            {
                sum += item;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
