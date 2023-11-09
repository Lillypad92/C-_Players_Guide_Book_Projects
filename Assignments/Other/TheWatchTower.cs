using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_C__player_s_guide.Assignments.Other
{
    internal class TheWatchTower
    {
        public void Run() 
        {
            
            Console.WriteLine("This is the watchtower that can alert the city Consolas.");
            Console.WriteLine("In order to know if there is an upcoming attack, the watchtower needs an X-value and Y-value.");
            Console.WriteLine("You can add numbers between 0-10 and also add subtraction (-) numbers.\nPlease enter a numer below.");
            Console.Write("I want an x value: ");
            int xValue = int.Parse(Console.ReadLine());
            Console.Write("I want an y value: ");
            int yValue = int.Parse(Console.ReadLine());

            if (xValue == 0 && yValue == 0)
            {
                Console.WriteLine("The enemy is here!");
            }
            else if (xValue == 0 && yValue > 0)
            {
                Console.WriteLine("The enemy is to the north!");
            }
            else if (xValue < 0 && yValue > 0)
            {
                Console.WriteLine("The enemy is to the northwest!");
            }
            else if (xValue < 0 && yValue == 0)
            {
                Console.WriteLine("The enemy is to the west!");
            }
            else if (xValue < 0 && yValue < 0)
            {
                Console.WriteLine("The enemy is to the southwest!");
            }
            else if (xValue == 0 && yValue < 0)
            {
                Console.WriteLine("The enemy is to the south!");
            }
            else if (xValue > 0 && yValue < 0)
            {
                Console.WriteLine("The enemy is to the southeast!");
            }
            else if (xValue > 0 && yValue == 0)
            {
                Console.WriteLine("The enemy is to the east!");
            }
            else if (xValue > 0 && yValue > 0)
            {
                Console.WriteLine("The enemy is to the northeast!");
            }
        }
    }
}
