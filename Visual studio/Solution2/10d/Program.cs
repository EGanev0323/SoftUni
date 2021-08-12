using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10d
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> Class = new List<Person>
            {
                new Person{FirstName="Aleksandur", LastName="Stoew", Number=1, Grade=4.50},
                new Person{FirstName="Andi", LastName="Radew", Number=1, Grade=6},
                new Person{FirstName="Atanas", LastName="Stoew", Number=1, Grade=5.64},
                new Person{FirstName="Valentin", LastName="Kaaminow", Number=1, Grade=5.49},
                new Person{FirstName="Vasil", LastName="Babow", Number=1, Grade=3.50},
                new Person{FirstName="Dobromir", LastName="Blagow", Number=1, Grade=5.98},
                new Person{FirstName="Emil", LastName="Ganev", Number=1, Grade=5.99},
                new Person{FirstName="Ivan", LastName="Panaiotow", Number=1, Grade=4.52},
                new Person{FirstName="Konstantin ", LastName="Konstantinow", Number=1, Grade=2.99},
                new Person{FirstName="Mariela", LastName="Dimitrowa", Number=1, Grade=5.70},
                new Person{FirstName="Mariqn", LastName="Starbew", Number=1, Grade=4.60},
                new Person{FirstName="Mihaela", LastName="Kobakowa", Number=1, Grade=5.80},
                new Person{FirstName="Nikolai", LastName="Bojilow", Number=1, Grade=5.97},
                new Person{FirstName="Raian", LastName="Aleksiew", Number=1, Grade=4.99},
                new Person{FirstName="Hristo", LastName="Grablew", Number=1, Grade=4.20}

            };

          
            foreach (var person in Class)
            {
                person.Print();
            }
        }
    }
}
