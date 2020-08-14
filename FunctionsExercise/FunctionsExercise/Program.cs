using System;

namespace FunctionsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.score = 100;
            game.Start();
            int count = 0;
            int add = 30;
            while (count < 3) //I didn't like repeating the same function call 3 times so I just put it into a loop and replaced some of the hard coding.
            {
                game.PrintScore(add);
                add += add;
                count++;
            }
           
            
        }
    }
}
