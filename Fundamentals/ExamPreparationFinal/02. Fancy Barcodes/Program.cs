using System;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"@#+(?<name>[A-Z][A-Za-z0-9]+[A-Z])@#+";
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                string group = "";
                string barcode = Console.ReadLine();
                Match machedItem = Regex.Match(barcode, pattern);
                string name = machedItem.Groups["name"].Value;
                if (name.Length>=6)
                {
                    for (int j = 0; j < name.Length; j++)
                    {
                        if (name[j]=='1')
                        {
                            group += '1';
                        }
                        if (name[j] == '2')
                        {
                            group += '2';
                        }
                        if (name[j] == '3')
                        {
                            group += '3';
                        }
                        if (name[j] == '4')
                        {
                            group += '4';
                        }
                        if (name[j] == '5')
                        {
                            group += '5';
                        }
                        if (name[j] == '6')
                        {
                            group += '6';
                        }
                        if (name[j] == '7')
                        {
                            group += '7';
                        }
                        if (name[j] == '8')
                        {
                            group += '8';
                        }
                        if (name[j] == '9')
                        {
                            group += '9';
                        }
                        if (name[j] == '0')
                        {
                            group += '0';
                        }
                        
                    }
                    if (group=="")
                    {
                        group = "00";
                    }

                    Console.WriteLine($"Product group: {group}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
