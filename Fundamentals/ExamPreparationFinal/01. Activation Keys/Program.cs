using System;

namespace _01._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();
            string[] operation =Console.ReadLine().Split(">>>");
            while (operation[0]!="Generate")
            {
                switch (operation[0])
                {
                    case "Contains":
                        string substring = operation[1];
                        if (activationKey.Contains(substring))
                        {
                            Console.WriteLine($"{activationKey} contains {substring}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }
                        break;
                    case "Flip":
                        string cmd = operation[1];
                        int startIndex = int.Parse(operation[2]);
                        int endIndex = int.Parse(operation[3]);
                        if (cmd=="Upper")
                        {
                            for (int i = startIndex; i < endIndex; i++)
                            {
                                char currentChar = char.ToUpper(activationKey[i]);
                                activationKey = activationKey.Remove(i, 1);
                                activationKey = activationKey.Insert(i, currentChar.ToString());
                            }
                            Console.WriteLine(activationKey);
                        }
                        else
                        {
                            for (int i = startIndex; i < endIndex; i++)
                            {
                                char currentChar = char.ToLower(activationKey[i]);
                                activationKey = activationKey.Remove(i, 1);
                                activationKey = activationKey.Insert(i, currentChar.ToString());
                            }
                            Console.WriteLine(activationKey);
                        }
                        break;
                    case "Slice":

                        for (int i = int.Parse(operation[2]) - 1; i >= int.Parse(operation[1]); i--)
                        {
                            activationKey = activationKey.Remove(i, 1);
                        }
                        Console.WriteLine(activationKey);

                        break;
                }

                operation =Console.ReadLine().Split(">>>");
            }
            Console.WriteLine($"Your activation key is: { activationKey}");
        }
    }
}
