using System;
using System.Collections.Generic;

namespace _06._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> plates = new HashSet<string>();
            string input = Console.ReadLine();
            while (input!="END")
            {
                string[] splitted = input.Split(", ");
                string command = splitted[0];
                string carPlate = splitted[1];
                if (command=="IN")
                {
                    plates.Add(carPlate);
                }
                else if (command=="OUT")
                {
                    plates.Remove(carPlate);
                }
                input =Console.ReadLine();
            }

            if (plates.Count>0)
            {
                Console.WriteLine(string.Join("\n",plates));
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
