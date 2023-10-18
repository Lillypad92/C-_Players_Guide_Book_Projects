namespace The_C__player_s_guide.Assignments.Manticore
{
    public class Manticore
    {
        public Manticore() { }

        public void Run()
        {
            int manticoreDistance = GetManticoreDistance();
            Game(manticoreDistance);
        }

        private int GetInputNumber()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    return number;
                }
                
                Console.Write("You have not written a number, try again! ");
            }
        }

        private int GetManticoreDistance()
        {
            Console.Write("Player 1: how far away from the city do you want to station the Manticore? (0 - 100) ");

            int manticoreDistance = GetInputNumber();

            while (true)
            {
                if (manticoreDistance < 0 || manticoreDistance > 100)
                {
                    Console.Write("You have written an incorrect number, try again! ");
                    manticoreDistance = GetInputNumber();
                }
                else
                {
                    Console.Clear();
                    return manticoreDistance;
                }
            }
        }
        private void Game(int manticoreDistance)
        {
            int manticoreHealth = 10;
            int cityHealth = 15;
            int roundNumber = 1;

            Console.WriteLine("Player 2, it is your turn.");
            while (true)
            {
                if(ShouldEndGame(cityHealth, manticoreHealth)) { break; }
     
                Console.WriteLine("-----------------------------------------------------------------");
                Console.WriteLine($"STATUS: Round: {roundNumber++} City: {cityHealth} / 15  Manticore: {manticoreHealth} / 10.");

                int canonDamage = CanonDamagePoints(roundNumber);
                Console.WriteLine($"The canon is expected to deal {canonDamage} damage.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Enter the desired canon range: ");
                int cannonRange = GetInputNumber();

                if (cannonRange == manticoreDistance)
                {

                    manticoreHealth -= canonDamage;
                    Console.WriteLine("That round was a DIRECT HIT!");
                    Console.WriteLine();
                }
                else if (cannonRange < manticoreDistance)
                {
                    Console.WriteLine("That round FELL SHORT of the target. ");
                    Console.WriteLine();
                }
                else if (cannonRange > manticoreDistance)
                {
                    
                    Console.WriteLine("That round OVERSHOT the target. ");
                    Console.WriteLine();
                }
                if (manticoreHealth > 0)
                {
                    cityHealth--;  
                }
            }
        }

        private bool ShouldEndGame(int cityHealth, int manticoreHealth)
        {
            if (cityHealth == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The City of Conolas has fallen! The Manitcore has won. ");
                Console.ForegroundColor = ConsoleColor.White;
                return true;
            }
            else if (manticoreHealth <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The Manticore has been destroyed!\nThe City of Consolas has been saved.");
                Console.ForegroundColor = ConsoleColor.White;
                return true;
            }

            return false;
        }

        private int CanonDamagePoints(int roundNumber)
        {
            if (roundNumber % 3 == 0 && roundNumber % 5 == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                return 10; // Multiple by 3 and 5: Migthy fireelectric blast: 10 points of damage 
            }
            if (roundNumber % 3 == 0)  /*Multiple by 3: fire blast: 3 points of damage and multiple by 5: elektric blast: 3 points of damage*/
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return 3;
            }
            if (roundNumber % 5 == 0) {
                Console.ForegroundColor = ConsoleColor.Blue;
                return 3;
            }

            Console.ForegroundColor = ConsoleColor.White;
            return 1; // Normal round: 1 points of damage
        }
    }
}
