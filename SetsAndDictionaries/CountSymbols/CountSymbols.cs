using System;
using System.Collections.Generic;
namespace CountSymbols
{
    class CountSymbols
    {
        static void Main()
        {
            string input = Console.ReadLine();

            SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                if (!symbols.ContainsKey(currentChar))
                {
                    symbols[currentChar] = 0;
                }
                symbols[currentChar]++;
            }
            foreach (var kvp in symbols)
            {
               
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}
