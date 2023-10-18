using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_C__player_s_guide.Assignments.Other
{
    enum FoodTypes {Soup, Stew, Gumbo }
    enum MainIngredient {Mushrooms, Chicken, Carrots, Potatoes }
    enum Seasoning {Spicy, Salt, Sweet }
    internal class SimulaSoup
    {
        public SimulaSoup() { }
        public void RunSimulaSoup() 
        {
            (FoodTypes type, MainIngredient ingredient, Seasoning seasoning) soup = GetSoup(); // tuple
            Console.WriteLine($"{soup.seasoning} {soup.ingredient} {soup.type}");
            (FoodTypes, MainIngredient, Seasoning) GetSoup() 
            {
                FoodTypes type = GetSoupType();
                MainIngredient ingredient = GetMainIngredient();
                Seasoning seasoning = GetSeasoning();
                return (type, ingredient, seasoning);
            }
        }
        MainIngredient GetMainIngredient() 
        {
            Console.WriteLine("Main ingredient is: mushrooms, chicken, carrot and potato.");
            string input = Console.ReadLine();
            return input switch
            {
                "mushroom" => MainIngredient.Mushrooms,
                "chicken" => MainIngredient.Chicken,
                "carrot" => MainIngredient.Carrots,
                "potao" => MainIngredient.Potatoes
            };
        }
        FoodTypes GetSoupType() 
        {
            Console.WriteLine("Soup type is: soup, stew and gumbo");
            string input = Console.ReadLine();
            return input switch
            {
                "soup" => FoodTypes.Soup,
                "stew" => FoodTypes.Stew,
                "gumbo" => FoodTypes.Gumbo
            };
        }
        Seasoning GetSeasoning() 
        {
            Console.WriteLine("Seasoning is: spicy, salt and sweet.");
            string input = Console.ReadLine();
            return input switch
            {
                "spicy" => Seasoning.Spicy,
                "salt" => Seasoning.Salt,
                "sweet" => Seasoning.Sweet
            };
        }
    }
}
