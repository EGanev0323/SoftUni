using System;
using System.Text;

namespace _01._Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass =Console.ReadLine();
            string[] input = Console.ReadLine().Split();
           
            while (input[0]!="Done")
            {
                switch (input[0])
                {
                    case "TakeOdd":
                        StringBuilder sb = new StringBuilder();
                        for (int i = 1; i < pass.Length; i+=2)
                        {
                             sb.Append(pass[i]);
                        }
                        pass = sb.ToString();
                        Console.WriteLine(pass);
                        break;
                    case "Cut":
                        pass = pass.Remove(int.Parse(input[1]), int.Parse(input[2]));
                        Console.WriteLine(pass);
                        break;
                    case "Substitute":
                        if (pass.Contains(input[1]))
                        {
                            pass = pass.Replace(input[1], input[2]);
                            Console.WriteLine(pass);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }
                        break;
                }
                input = Console.ReadLine().Split();
            }
            Console.WriteLine($"Your password is: {pass}");
        }
    }
}
