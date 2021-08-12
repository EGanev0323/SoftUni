﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                string name =Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(name))
                {
                    students.Add(name, new List<double>());

                }
                students[name].Add(grade);

            }

            foreach (var item in students.OrderByDescending(x=>x.Value.Average()))
            {
                double averageGrade = item.Value.Average();
                if (averageGrade>=4.50)
                {
                    Console.WriteLine($"{item.Key} -> {averageGrade:f2}");
                }
                
            }
        }
    }
}
