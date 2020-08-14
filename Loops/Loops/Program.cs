using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // WhileLoops();
            ForLoops();
            Console.ReadKey();
        }
        static void WhileLoops()
        {
            int count = 0;
            while (count < 3)
            {
                count++;
                Console.WriteLine("The while loop has run " + count + " times."); //alternate solution is to put $ in front and putting brackets around the variable
            }
        }
        static void ForLoops()
        {
            for (int count = 3; count >=1; count-=2)
            {
                Console.WriteLine($"The variable count now is equal to {count}.");
                if (count == 2)
                {
                    break;
                }
            }
        }
    }
}
