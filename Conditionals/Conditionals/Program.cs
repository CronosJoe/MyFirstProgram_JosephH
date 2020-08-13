using System;

namespace Conditionals
{
    class MainClass
    {
        public static void Main()
        {
           // ConditionalMonster();
           // Combos();
            Console.ReadKey();
        }
        public static void Combos()
        {
            int score = 0;
            int combo = 1;
            int pointValue = 100;
            bool gameStarted = false;
            if (score == 0)
            {
                gameStarted = true;
                if (gameStarted)
                {
                    score = combo * pointValue;
                    combo++;
                    Console.WriteLine("You got a combo! Your new score is: " + score);
                    Console.ReadKey();
                }
            }
        }
        public static void ConditionalMonster()
        {
            int playerHealth = 100;
            int monsterDmg = 140;
            playerHealth -= monsterDmg;
            if (playerHealth < 0)
            {
                playerHealth = 0;
            }
            Console.WriteLine($"A monster attacked you and did {monsterDmg} damage. You have {playerHealth} health left!");

            if (playerHealth == 0)
            {
                Console.WriteLine("Game Over");
            }
            else if (playerHealth > 0)
            {
                Console.WriteLine("The monster prepares to attack you again");
            }
            Console.ReadKey();
        }
    }
}
