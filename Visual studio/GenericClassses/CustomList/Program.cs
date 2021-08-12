using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> customList = new CustomList<int>();

            var cmd = Console.ReadLine().Split().ToArray();
            while (cmd[0] != "END")
            {
                switch (cmd[0])
                {
                    case "Add":customList.Add(int.Parse(cmd[1]));break;
                    case "Remove":
                        Console.WriteLine(customList.Remove(int.Parse(cmd[1])));
                        break;
                    case "Contains":
                        Console.WriteLine(customList.Contains(int.Parse(cmd[1])));
                        break;
                    case "Swap":
                        customList.Swap(int.Parse(cmd[1]), int.Parse(cmd[2]));
                        break;
                    case "Greater":
                        Console.WriteLine(customList.CounGreaterThan(int.Parse(cmd[1])));
                        break;
                    case "Sort":
                        Console.WriteLine(string.Join(" ", customList));
                        break;
                    case "Max":
                        Console.WriteLine(customList.Max());
                        break;
                    case "Min":
                        Console.WriteLine(customList.Min());
                        break;
                    case "Print":
                        customList.Print();
                        break;
                        
                }
                cmd = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
