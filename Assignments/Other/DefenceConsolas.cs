using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_C__player_s_guide.Assignments.Other
{
    internal class DefenceConsolas
    {
        public void RunDefenceConsolas() 
        {
            Console.Title = "The Defense of Consolas";
            Console.Write("Target row? ");
            int targetRow = int.Parse(Console.ReadLine());
            Console.Write("Target Column? ");
            int targetColumn = int.Parse(Console.ReadLine());
            Console.WriteLine("Deploy to: ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"({targetRow}, {targetColumn - 1})");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"({targetRow - 1}, {targetColumn})");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"({targetRow}, {targetColumn + 1})");
            Console.WriteLine($"({targetRow + 1}, {targetColumn})");

            Console.Beep(400, 1000);

        }
    }
}

