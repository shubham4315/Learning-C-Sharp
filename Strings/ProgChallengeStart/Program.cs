using System;

namespace ProgChallengeStart
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choose a random number between 0 and 20
            int theNumber = new Random().Next(20);

            // Print the game greeting and instructions
            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine("I'm thinking of a number between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to give up.");

            int guessCount = 0;

            int guess = -1;
            bool succeeded = false;
            
            succeeded = Int32.TryParse(Console.ReadLine(), out guess);
            do{
                if(succeeded){
                    if (guess > theNumber)
                    {
                        Console.WriteLine("Nope, Lower than that");
                    }
                    else if (guess < theNumber)
                    {
                        Console.WriteLine("Nope, Higher than that");
                    }
                }
                else{
                    Console.WriteLine("Opps, try a number");
                }
                guessCount++;
                succeeded = Int32.TryParse(Console.ReadLine(), out guess);

            }while(guess != theNumber);

            Console.WriteLine($"You took {guessCount} tries");

            // Keep track of the number of guesses and the current user guess

            // Start the game and run until user quits or guesses correctly
            // HINT: You'll need a way to convert the user's input to an integer
            
        }
    }
}
