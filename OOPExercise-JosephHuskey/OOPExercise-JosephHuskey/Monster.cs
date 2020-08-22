using System;
namespace OOPExercise_JosephHuskey
{
    public class Monster
    {
        public int maxHealthPoints;
        public int healthPoints;
        public int power;
       
      
        // Accepts an attack with the given number of damage points
        public virtual void TakeDamage(int damagePoints)
        {
           
            healthPoints -= damagePoints;
        }

        // Returns the damage points dealt by this attack
        public int Attack(int power)
        {
            Random rand = new Random();
            int damage = rand.Next(1, 10);
            if (damage == 1)
            {
                Console.WriteLine("The attack barely hit, only 1 damage was dealt.");
            }
            else
            {
                damage += power;
                Console.WriteLine($"The attack did {damage} points of damage");
            }
            return damage;
        }

        public bool IsDefeated
        {
            get
            {
                if (healthPoints <= 0)
                {
                    healthPoints = 0;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

    }
}
