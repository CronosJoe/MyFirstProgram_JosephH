using System;
namespace ArrayExercises
{
    public class Question4
    {
        public static void PrintInReverse(int arrayElmNmbs)
        {
            //this will initilize the array with the given amount of elements entered.
            int[] input = new int[arrayElmNmbs];
            //this for loop will populate the array
            for(int i = 0; i < input.Length; i++)
            {
                Console.WriteLine("input a nondecimal integer");
                input[i] = Convert.ToInt32(Console.ReadLine());
            }
            //this for loop will print the array from back to front
            for (int i = input.Length; i > 0; i--)
            {
                Console.WriteLine(input[i-1]);
            }

        }
    }
}
