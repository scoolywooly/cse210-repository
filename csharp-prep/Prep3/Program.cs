using System;
using System.Collections;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {

        string continuePlaying = "stand in value so it doesn't throw an error while i code"; // These variables are used later
        bool loopGame = false;

        do {
        Random rnd = new Random();
        int computerNum = rnd.Next(1, 101);

        Console.WriteLine("The Computer guessed a number between 1 and 100."); // The compbuter guesses a number
        Console.WriteLine("What do you think it is?"); // We ask the user for the first time.
        string playerGuess = Console.ReadLine();
        int guessNum = int.Parse(playerGuess); // Convert the player guess into a number variable.

        int iterations = 0; // This is to make sure we do not ask the user twice the first time the program runs

        do 
        {
            if (iterations > 0) // Since we can't redifen a variable every time the loop runs,\
                                // we just set it to a new value if its run more than once.
            {
                playerGuess = Console.ReadLine();
                guessNum = int.Parse(playerGuess);
            } 
            

            if (guessNum == computerNum) { 

                Console.WriteLine("You did it!");

            } else if (guessNum > computerNum) {

                Console.WriteLine("Lesser.");

            } else if (guessNum < computerNum) {

                Console.WriteLine("Greater.");
            }
            iterations += 1;

        } while (guessNum != computerNum);

        Console.WriteLine("Do you want to play again? ");
        continuePlaying = Console.ReadLine();

        if (continuePlaying.ToLower() == "yes") {
            loopGame = true;
        } else {
            loopGame = false;
        }
        } while (loopGame == true);

       

        
    }
}