using System;
using System.Collections.Generic;

namespace _07._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vip = new HashSet<string>();
            HashSet<string> normal = new HashSet<string>();

            string input = Console.ReadLine();
            while (input!="PARTY")
            {
                if ( char.IsDigit(input[0]))
                {
                    vip.Add(input);
                }
                else
                {
                    normal.Add(input);
                }
                input =Console.ReadLine();
            }

            string onParty =Console.ReadLine();
            while (onParty!="END")
            {
                if (vip.Contains(onParty))
                {
                    vip.Remove(onParty);
                }
                else
                {
                    normal.Remove(onParty);
                }
                onParty =Console.ReadLine();
            }

            int count = vip.Count + normal.Count;
            Console.WriteLine(count);
            if (vip.Count>0)
            {
                Console.WriteLine(string.Join("\n", vip));
            }
            if (normal.Count>0)
            {
                Console.WriteLine(string.Join("\n", normal));
            }
            
        }
    }
}
