using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_C__player_s_guide.Assignments.Other
{
    internal class ThreeKings
    {   int estate = 1;
        int duchy = 3;
        int province = 6;
        public void RunThreeKings() 
        {
            Melik();
            Casik();
            Balik();
        }
        private int Melik() 
        {
            Console.WriteLine("How many estates does Melik have?");
            int estateMelik = int.Parse(Console.ReadLine());
            Console.WriteLine("How many duchies does Melik have?");
            int duchyMelik = int.Parse(Console.ReadLine());
            Console.WriteLine("How many provinces does Melik have?");
            int provinceMelik = int.Parse(Console.ReadLine());

            int resultMelik = (estateMelik * estate) + (duchyMelik * duchy) + (provinceMelik * province);
            Console.WriteLine($"Melik's total kingdom points is: {resultMelik}");
            return resultMelik;
        }
        private int Casik() 
        {
            Console.WriteLine("How many estates does Casik have?");
            int estateCasik = int.Parse(Console.ReadLine());
            Console.WriteLine("How many duchies does Casik have?");
            int duchyCasik = int.Parse(Console.ReadLine());
            Console.WriteLine("How many provinces does Casik have?");
            int provinceCasik = int.Parse(Console.ReadLine());

            int resultCasik = (estateCasik * estate) + (duchyCasik * duchy) + (provinceCasik * province);
            Console.WriteLine($"Casik's total kingdom points is: {resultCasik}");
            return resultCasik;
        }
        private int Balik() 
        {
            Console.WriteLine("How many estates does Balik have?");
            int estateBalik = int.Parse(Console.ReadLine());
            Console.WriteLine("How many duchies does Balik have?");
            int duchyBalik = int.Parse(Console.ReadLine());
            Console.WriteLine("How many provinces does Balik have?");
            int provinceBalik = int.Parse(Console.ReadLine());

            int resultBalik = (estateBalik * estate) + (duchyBalik * duchy) + (provinceBalik * province);
            Console.WriteLine($"Balik's total kingdom points is {resultBalik}");
            return resultBalik;
        }
    }     
}






