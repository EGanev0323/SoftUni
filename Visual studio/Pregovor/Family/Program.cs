using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Person> family = new List<Person>
            //{
            //    new Person{FirstName="Gosho", SecondName="Ivanow", LastName="Pertow", Age=32 },
            //    new Person{FirstName="Pesho", SecondName="Goshow", LastName="Pertow", Age=13 },
            //    new Person{FirstName="Gergana", SecondName="Petrowa", LastName="Pertowa", Age=31 },
            //    new Person{FirstName="Dimitar", SecondName="Ivanow", LastName="Pertow", Age= 70},
            //    new Person{FirstName="Waska", SecondName="Dimitrowa", LastName="Pertowa", Age=68 }
            //};
            Person newPerson = new Person{FirstName = "Ivan", SecondName = "Dimov", LastName = "Ivanow", Age = 109};
            Person newPerson2 = new Person { FirstName = "Waska", SecondName = "Dimitrowa", LastName = "Pertowa", Age = 68 };
            Person newPerson3 = new Person();
            Console.Write("Enter name: ");
            newPerson3.FirstName = Console.ReadLine();
            Console.Write("Enter second name: ");
            newPerson3.SecondName = Console.ReadLine();
            Console.Write("Enter second last name: ");
            newPerson3.LastName = Console.ReadLine();
            Console.Write("Enter age:");
            newPerson3.Age = int.Parse(Console.ReadLine());
            newPerson.IntroduseYourself();
            newPerson2.IntroduseYourself();
            newPerson3.IntroduseYourself();
        }
    }
}
