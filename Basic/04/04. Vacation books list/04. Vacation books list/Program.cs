using System;

namespace _04._Vacation_books_list
{
    class Program
    {
        static void Main(string[] args)
        {
            int bookPages = int.Parse(Console.ReadLine());
            double pages = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            double TotalRead = bookPages / pages;
            double hoursPerDay = TotalRead / days;
            Console.WriteLine(hoursPerDay);
        }
    }
}
