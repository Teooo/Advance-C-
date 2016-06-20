using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchPhoneNumber
{
    class MatchPhoneNumber
    {
        static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder output = new StringBuilder();
            string pattern = @"(\+(359)(\s)2(\s)(\d{3})(\s)(\d{4})$)|(\+(359)(\-)2(\-)(\d{3})(\-)(\d{4})$)";
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
