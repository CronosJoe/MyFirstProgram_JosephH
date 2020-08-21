using System;
namespace ArrayExercises
{
    public class Question9
    {
        public static void DragonTracker()
        {
            int[,] dragons = new int[3, 7];
            //popuates the array
            for(int i =0; i<3; i++)
            {
                for(int j= 0; j<7; j++)
                {
                    Console.WriteLine($"Give an integer value for how much food dragon {i+1} ate on day {j+1}");
                    dragons[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //Creates the report

            //average amount of food eaten each day by all dragons
            int dailyAvg = 0;

            //average amount of food eaten per day by any one dragon
            int drag1 = 0;
            int drag2 = 0;
            int drag3 = 0;

            //greatest amount of food eaten in a day and which dragon that was
            int mostFood = 0;
            int hungryDrag = 0;

            //least amount of food eaten in a day and which dragon that was
            int leastFood = 999;
            int smolDrag = 0;

            //This time I am going through the array by columns because most of the report is done by day.
            for(int i = 0; i<7; i++)
            {
                for(int j =0; j<3; j++)
                {
                    dailyAvg += dragons[j, i];
                    if (j == 1)
                    {
                        drag1 += dragons[j, i];
                    }
                    else if (j == 2)
                    {
                        drag2 += dragons[j, i];
                    }
                    else
                    {
                        drag3 += dragons[j, i];
                    }
                    if(mostFood< dragons[j, i])
                    {
                        mostFood = dragons[j, i];
                        hungryDrag = j;
                    }
                    if(leastFood > dragons[j, i])
                    {
                        leastFood = dragons[j, i];
                        smolDrag = j;
                    }
                }//end of inner loop
            }//end of outer loop (each day)
            dailyAvg /= 7;
            drag1 /= 7;
            drag2 /= 7;
            drag3 /= 7;
            Console.WriteLine($"The daily average of all three dragons together is {dailyAvg}. Dragon 1 averaged {drag1} food a day, Dragon 2 averaged {drag2} food a day, Dragon 3 averaged {drag3} food a day.");
            Console.WriteLine($"The dragon that ate the most was dragon number {hungryDrag+1}, they ate {mostFood} as their highest amount of food.");
            Console.WriteLine($"The dragon that ate the least was dragon number {smolDrag+1}, they ate {leastFood} as their lowest amount of food.");
        }
    }
}
