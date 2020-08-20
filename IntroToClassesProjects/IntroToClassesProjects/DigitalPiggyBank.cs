using System;
namespace IntroToClassesProjects
{
    public class DigitalPiggyBank
    {
        // Maintains the current balance of the piggy bank.
        private float currentBalance;
        // Add funds to the value of the current balance.
        public void deposit(float net)
        {
            currentBalance += net;
            Console.WriteLine($"You have deposited {net} dollars. Your new balance is {currentBalance}");
        }
        // Returns and clears the total current balance.
        public float withdraw()
        {
            float withdraw = 0;
            bool value = true;
            withdraw = float.Parse(Console.ReadLine());
            return withdraw;
        }
        // Returns the current balance of the function.
        public float balance()
        {
            return currentBalance;
        }
    }
}
