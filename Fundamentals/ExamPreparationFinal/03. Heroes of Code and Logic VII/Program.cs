using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> heroesHP = new Dictionary<string, int>();
            Dictionary<string, int> heroesMP = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                heroesHP.Add(input[0], int.Parse(input[1]));
                heroesMP.Add(input[0], int.Parse(input[2]));

            }

            string[] command = Console.ReadLine().Split(" - ");

            while (command[0] != "End")
            {
                string commandName = command[0];
                string heroName = command[1];
                switch (commandName)
                {

                    case "CastSpell":
                        int mp = int.Parse(command[2]);
                        if (mp < heroesMP[heroName])
                        {
                            heroesMP[heroName] -= mp;
                            Console.WriteLine($"{heroName} has successfully cast {command[3]} and now has {heroesMP[heroName]} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} does not have enough MP to cast {command[3]}!");
                        }
                        break;
                    case "TakeDamage":
                        int damage = int.Parse(command[2]);
                        string attacker = command[3];


                        if (heroesHP[heroName] <= damage)
                        {
                            heroesHP[heroName] = 0;
                            Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        }
                        else
                        {
                            heroesHP[heroName] -= damage;
                            Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroesHP[heroName]} HP left!");
                        }
                        break;
                    case "Recharge":
                        int mPAmount = int.Parse(command[2]);


                        if (heroesMP[heroName] + mPAmount > 200)
                        {

                            Console.WriteLine($"{heroName} recharged for {200 - heroesMP[heroName]} MP!");
                            heroesMP[heroName] = 200;
                        }
                        else
                        {
                            heroesMP[heroName] += mPAmount;
                            Console.WriteLine($"{heroName} recharged for {mPAmount} MP!");
                        }

                        break;
                    case "Heal":
                        int hPAmount = int.Parse(command[2]);

                        if (heroesHP[heroName] + hPAmount > 100)
                        {

                            Console.WriteLine($"{heroName} healed for {100 - heroesHP[heroName]} HP!");
                            heroesHP[heroName] = 100;
                        }
                        else
                        {
                            heroesHP[heroName] += hPAmount;
                            Console.WriteLine($"{heroName} healed for {hPAmount} HP!");
                        }
                        break;
                }

                command = Console.ReadLine().Split(" - ");
            }
            heroesHP = heroesHP.Where(h => h.Value > 0).OrderByDescending(h => h.Value).ThenBy(h => h.Key).ToDictionary(h => h.Key, h => h.Value);
            foreach (var item in heroesHP)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine($"  HP: {item.Value}");
                Console.WriteLine($"  MP: {heroesMP[item.Key]}");
            }
        }
    }
}
