using System;

namespace BubbleSortTutorial
{
    class MainClass
    {
         static int swaps;
         static int comparisons;
        public static void Main(string[] args)
        {
            swaps = 0;
            comparisons = 0;
            //Define our data
            int[] arrayToBeSorted = new int[]{
 14,65,63,1,54,
 89,84,9,98,57,
 71,18,21,84,69,
 28,11,83,13,42,
 64,58,78,82,13,
 9,96,14,39,89,
 40,32,51,85,48,
 40,23,15,94,93,
 35,81,1,9,43,
 39,15,17,97,52
 };
            Console.WriteLine("Unsorted");
            printArray(arrayToBeSorted);

            //BubbleSort(arrayToBeSorted);
            // OptimisedBubbleSort(arrayToBeSorted);
            CocktailSort(arrayToBeSorted);
            Console.WriteLine("\nSorted");
            printArray(arrayToBeSorted);
            Console.WriteLine($"swaps:{swaps} comparisons: {comparisons}");
            Console.ReadLine();
        }
        static void printArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0},\t", array[i]);
                if (i % 10 == 9)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        static void BubbleSort(int[] array)
        {
            if (array.Length <= 1)
            {
                return;
            }
            bool sorted = false; //set to false to ensure the while loop starts up
            while (!sorted)
            {
                sorted = true;
                for (int i = 0; i < array.Length - 1; ++i)
                {
                    if (CompareINT(array[i], array[i+1]))
                    {
                        Swap(array, i);
                        sorted = false;
                    }
                   
                }

            }
        }
        static bool CompareINT(int first, int second)
        {
            comparisons++;
            
            return (first > second);
        }
        static void Swap(int[] a,int i )
        {
            swaps++;
            
            int temp = a[i];
            a[i] = a[i + 1];
            a[i + 1] = temp;
             
        }
        static void OptimisedBubbleSort(int[] array)
        {
            if (array.Length <= 1)
            {
                return;
            }
            int number = 1;
            bool sorted = false; //set to false to ensure the while loop starts up
            while (!sorted)
            {
                sorted = true;
                for (int i = 0; i < array.Length - number; i++)
                {
                    if (CompareINT(array[i], array[i + 1]))
                    {
                        Swap(array, i);
                        sorted = false;
                    }

                }
                number++;

            }

        }
        static void CocktailSort(int[] a)
        {
            bool swapped = true;
            int start = 0;
            int end = a.Length;

            while (swapped == true)
            {
                // reset the swapped flag on entering the 
                // loop
                swapped = false;

                // loop from bottom to top
                for (int i = start; i < end - 1; ++i)
                {
                    if (CompareINT(a[i], a[i + 1]))
                    {
                        Swap(a, i);
                       
                    }
                }

             
                if (swapped == true)
                    break;

                
                swapped = false;

                // move the end point back by one
                end -= 1;

                // from top to bottom
                for (int i = end - 1; i >= start; i--)
                {
                    if (CompareINT(a[i], a[i+1]))
                    {
                        Swap(a, i);
                        swapped = true;
                    }
                }
                // increase the starting point
                start = start + 1;
            }
        }
    }
}
