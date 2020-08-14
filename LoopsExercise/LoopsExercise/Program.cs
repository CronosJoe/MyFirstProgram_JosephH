using System;

namespace LoopsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            int score = 0;
            while (count <= 10)
            {
                Console.WriteLine($"This while loop is on the {count} repeat. ");
                count++;
            }
            count = 1;
            for (; count <= 20; count++)
            {
                if (score < 100)
                {
                    score += 20;
                    Console.WriteLine($"Score is equal to {score}.");
                }
                else if (score == 100)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("If you get here you messed up your score number Joseph.");
                }
                Console.WriteLine($"This for loop is on the {count} repeat");
               
            }
        }
    }
}
