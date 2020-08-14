using System;

namespace PropertiesExercise
{
    class Program
    {
        static void Main()
        {
            Money money = new Money();
            money.AUDBalance = 50.0f;
            Console.WriteLine("The US Dollar amount is " + money.USDBalance);
            Console.WriteLine("The Australian Dollar amount is " + money.AUDBalance);
            Console.ReadKey();
        }
    }

    
       
    
}
