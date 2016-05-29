using System;
using System.Collections.Generic;

namespace TruckTour
{
    class TruckTour
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Queue<GasPomp> pumps = new Queue<GasPomp>();
            for (int i = 0; i < n; i++)
            {
                string[] pumpInfo = Console.ReadLine().Split();
                int distanceToNext = int.Parse(pumpInfo[1]);
                int amountOfGas = int.Parse(pumpInfo[0]);
                GasPomp pump = new GasPomp(distanceToNext, amountOfGas, i);
                pumps.Enqueue(pump);
            }
            GasPomp starterPump = null;
            bool completeJourney = false;

            while (pumps.Count > 0)
            {
                GasPomp currentPump = pumps.Dequeue();
                pumps.Enqueue(currentPump);

                starterPump = currentPump;
                int gasInTank = currentPump.amountOfGas;

                while (gasInTank >= currentPump.distanceToNext)
                {
                    gasInTank -= currentPump.distanceToNext;
                    currentPump = pumps.Dequeue();
                    pumps.Enqueue(currentPump);
                    if (currentPump == starterPump)
                    {
                        completeJourney = true;
                        break;
                    }
                    gasInTank += currentPump.amountOfGas;
                }
                if (completeJourney)
                {
                    Console.WriteLine(starterPump.indexOfPump);
                    break;
                }
            }
        }
    }

    public class GasPomp
    {
        public int distanceToNext;
        public int amountOfGas;
        public int indexOfPump;
        public GasPomp(int distanceToNext, int amountOfGas, int indexOfPump)
        {
            this.distanceToNext = distanceToNext;
            this.amountOfGas = amountOfGas;
            this.indexOfPump = indexOfPump;
        }
    }
}
