using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_C__player_s_guide.Assignments.Other
{
    public class BuyingInventory
    {
        public void Run() 
        {
            
            string myName = "Linda";
            Console.WriteLine("Welcome! This is the shop that you can buy some supplies.");
            Console.WriteLine("The following items are available: ");
            Console.WriteLine("1 - Rope");
            Console.WriteLine("2 - Torches");
            Console.WriteLine("3 - Climbing Equipment");
            Console.WriteLine("4 - Clean Water");
            Console.WriteLine("5 - Machete");
            Console.WriteLine("6 - Canoe");
            Console.WriteLine("7 - Food Supplies");
            Console.Write("What number do you want to see the price of? ");
            int usersInput = int.Parse(Console.ReadLine());
            Console.WriteLine("You can get a 50% discount if you anwser this question correctly.\nWhat is your name? ");
            string usersName = Console.ReadLine();

            switch (usersInput)
            {

                case 1:
                    if (usersName == myName)
                    {
                        Console.WriteLine("The rope costs 5 gold.");
                    }
                    else
                    {
                        Console.WriteLine("The rope costs 10 gold.");
                    }
                    break;

                case 2:
                    if (usersName == myName)
                    {
                        Console.WriteLine($"The torches costs 15 gold.");
                    }
                    else
                    {
                        Console.WriteLine("The torches costs 7,5 gold.");
                    }
                    break;

                case 3:
                    if (usersName == myName)
                    {
                        Console.WriteLine($"The climbing equipment costs 12,5 gold.");
                    }
                    else
                    {
                        Console.WriteLine("The climbing equipment costs 25 gold.");
                    }
                    break;

                case 4:
                    if (usersName == myName)
                    {
                        Console.WriteLine($"The clean water costs 1 gold.");
                    }
                    else
                    {
                        Console.WriteLine("The clean water costs 0,5 gold.");
                    }
                    break;

                case 5:
                    if (usersName == myName)
                    {
                        Console.WriteLine($"The machete costs 10 gold.");
                    }
                    else
                    {
                        Console.WriteLine("The machete costs 20 gold.");
                    }
                    break;

                case 6:
                    if (usersName == myName)
                    {
                        Console.WriteLine($"The canoe costs 100 gold.");
                    }
                    else
                    {
                        Console.WriteLine("The machete costs 200 gold.");
                    }
                    break;

                case 7:
                    if (usersName == myName)
                    {
                        Console.WriteLine($"The food supplies costs 0,5 gold.");
                    }
                    else
                    {
                        Console.WriteLine("The food supplies 1 gold.");
                    }
                    break;

                default:
                    Console.WriteLine("I do not know that one.");
                    break;
            }
        }
    }
}
