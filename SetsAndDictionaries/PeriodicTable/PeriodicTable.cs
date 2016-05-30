using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicTable
{
    class PeriodicTable
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> chemical = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split();
                for (int j = 0; j < line.Length; j++)
                {
                    chemical.Add(line[j]);
                }
            }
            foreach (var c in chemical)
            {
                Console.Write(c + " ");
            }
            HashSet<int> a = new HashSet<int>();
            a.IntersectWith(a);
        }
    }
}
