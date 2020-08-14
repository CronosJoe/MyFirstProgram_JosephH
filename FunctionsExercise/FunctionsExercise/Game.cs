using System;
namespace FunctionsExercise
{
    public class Game
    {
      public int score;


        public void Start()
        {
            Console.WriteLine($"Player Score is {score}.");
            

        }
        public int AddToScore(int add)
        {
            score += add;
            return score;
        }
        public void PrintScore(int data)
        {
            Console.WriteLine($"You have scored {data} points! Your new score is {AddToScore(data)}!");
        }
    }
    
    
}
