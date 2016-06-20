using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractEmails
{
    class ExtractEmails
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string pattern = "([\\w.]+[.|_|-]?[\\w?]+@\\w+.[\\w+]{2,3})[\\.]?[\\w+]+";

            Regex regex = new Regex(pattern);
            var matches = Regex.Matches(input,pattern);
            if (regex.IsMatch(input))
            {
                foreach (Match a in matches)
                {
                    Console.WriteLine(a.Groups[0]);
                }
            }
        }
    }
}
