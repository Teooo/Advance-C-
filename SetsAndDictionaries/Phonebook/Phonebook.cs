using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Phonebook
{
    class Phonebook
    {
        static void Main()
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            string input = Console.ReadLine();
            while (input != "stop")
            {
                string[] parts = input.Split('-');
                if (phoneBook.ContainsKey(parts[0]))
                {
                    phoneBook[parts[0]] = parts[1];
                }
                else if(parts.Length == 2)
                {
                    phoneBook.Add(parts[0], parts[1]);
                }

                if (input == "search")
                {
                   input= Console.ReadLine();
                    while (input != "stop")
                    {

                        if (phoneBook.ContainsKey(input))
                        {
                            Console.WriteLine($"{input} -> {phoneBook[input]}");
                        }
                        else 
                        {
                            Console.WriteLine($"Contact {input} does not exist.");
                        }
                        input = Console.ReadLine();
                    }
                    if (input == "stop")
                    {
                        break;
                    }
                }
                input = Console.ReadLine();
            }

        }
    }
}
