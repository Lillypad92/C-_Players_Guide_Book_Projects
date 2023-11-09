namespace The_C__player_s_guide.Assignments.Other
{
    public class PotionMasters
    {
        enum PotionTypes { Water, Elixir, Poison, Flying, Invisibility, NigthSight, Wraith, Ruined, CloudyBrew }
        enum IngredientTypes { StarDust, SnakeVenom, DragonBreath, ShadowGlass, EyeShineGem }
        public void RunPotion() 
        {
            PotionTypes potion = PotionTypes.Water;

            while (true)
            {
                Console.WriteLine($"Your starting potion is: {potion}.");

                Console.WriteLine("Do you want to add any more ingredients?");
                string? input = Console.ReadLine();

                if (input == "no") break;

                Console.WriteLine("Here are the currently ingredients: stardust, snake venom, dragon breath, shadow glass and eyeshine gem");
                Console.Write("What is your ingredient choice? ");

                IngredientTypes ingredient = Console.ReadLine() switch
                {
                    "stardust" => IngredientTypes.StarDust,
                    "snake venom" => IngredientTypes.SnakeVenom,
                    "dragon breath" => IngredientTypes.DragonBreath,
                    "shadow glass" => IngredientTypes.ShadowGlass,
                    "eyeshine gem " => IngredientTypes.EyeShineGem
                };
                potion = (ingredient, potion) switch
                {
                    (IngredientTypes.StarDust, PotionTypes.Water) => PotionTypes.Elixir,
                    (IngredientTypes.SnakeVenom, PotionTypes.Elixir) => PotionTypes.Poison,
                    (IngredientTypes.DragonBreath, PotionTypes.Elixir) => PotionTypes.Flying,
                    (IngredientTypes.ShadowGlass, PotionTypes.Elixir) => PotionTypes.Invisibility,
                    (IngredientTypes.EyeShineGem, PotionTypes.Elixir) => PotionTypes.NigthSight,
                    (IngredientTypes.ShadowGlass, PotionTypes.NigthSight) => PotionTypes.CloudyBrew,
                    (IngredientTypes.StarDust, PotionTypes.CloudyBrew) => PotionTypes.Wraith,
                    (_, _) => PotionTypes.Ruined
                };
                if (potion == PotionTypes.Ruined)
                {
                    Console.WriteLine("Unfortunately, you brewed a ruined potion. You have to start over.");
                    potion = PotionTypes.Water;
                }
            }

        }
    }
}
