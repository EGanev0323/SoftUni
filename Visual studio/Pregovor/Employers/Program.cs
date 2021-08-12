using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employers
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var brLine = int.Parse(Console.ReadLine());
            var listEmp = new List<Employee>();
            for (int i = 0; i < brLine; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                string name= cmdArgs[0] + " " + cmdArgs[1];

                Employee emp= new Employee(cmdArgs[0]+ " "+
                    cmdArgs[1],
                    int.Parse(cmdArgs[2]),
                    double.Parse(cmdArgs[3]));
                listEmp.Add(emp);
                
            }
            double bonus = double.Parse(Console.ReadLine());
            
            foreach (var item in listEmp)
            {
                item.IncreaseSalary(bonus);
            }
            foreach (var item in listEmp)
            {
                Console.WriteLine(item.ToString());
            }       

            //Employee emp1 = new Employee { Name = "Asen Ivanov", Age = 65, Salary = 2200 };
            //emp1.IncreaseSalary(20);            
            //Console.WriteLine(emp1.ToString());

        }
    }
}
