using System;

namespace Functions
{
    class Program
    {
        static int playerHealth = 100;
        static int monsterDamage = 30;

        static void Main(string[] args)
        {
            Start();
        }
        static void Start()
        {
            Console.WriteLine("The game has started.");
            Console.ReadKey();
            MonsterEncounter();
            MonsterAttacks(monsterDamage*2);
            MonsterAttacks(monsterDamage);
            MonsterAttacks(monsterDamage*3);
        }
        static void MonsterEncounter()
        {
            Console.WriteLine("A vicious monster appears!");
            Console.ReadKey();
        }
        static void MonsterAttacks(int dmg)
        {
            playerHealth -= monsterDamage;
          
            Console.WriteLine($"The monster attacks you for {dmg} points of damage.You have {playerHealth} health left.");

            Console.ReadKey();
        }
    }
}
