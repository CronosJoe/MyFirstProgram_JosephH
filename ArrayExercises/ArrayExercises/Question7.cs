using System;
namespace ArrayExercises
{
    public class Question7
    {
        public static void summedRowCol()
        {
            int one = 27;
            int two = 5;
            int[,] input = new int[27, 5]
            {
                {1, 2, 3, 4, 5 },
                {1, 2, 3, 4, 5 },
                {1, 2, 3, 4, 5 },
                 {1, 2, 3, 4, 5 },
                 {1, 2, 3, 4, 5 },
                 {1, 2, 3, 4, 5 },
                 {1, 2, 3, 4, 5 },
                 {1, 2, 3, 4, 5 },
                 {1, 2, 3, 4, 5 },
                 {1, 2, 3, 4, 5 },
                 {1, 2, 3, 4, 5 },
                 {1, 2, 3, 4, 5 },
                 {1, 2, 3, 4, 5 },
                 {1, 2, 3, 4, 5 },
                 {1, 2, 3, 4, 5 },
                 {1, 2, 3, 4, 5 },
                 {1, 2, 3, 4, 5 },
                 {1, 2, 3, 4, 5 },
                 {1, 2, 3, 4, 5 },
                 {1, 2, 3, 4, 5 },
                 {1, 2, 3, 4, 5 },
                 {1, 2, 3, 4, 5 },
                 {1, 2, 3, 4, 5 },
                 {1, 2, 3, 4, 5 },
                 {1, 2, 3, 4, 5 },
                 {1, 2, 3, 4, 5 },
                 {1, 2, 3, 4, 5 }
            };

            int rowSum = 0;
            int colSum = 0;
            //goes through the 2d array adding up each row
            for (int i = 0; i < one; i++)
            {
                for (int j = 0; j < two; j++)
                {
                    rowSum += input[i, j];

                }

                Console.WriteLine($"the sum of row number {i} is: {rowSum}");
                rowSum = 0;
            }
            //Goes through the 2d array adding up each column
            for (int i = 0; i < two; i++)
            {
                for (int j = 0; j < one; j++)
                {
                    colSum += input[j,i];
                
                }
                Console.WriteLine($"the sum of col number {i} is: {colSum}");
                colSum = 0;
            }

        }
    }
}
