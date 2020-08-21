using System;
namespace ArrayExercises
{
    public class Question8
    {
        public static void FiveAttackFight()
        {

            int[] input = new int[5];
            int attackCount = 5;
            Random rand = new Random();
            int damage = 0;
            int selection = 0;
            bool looped = true;
            //This for loop takes sets the health of each character to 100
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = 100;
            }

            //This loop is the attack function
            for (int i = 0; i < attackCount; i++)
            {
                while (looped)
                {
                    Console.WriteLine("Enter a number (1-5) to select which party member is attacked.");
                    selection = Convert.ToInt32(Console.ReadLine()) - 1;
                    damage = rand.Next(10, 30);
                    if (input[selection] <= 0)
                    {
                        input[selection] = 0;
                        Console.WriteLine($"Party member {selection + 1} is dead");
                    }
                    else
                    {
                        Console.WriteLine($"Party member {selection+1} has taken {damage}");
                        input[selection] -= damage;
                        looped = false;
                    }
                }
                looped = true;
            }
            Console.WriteLine($"The battle has ended your hp of each party member is as follows, member 1: {input[0]}, member 2: {input[1]}, member 3: {input[2]}, member 4: {input[3]}, member 5: {input[4]},");
        }
    }
}
