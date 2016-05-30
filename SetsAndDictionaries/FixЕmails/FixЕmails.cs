using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FixЕmails
{
    class FixЕmails
    {
        static void Main()
        {
            Dictionary<string, string> sequence = new Dictionary<string, string>();
           
            string name = Console.ReadLine();

            while (name != "stop")
            {
                string email = Console.ReadLine();
                string ending = email.Substring(email.Length - 2, 2);
                if (ending != "uk" && ending != "us")
                {
                    sequence.Add(name,email);
                }
                name = Console.ReadLine();
            }
            foreach (var a in sequence)
            {
                Console.WriteLine($"{a.Key} -> {a.Value}");
            }
        }

    }
}
