using System;

namespace _08._Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averageSuccess = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());

            double socialScholarship = Math.Floor(minSalary * 0.35);
            double excelentScholarship = Math.Floor(averageSuccess * 25);

            if (income < minSalary && averageSuccess >= 4.50)
            {
                Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
            }

            else if (averageSuccess >= 5.50)
            {
                Console.WriteLine($"You get a scholarship for excellent results {excelentScholarship} BGN");
            }

            else if (income > minSalary && averageSuccess < 5.50)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }

            else if (income < minSalary  && averageSuccess >= 5.50)
            {
                if (socialScholarship > excelentScholarship)
                {
                    Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
                }

                else if (excelentScholarship > socialScholarship)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {excelentScholarship} BGN");
                }

                else if (socialScholarship == excelentScholarship)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {excelentScholarship} BGN");
                }
            }
        }

    }
}

//double income = double.Parse(Console.ReadLine());
//double averageGrade = double.Parse(Console.ReadLine());
//double minSalary = double.Parse(Console.ReadLine());

//double socialScholarShip = Math.Floor(minSalary * 0.35);
//double exselentScholarship = Math.Floor(averageGrade * 25);

//if (income > minSalary && averageGrade < 5.50)
//{
//    Console.WriteLine("You cannot get a scholarship!");
//}
//else if (income < minSalary && averageGrade >= 5.50)
//{
//    if (socialScholarShip > exselentScholarship)
//    {
//        Console.WriteLine($"You get a Social scholarship {socialScholarShip} BGN");
//    }
//    else if (exselentScholarship > socialScholarShip)
//    {
//        Console.WriteLine($"You get a scholarship for excellent results { exselentScholarship} BGN ");
//    }
//    else if (exselentScholarship == socialScholarShip)
//    {
//        Console.WriteLine($"You get a scholarship for excellent results { exselentScholarship} BGN ");
//    }
//}
//else if (averageGrade >= 5.50)
//{
//    Console.WriteLine($"You get a scholarship for excellent results { exselentScholarship} BGN ");
//}
//else if (income < minSalary && averageGrade >= 4.50)
//{
//    Console.WriteLine($"You get a Social scholarship {socialScholarShip} BGN");
//}