using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSubstringOccurrences
{
    class CountSubstringOccurrences
    {
        static void Main()
        {
            string input = Console.ReadLine().ToLower();
            string search = Console.ReadLine().ToLower();
            int counter = 0;
            int indexOfOccurence = input.IndexOf(search);
            while (indexOfOccurence != -1)
            {
                counter++;
                indexOfOccurence = input.IndexOf(search, indexOfOccurence + 1);
            }
            Console.WriteLine(counter);
        }
    }
}
