using System;
using System.Collections.Generic;
namespace Unique_Usernames
{
    class UniqueUsernames
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());            
            HashSet<string> name = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                
                name.Add(Console.ReadLine());
            }
            foreach (var a in name)
            {
                Console.WriteLine(a);
            }
           
        }
    }
}
foreach (var item in sequence)
                {
                    for (int i = 0; i<item.Value.Length; i++)
                    {
                        if ((item.Value[i] == '.' && item.Value[i + 1] == 'u' && item.Value[i + 2] == 's') || item.Value[i + 2] == 'k')
                        {

                            a.Add(item.Key);
                        }
                    }
                }
                if (input == "stop")
                {
                    foreach (var ab in a)
                    {
                        sequence.Remove(ab);
                    }
                    
                }