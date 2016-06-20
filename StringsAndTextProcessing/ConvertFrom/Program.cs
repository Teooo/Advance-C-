using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConvertFrom
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();

            BigInteger toBase = BigInteger.Parse(input[0]);
            BigInteger number = BigInteger.Parse(input[1]);
            string parsedNumber = string.Empty;
            do
            {
                parsedNumber +=  toBase % number;
                toBase /= number;
            } while (toBase > 0);
            char[] toBeReverse = parsedNumber.ToCharArray();
            Array.Reverse(toBeReverse);
            string result = string.Join("", toBeReverse);
            Console.WriteLine(result);
        }
    }
}
