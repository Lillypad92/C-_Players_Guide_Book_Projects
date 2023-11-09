using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_C__player_s_guide.Assignments.Other
{
    public class RepairingClockTower
    {
        public void Run() 
        {
           
            //Even number = tick;
            //Odd number = tock;
            int remainder = 2;
            Console.WriteLine("We need to figure it out if the clock is even or odd. Write any number.");
            int input = int.Parse(Console.ReadLine());
            int clockResult = (input % remainder);

            if (clockResult == 0)
            {

                Console.WriteLine("The clock is even: Tick");
            }
            else
            {

                Console.WriteLine("The clock is odd: Tock");
            }
        }
    }
}
