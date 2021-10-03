using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> studentGrades = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] names = Console.ReadLine().Split();
                if (!studentGrades.ContainsKey(names[0]))
                {
                    studentGrades.Add(names[0], new List<decimal>());
                }

                studentGrades[names[0]].Add(decimal.Parse(names[1]));
            }

           

            foreach (var item in studentGrades)
            {
                decimal average = item.Value.Average();
                Console.WriteLine($"{item.Key} -> {string.Join(" ", item.Value.Select(g=>g.ToString("F2")))} (avg: {item.Value.Average():f2})");
            }
        }
    }
}
