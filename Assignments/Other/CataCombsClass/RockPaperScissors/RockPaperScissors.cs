namespace The_C__player_s_guide.Assignments.Other.CataCombsClass.RockPaperScissors
{
    public class RockPaperScissors
    {
        public RockPaperScissors() { }

        public void Run()
        {
            Game game = new Game();
            game.StartGame();
        }
    }
    public class Game
    {
        List<Player> players = new List<Player>();
        public Game() { }

        public void StartGame()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors!");
            Console.WriteLine("You will play against another human being.");
            Console.WriteLine();

            Console.WriteLine("The rules are simple: \nRock beats Scissors, Scissors beats Paper, Scissors beats Paper, Paper beats Rock. Same options results in a draw.");
            Console.WriteLine("You will be competing against another player.");
            Console.WriteLine();

            CreatePlayer();
            
            Console.WriteLine($"Number of players: {players.Count}");

            // To print the result of the round
            while (true) 
            {
                string result = PlayRound();
                Console.WriteLine(result);

                string mostWins = result.Contains("wins") ? result.Split(" ")[0] : "No one";
                Console.WriteLine($"{mostWins} has the most wins so far!");

                Console.Write("Play another round? Yes(Y) or No(N): ");
                string playAnotherRound = Console.ReadLine()?.ToUpper();
                if (playAnotherRound != "Y") 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The game has ended.");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
            }
            
        }
        public void CreatePlayer()
        {
            while (true)
            {
                Console.Write("Enter player name: ");
                string name = Console.ReadLine();
                players.Add(new Player(name));

                Console.WriteLine();

                Console.Write("Add another player? Yes(Y) or No(N)?: ");
                string addAnotherPlayer = Console.ReadLine()?.ToUpper();

                if (addAnotherPlayer != "Y") 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No more players will be added.");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                Console.WriteLine();
            }
        }
        public string PlayRound() 
        {
            Console.WriteLine("Starting the round...");
             
            {
                string[] playerChoice = new string[players.Count];

                for (int i = 0; i < players.Count; i++)
                {
                    Console.Write($"{players[i].Name}, choose Rock(R), Scissors(S) or Paper(P): ");
                    playerChoice[i] = Console.ReadLine()?.ToUpper();
                    Console.Clear();
                    Console.Write($"{players[i].Name} has choosen.");
                    Console.WriteLine();
                }
                string p1 = playerChoice[0];
                string p2 = playerChoice[1];

                if (p1 == p2) return "It is a draw!";

                if ((p1 == "R" && p2 == "S") || (p1 == "S" && p2 == "P") || (p1 == "P" && p2 == "R")) return $"{players[0].Name} wins!";
                else if ((p2 == "R" && p1 == "S") || (p2 == "S" && p1 == "P") || (p2 == "P" && p1 == "R")) return $"{players[1].Name} wins!";
                else return "Invalid input. Please use R, P, or S.";
            }
        }    
    }

public class Player
{
    public string Name { get { return _name; } }
    private string _name;

    public Player(string name)
    {
        _name = name;
    }
}   
}