using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchFullName
{
    class MatchFullName
    {
        static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder output = new StringBuilder();
            string pattern = @"\b(^[A-Z]+[a-z]+)\s[A-Z]+[a-z]+\b";
            Regex regex = new Regex(pattern);
            while (input != "end")
            {
                if (regex.IsMatch(input))
                {
                    output.AppendLine(input);
                }
                input = Console.ReadLine();
                if (input == "end")
                {
                    Console.WriteLine(output);
                }
                
            }
        }
    }
}
