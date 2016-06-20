using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace LettersChangeNumbers
{
    class LettersChangeNumbers
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { },StringSplitOptions.RemoveEmptyEntries);
            double result = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string currentElement = input[i];
                char firstCharacter = currentElement[0];
                char lastCharacter = currentElement[currentElement.Length - 1];
                double number = double.Parse(currentElement.Substring(1, currentElement.Length - 2));
                int alphaPos = firstCharacter % 32;

                if (char.IsLower(firstCharacter))
                {
                    number *= alphaPos;
                }
                else
                {
                    number /= alphaPos;
                }
                alphaPos = lastCharacter % 32;
                if (char.IsLower(lastCharacter))
                {
                    number += alphaPos;
                }
                else
                {
                    number -= alphaPos;
                }
                result += number;
            }
            Console.WriteLine("{0:F2}",result);
        }
    }
}
