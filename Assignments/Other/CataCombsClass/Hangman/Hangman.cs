using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_C__player_s_guide.Assignments.Other.CataCombsClass.RockPaperScissors;

namespace The_C__player_s_guide.Assignments.Other.CataCombsClass.Hangman
{
    public class Hangman
    {
        public Hangman() { }
        public void Run()
        {
            Game game = new Game();
            game.StartGame();

            
        }  
    }
    public class Game
    {
        string[] words = { "computer", "hangman", "dreaming", "animals", "array", "gaming", "summer", "winter", "spring", "autumn" };
        
        List<string> guessedChar = new List<string>();
        public void StartGame()
        {
            Console.WriteLine("Welcome to the game Hangman!");
            Console.WriteLine("Here you will guess the word. You win by guessing the correct word and loose if you are out of guesses.");
            Console.WriteLine("There will be a total of ten random words and you have ten guesses.");
    
            PickWord();

        }

        public string PickWord()
        {
            Random random = new Random();
            int index = random.Next(words.Length);
            string wordsToGuess = words[index];
            int guessesLeft = 10;

            while (guessesLeft > 0) 
            {
                string displayWord = "";
                foreach (char c in wordsToGuess) 
                { 
                    if (guessedChar.Contains(c.ToString()))
                        displayWord += c + " ";
                    else 
                        displayWord += "_ ";
                }

                Console.WriteLine($"Word:   {displayWord.Trim()}   | Remaining: {guessesLeft} | Incorrect: | Guessed characters: " + string.Join(", ", guessedChar));
                Console.Write("Guess: "); string guess = Console.ReadLine();

                guessedChar.Add(guess);

                if (!wordsToGuess.Contains(guess))
                {
                    guessesLeft--;
                    Console.WriteLine($"Incorrect!");
                }
                else 
                {
                    bool allGuessed = wordsToGuess.All(c => guessedChar.Contains(c.ToString()));
                    
                    if (wordsToGuess.All(c => guessedChar.Contains(c.ToString())))
                    {
                        Console.WriteLine($"Word: {displayWord.Trim()}  | Remaining: {guessesLeft} | Incorrect: | Guessed characters: " + string.Join(", ", guessedChar));
                        Console.WriteLine($"You guessed the word! You win! {wordsToGuess}!");
                        break;
                    }
                }

                if (guessesLeft == 0)
                {
                    Console.WriteLine($"You are out of guesses! The word was: {wordsToGuess}");
                    break;
                }                
            }
            return wordsToGuess;
        }
    }
}
