using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employers
{
    public class Employee
    {
        private string name;
        private int age;
        private double salary;

        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public Employee() { }

        public Employee(string name, int age, double salary)
        {
            this.Name = name;            
            this.Age = age;
            this.Salary = salary;
        }
        public void IncreaseSalary(double bonus)
        {
            if (Age < 30)
            {
                this.Salary += this.salary * bonus / 200;
            }
            else
            {
                this.Salary += this.Salary * bonus / 100;
            }
        }
        public override string ToString()
        {
            string output = Name + " get " + Salary + " leva.";
            return output;
        }
        
    }
}
