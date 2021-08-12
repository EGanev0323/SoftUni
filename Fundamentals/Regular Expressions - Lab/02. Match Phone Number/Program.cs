using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"\+[3][5][9](\ |-|)[2]\1[0-9]{3}\1[0-9]{4}";
            var input =Console.ReadLine();
            MatchCollection phoneMatches = Regex.Matches(input, regex);
           

            Console.WriteLine(string.Join(", ",phoneMatches));
        }
    }
}
