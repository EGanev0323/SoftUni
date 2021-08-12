using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> clas = new List<Student>
            {
                new Student{FirstName="Gosho",  LastName="Pertow", Grade=5.45},
                new Student{FirstName="Pesho", LastName="Pertow", Grade=6.00 },
                new Student{FirstName="Gergana",  LastName="Pertowa", Grade=3.20 },
                new Student{FirstName="Dimitar", LastName="Pertow", Grade= 4.23},
                new Student{FirstName="Ivan", LastName="Ivanov", Grade=6.00 },
                new Student{FirstName="Petur", LastName="Georgoew", Grade=5.20 },
                new Student{FirstName="Emil", LastName="Ganev", Grade=4.00 }
            };
          

            foreach (var person in clas)
            {
                person.PrintStudent();
            }
            double result = clas.Average(g => g.Grade);
                Console.WriteLine($"Average grade is:{result:f2}");
            
        }
    }
}
