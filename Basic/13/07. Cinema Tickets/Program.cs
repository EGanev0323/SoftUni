using System;

namespace _07._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string film = Console.ReadLine();
            int kids = 0;
            int student = 0;
            int standart = 0;
            while (film != "Finish")
            {
                int capacity = int.Parse(Console.ReadLine());
                int tickets = 0;
                string ticketType = Console.ReadLine();
                while (ticketType != "End")
                {
                    tickets++;
                    switch (ticketType)
                    {
                        case "student":
                            student++;
                            break;

                        case "kid":
                            kids++;
                            break;

                        case "standart":
                            standart++;
                            break;

                    }
                    if (tickets >= capacity)
                    {
                        break;
                    }
                    ticketType = Console.ReadLine();
                }

                Console.WriteLine($"{film} - {1.0 * tickets / capacity * 100:f2}% full.");
                film = Console.ReadLine();
            }
            int totalTickets = student + standart + kids;
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{1.0 * student / totalTickets * 100:f2}% student tickets.");
            Console.WriteLine($"{1.0 * standart / totalTickets * 100:f2}% standart tickets.");
            Console.WriteLine($"{1.0 * kids / totalTickets * 100:f2}% kids tickets.");
        }
    }
}
