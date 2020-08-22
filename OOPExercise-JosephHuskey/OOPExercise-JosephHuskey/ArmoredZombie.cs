using System;
namespace OOPExercise_JosephHuskey
{
    public class ArmoredZombie : BasicZombie
    {
        public int defensePoints;

        // Accepts an attack with the given number of damage points
        public override void TakeDamage(int damagePoints)
        {
            damagePoints -= defensePoints;
            if(damagePoints >= 0)
            {
                damagePoints = 0;
            }
            healthPoints -= damagePoints;

        }
    }
}
