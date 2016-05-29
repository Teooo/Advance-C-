using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStackOperations
{
    class BasicStackOperations
    {
        static void Main()
        {
            int[] intputParams = Console.ReadLine()
                .Trim()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int n = intputParams[0];
            int s = intputParams[1];
            int x = intputParams[2];

            Stack<int> numbers = new Stack<int>();

            int[] inputNumbers = Console.ReadLine()
            .Trim()
            .Split()
            .Select(int.Parse)
            .ToArray();
            foreach (var num in inputNumbers)
            {
                numbers.Push(num);
                n--;
            }
            while (s != 0)
            {
                numbers.Pop();
                s--;
            }
            if (numbers.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (numbers.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(numbers.ToArray().Min());
              
            }
        }
    }
}
