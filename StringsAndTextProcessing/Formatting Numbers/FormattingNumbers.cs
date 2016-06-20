using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formatting_Numbers
{
    class FormattingNumbers
    {
        static void Main()
        {
            char[] spliter = new[] {' ', '\n', '\t'};
            string[] input = Console.ReadLine().Split(spliter,StringSplitOptions.RemoveEmptyEntries);
            int a = int.Parse(input[0]);
            double b = double.Parse(input[1]);
            double c = double.Parse(input[2]);
            string binaryNumber = Convert.ToString(a, 2);
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("|" +a.ToString("X").PadRight(10));
            stringBuilder.Append("|" + binaryNumber.PadLeft(10,'0').Substring(0,10));
            stringBuilder.Append("|" + b.ToString("0.00").PadLeft(10));
            stringBuilder.Append("|" + c.ToString("0.000").PadRight(10) + "|");
            Console.WriteLine(stringBuilder);
        }
    }
}
