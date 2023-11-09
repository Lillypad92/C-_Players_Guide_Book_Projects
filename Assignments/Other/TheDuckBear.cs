using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_C__player_s_guide.Assignments.Other
{
    public class TheDuckBear
    {
        public void Run() 
        {
            int fourSisters = 4;
            Console.WriteLine("How many eggs were gathered today? ", 0, 1000);
            int eggsCollected = int.Parse(Console.ReadLine()); 
            Console.WriteLine($"This is how many eggs were collected {eggsCollected} today.");

            int eggsResult = (eggsCollected / fourSisters);
            int duckBearResult = (eggsResult % fourSisters);
            Console.WriteLine($"The four sister gets {eggsResult} egg/eggs each and the duckbear gets {duckBearResult} egg/eggs.");
        }
    }
}
