using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_C__player_s_guide.Assignments.Other
{
    public class ReplicatorDoom
    {
        public void Run() 
        {
            /*The Replicator of D´To challenge*/
            int[] firstArray = new int[5];
            int index = 0;
            Console.WriteLine("I want you to pick five numbers. You can pick any number.");

            while (true)
            {
                Console.WriteLine("Pick a new number");
                int usersAnswer = int.Parse(Console.ReadLine());
                firstArray[index++] = usersAnswer;

                if (index == firstArray.Length)
                {
                    break;
                }
            }int[] secondArray = new int[5];
            for (int i = 0; i < 5; i++)
            {
                secondArray[i] = firstArray[i];
                Console.WriteLine($"This is the first array: {firstArray[i]}");
                Console.WriteLine($"This is the second array: {secondArray[i]}");
            };
        }       
    }
}
