using System;

namespace IfStatementsExercise
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool playerAlive = true;
            if (playerAlive)
            {
                Console.WriteLine("You are currently alive.");
            }
            else
            {
                Console.WriteLine("Sadly, you are dead.");
            }
            int invulnerabilityTimer = 2; //I'd prefer to put this at the top
            invulnerabilityTimer--;
            if (invulnerabilityTimer > 0)
            {
                Console.WriteLine("You currently are invulnerable");
                if (playerAlive)
                {
                    invulnerabilityTimer--;
                }
            }else if (invulnerabilityTimer == 0)
            {
                Console.WriteLine("You currently are vulnerable");
            }else if (invulnerabilityTimer < 0)
            {
                invulnerabilityTimer = 0;
            }
        }
    }
}
