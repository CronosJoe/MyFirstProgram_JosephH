using System;
namespace ArrayExercises
{
    public class Question5
    {
       public static void BigAndSmallValues(int size)
        {
            int[] input = new int[size];
            

            //This for loop takes in inputs till the array is full
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine("input a nondecimal integer");
                input[i] = Convert.ToInt32(Console.ReadLine());
            }
            //I am initilizing the values here now that the array is populated for good starting numbers
            int largest = input[0];
            int smallest = input[0];
            //This array will check all the values in the array to try and find the smallest and largest ones
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > largest)
                {
                    largest = input[i];
                }
                if (input[i] < smallest)
                {
                    smallest = input[i];
                }
            }
            //finally this prints the values
            Console.WriteLine($"The largest value in the array is {largest} and the smallest value in the array is {smallest}");

        }
    }
}
