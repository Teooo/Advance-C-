using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Series_of_Letters
{
    class SeriesOfLetters
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = "";

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                pattern = currentChar.ToString()+"+";
                Regex regex = new Regex(pattern);
                if (regex.IsMatch(input))
                {
                   input= regex.Replace(input, currentChar.ToString());
                }

            }
            Console.WriteLine(input);
        }
    }
}
