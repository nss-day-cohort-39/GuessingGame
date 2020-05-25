using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int guessesAllowed;
            int guessesGiven = 0;
            Random rand = new Random();
            int secretNumber = rand.Next(1, 101);

            // Get difficulty
            Console.WriteLine("Select a difficulty:");
            Console.WriteLine("Easy (8 attempts)");
            Console.WriteLine("Medium (6 attempts)");
            Console.WriteLine("Hard (4 attempts)");
            string selectedDifficulty = Console.ReadLine();

            switch (selectedDifficulty)
            {
                case ("Easy"):
                    guessesAllowed = 8;
                    break;
                case ("Hard"):
                    guessesAllowed = 4;
                    break;
                default:
                    guessesAllowed = 6;
                    break;
            }

            bool canKeepGuessing = true;

            while (canKeepGuessing || selectedDifficulty == "Cheater")
            {
                Console.WriteLine($"Guess the secret number!");

                string userGuess = Console.ReadLine();
                int userGuessInt = Int32.Parse(userGuess);

                if (userGuessInt == secretNumber)
                {
                    Console.WriteLine("Yup! you guessed it!");
                    break;
                }
                else
                {
                    Console.Write("Nope, that wasn't it! ");

                    if (userGuessInt > secretNumber)
                    {
                        Console.WriteLine($"You're guess was too high. You have {guessesAllowed - guessesGiven - 1} more attempt(s)");
                    }
                    else
                    {
                        Console.WriteLine($"You're guess was too low. You have {guessesAllowed - guessesGiven - 1} more attempt(s)");
                    }
                }

                guessesGiven++;
                canKeepGuessing = guessesGiven < guessesAllowed;
            }

        }
    }
}