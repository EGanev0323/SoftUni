using System;

namespace _06._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double sSquare = a * a;
                Console.WriteLine($"{sSquare:f3}");
            }
            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double sRectangle = a * b;
                Console.WriteLine($"{sRectangle:f3}");
            }
            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double sCircle = Math.PI *r*r;
                Console.WriteLine($"{sCircle:f3}");
            }
            else if (figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double ha = double.Parse(Console.ReadLine());
                double sTriangle = (a * ha) / 2;
                Console.WriteLine($"{sTriangle:f3}");
            }
        }
    }
}
