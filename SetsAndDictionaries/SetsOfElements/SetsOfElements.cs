using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetsOfElements
{
    class SetsOfElements
    {
        static void Main()
        {
            string[] lenth = Console.ReadLine().Split(' ');
            int n = int.Parse(lenth[0]);
            int m = int.Parse(lenth[1]);
            
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();
            for (int i = 0; i <n+m ; i++)
            {

                if (i < n)
                {
                    int firstSetInput = int.Parse(Console.ReadLine());
                    firstSet.Add(firstSetInput);
                }
                if (i >= n)
                {
                    int secondSetInput = int.Parse(Console.ReadLine());
                    secondSet.Add(secondSetInput);
                }
                
            }
            firstSet.IntersectWith(secondSet);

            
            foreach (var number in firstSet)
            {
                Console.Write(number + " ");
            }
        }
    }
}
