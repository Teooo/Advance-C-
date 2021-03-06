﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogs
{
    class UserLogs
    {
        static void Main()
        {
            SortedDictionary<string,Dictionary<string, int>>logsByUser = new SortedDictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();

            while (input !="end")
            {
                string[] logInfo = input.Split();

                string[] IPinfo = logInfo[0].Split('=');
                string IP = IPinfo[1];

                string[] userInfo = logInfo[2].Split('=');
                string user = userInfo[1];

                if (!logsByUser.ContainsKey(user))
                {
                    logsByUser.Add(user,new Dictionary<string, int>());
                    logsByUser[user].Add(IP, 0);
                }
                else if (!logsByUser[user].ContainsKey(IP))
                {
                    logsByUser[user].Add(IP,0);
                }
                logsByUser[user][IP]++;
                input = Console.ReadLine();
               
            }
            foreach (var outerPair in logsByUser)
            {
                Console.WriteLine("{0}:",outerPair.Key);
                Console.WriteLine("{0}.",string.Join(", ",outerPair.Value.Select(x=>$"{x.Key} => {x.Value}")));
              
            }
            
        }
    }
}
