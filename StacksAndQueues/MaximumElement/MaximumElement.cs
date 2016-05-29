using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumElement
{
    class MaximumElement
    {
        static void Main()
        {
            int nQueries = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();
            Stack<int> maxNumbers = new Stack<int>();
            int maxNumber = Int32.MinValue;
            for (int i = 0; i < nQueries; i++)
            {
                int[] inputNumbers = Console.ReadLine()
                    .Trim()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                
                if (inputNumbers[0] == 1)
                {
                    int numberToPush = inputNumbers[1];
                    numbers.Push(numberToPush);
                    if (maxNumbers.Count == 0 || numberToPush >= maxNumber)
                    {
                        maxNumber = numberToPush;
                        maxNumbers.Push(maxNumber);
                    }
                }
                else if(inputNumbers[0] == 2)
                {
                    int numberPop = numbers.Pop();
                    int currentMaxNumber = maxNumbers.Peek();
                    if (numberPop == currentMaxNumber)
                    {
                        maxNumbers.Pop();
                        if (maxNumbers.Count > 0)
                        {
                            maxNumber = maxNumbers.Peek();
                        }
                    }
                }
                else if (inputNumbers[0] == 3)
                {
                    
                    Console.WriteLine(maxNumbers.Peek());
                }        
            }
        }
    }
}
