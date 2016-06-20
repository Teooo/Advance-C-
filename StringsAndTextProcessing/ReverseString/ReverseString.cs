using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class ReverseString
    {
        static void Main()
        {
            string input = Console.ReadLine();
            char[] reverseChar = input.ToCharArray();
            Array.Reverse(reverseChar);          
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(reverseChar);
            Console.WriteLine(stringBuilder);
            
        }
    }
}
