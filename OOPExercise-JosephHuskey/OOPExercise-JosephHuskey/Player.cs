using System;
namespace OOPExercise_JosephHuskey
{
    public class Player : Monster
    {
        public string name;
        public int healthModMin = 75;
        public int healthModMax = 100;
        public int pwrMax = 3;
        public int score = 0;
        public bool isAlive = true;
        public void printCommands()
        {
            Console.WriteLine("Command list: ");
            Console.WriteLine("Quit/q - the quit command or the q command ends the game");
            Console.WriteLine("Help - the help command explains how to play.");
            Console.WriteLine("Command - the Command command gives a list of possible inputs");
            Console.WriteLine("Attack - the attack command attacks the zombie, then tells you how well the attack did.");
            Console.WriteLine("Status - the status command checks your health, and power");
            Console.WriteLine("Heal - the heal command heals you based on your power");
        }
    }
}
