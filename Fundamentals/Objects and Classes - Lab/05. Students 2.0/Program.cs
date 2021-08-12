using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Students_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> stu = new List<Student>();

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] tokens = input.Split();

                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string town = tokens[3];

                Student student = stu.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);
                if (student==null)
                {
                    stu.Add(new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        Hometown = town
                    });
                }
                else
                {
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.Hometown = town;
                }
                

                

                input = Console.ReadLine();
            }

            string searchedTown = Console.ReadLine();
            List<Student> filteredStudents = stu.Where(x => x.Hometown == searchedTown).ToList();
            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Hometown { get; set; }
    }

}
