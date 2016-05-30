using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMinerTask
{
    class AMinerTask
    {
        static void Main()
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();
         
            string res = Console.ReadLine();

            while (!res.Contains("stop"))
            {

                int quantity = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(res))
                {
                    resources.Add(res,quantity);
                }
                else if(resources.ContainsKey(res))
                {
                    resources[res] += quantity;
                }
                
                res = Console.ReadLine();
               
            }
           
            foreach(var itiem in resources)
            {
                Console.WriteLine($"{itiem.Key} -> {itiem.Value}");
            }
        }
    }
}
