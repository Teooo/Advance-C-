using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicExchangeableWords
{
    class MagicExchangeableWords
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            Dictionary<char,char> mappedChars = new Dictionary<char, char>();
            string shortString = input[0];
            string longerString = input[1];
            if (shortString.Length > longerString.Length)
            {
                var temp = longerString;
                longerString = shortString;
                shortString = temp;
            }
            bool magic = true;
            for (int i = 0; i < shortString.Length; i++)
            {
                if (!mappedChars.ContainsKey(longerString[i]))
                {
                    mappedChars.Add(longerString[i],shortString[i]);
                }else if(mappedChars[longerString[i]] != shortString[i])
                {
                    magic =false;
                }
            }
            if (magic)
            {
                for (int i = shortString.Length; i < longerString.Length; i++)
                {
                    if (!mappedChars.ContainsKey(longerString[i]))
                    {
                        magic = false;
                        break;
                    }
                }
            }
            Console.WriteLine(magic.ToString().ToLower());
        }
    }
}
