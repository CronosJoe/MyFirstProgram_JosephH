using System;

namespace AIEDay2Variables
{
    class Program
    {
        static void Main()
        {
            string greeting = "Hello AIE Day 2!";
            int playerScore = 0;
            bool gameStart = false;
            Console.WriteLine(greeting + " Your Score is: " + playerScore);
            Console.ReadLine();

            string displayScore = " Your current Score is: " + playerScore + "."; /* note to self, this variable is saved now if playerScore changes after this this will not change */
            Console.WriteLine(displayScore);


            //bools
            bool booleanOne = true;
            bool booleanTwo = false;
            bool result = booleanOne && booleanTwo;
            result = booleanOne || booleanTwo;
            result = !booleanTwo;
            
        }
    }
}
