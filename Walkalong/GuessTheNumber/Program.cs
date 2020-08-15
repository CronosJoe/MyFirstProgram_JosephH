using System;
/// <summary>
/// An Unimaginative Guess the number engine
/// Deliberatly dumb.
/// With some deliberate logic
/// </summary>
namespace GuessTheNumber
{
    class Program
    {
        /// <summary>
        /// Main is your programs entrypoint, for most purposes you should
        /// regard it as being the first piece of code in your program that will be executed.
        /// (this is almost 99% true, and is good enough for now.)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            bool win = false;
            bool end = false;
            Random nGenerator = new Random();
            int tries = 1;
            int playScore = 0;
            int compScore = 0;
            char[] separators = { ' ', '/', '.', ',' };
            string input;
            while (end == false)
            {
                //tells the player what they have to do
                #region setup
                Console.WriteLine("GuessTheNumber requires 2 numbers the first is the number of guesses, the second is the max number I pick from.");
                //this is a character array to check the characters in between my string and create a spot where they will split

                input = Console.ReadLine();
                string[] start = input.Split(separators); //this uses the up above separators array to split up the input into the start array



                int numberOfTries = int.Parse(start[0]); //finally this and the next line parse the array into ints so that I can use them for the game
                int ceiling = int.Parse(start[1]);
                

                int myNumber = nGenerator.Next(0,ceiling); //sets the random number

                string playerGuess = "";
                int playerGuessNum = 0;
                Console.WriteLine($"I am thinking of a whole number between 0 and {ceiling}");
                Console.WriteLine($"Can you try and guess it in less than {numberOfTries} tries ?");
                #endregion
                #region game
                for (int i = numberOfTries; i > 0 && playerGuessNum != myNumber; i--)
                {
                    Console.WriteLine("You have " + i.ToString() + " tries left.");
                    Console.WriteLine("Take a guess ?");
                    playerGuess = Console.ReadLine();
                    playerGuessNum = int.Parse(playerGuess);
                    if (playerGuessNum > myNumber)
                    {
                        if (i == 1) { compScore++; }
                        Console.WriteLine("Too High, Try again.");
                    }
                    else if (playerGuessNum < myNumber)
                    {
                        if (i == 1) { compScore++; }
                        Console.WriteLine("Too Low, Try again.");
                    }
                    
                    else
                    {
                        Console.WriteLine($"Well Done. You took {tries} attempts.");
                        playScore++;
                    }
                    tries++;
                }
                Console.WriteLine($"The current score is Player: {playScore} and Computer: {compScore}");
                if(playScore == 2 || compScore == 2)
                {
                    if(playScore == 2)
                    {
                        win = true;
                        end = true;
                    }
                    else
                    {
                        end = true;
                    }
                }
            } //end of the while
            #endregion
            #region wincondition
            if (win)
            {
                Console.WriteLine("it seems you have outsmarted me");
            }
            else if(win == false)
            {
                
                Console.WriteLine("Too bad you didn't guess it, I'm just too smart.");
            }
            #endregion
        }
    }
}
     
