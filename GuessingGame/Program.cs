using System;

namespace GuessingGame
{
    /*
     * Project Name: Interactivity: Guessing Game
     * Contribution: Kyle Yeager
     * Feature: Loops for a game
     * Start Date: 11/26/2020
     * End Date:
     * Refrences: Class video week one
     * Links: https://online.fullsail.edu/class_sections/85326/modules/309313/activities/1860297
     */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, would you like to play a two player guessing game?");
            Console.WriteLine("Type (y) for yes, and (n) for no.\n");

            string arePlaying = "";

            arePlaying = Console.ReadKey().KeyChar.ToString().ToLower();
           
            // was a test line Console.WriteLine($"\nyou said {arePlaying}");

            // below is the game loop
            while (arePlaying == "y")
            {
                Console.WriteLine("\nYou can leave by typing quit then hitting enter when prompted.");


                Console.WriteLine("Player one, please enter a number between 0 - 100 for player two to guess, or type quit to exit then hit enter.");
                // issue with quiting out find new way to do it
                String firstToGuess = Console.ReadLine().ToLower();
                int toGuess;
                if (firstToGuess == "quit")
                {
                    return;
                }
                else
                {
                    toGuess = Int32.Parse(firstToGuess);
                }


                while (toGuess > 100 || toGuess < 0)
                {
                    Console.WriteLine("Please enter a number between 0-100 then hit enter.");
                    toGuess = Int32.Parse(Console.ReadLine());

                }
                // was a test line Console.WriteLine($"{toGuess}");

                // this needs to be a secontion to clear the screen.
                // Found Console.Clear while typing Console.Writeline i went and checked all the options
                Console.Clear();

                // test line to see it cleared Console.WriteLine("see if cleared");

                Console.WriteLine("Now Hand the computer to player two.");
                Console.WriteLine("Player two you have 5 guesses to guess the correct number.");

                Console.WriteLine("Player two, Enter a number to guess between 0-100 or type quit to exit.");

                string playerTwoInput = "";
                int playerTwoGuess;

                playerTwoInput = Console.ReadLine().ToLower();

                if (playerTwoInput == "quit")
                {
                    return;
                }
                else
                {
                    playerTwoGuess = Int32.Parse(playerTwoInput);
                }

                int guessAttempts = 4;

                while (playerTwoGuess != toGuess && guessAttempts > 0  )
                {
                    
                    Console.WriteLine($"You guessed {playerTwoGuess}.");
                    if (playerTwoGuess == toGuess)
                    {
                        Console.WriteLine("That guess is correct!");
                        Console.WriteLine($"You had {guessAttempts} remaining guesses.");
                    }
                    else if (playerTwoGuess > toGuess)
                    {
                        Console.WriteLine("That guess is too high!");
                        Console.WriteLine($"You have {guessAttempts} remaining guesses. ");
                    }
                    else if (playerTwoGuess < toGuess)
                    {
                        Console.WriteLine("That guess is too low!");
                        Console.WriteLine($"You have {guessAttempts} remaining guesses. ");
                    }
                    guessAttempts--;
                    playerTwoGuess = Int32.Parse(Console.ReadLine());
                }

                // this is to just declutter it before it starts
                Console.Clear();

                if (playerTwoGuess == toGuess)
                {
                    Console.WriteLine("Player two is the winner!");
                }
                else if (guessAttempts <= 0)
                {
                    Console.WriteLine("Player one is the winner!");
                }

                Console.WriteLine("Would you like to play again? Type (y) for yes and (n) for no.");
                arePlaying = Console.ReadKey().KeyChar.ToString().ToLower();
                // remember when done testing to remove return
                // return;
            }
          

            Console.WriteLine("Thanks for playing!");
        }
    }
}
