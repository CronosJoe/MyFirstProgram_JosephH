using System;
namespace ArrayExercises
{
    public class Question6
    {
        public static void MultiDimensionArray(int one, int two)
        {
            int[,] input = new int[one, two];
            int count = 0;
            //This nested loop puts each value into the array's elements
            for (int i = 0; i < one; i++)
            {
                for (int j = 0; j < two; j++)
                {
                    count++;
                    input[i, j] = count;
                }
            }
            
            for (int i = 0; i < one; i++)
            {
                for (int j = 0; j < two; j++)
                {
                    Console.Write(input[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
