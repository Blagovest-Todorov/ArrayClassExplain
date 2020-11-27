using System;

namespace _10.ArrayTuition
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 8, 1, 8, 2, 8, 6 };
            // Task -> To print all indexex i n a given array of the given number 8;
            int startIndex = 0;
            while (true)
            {
                int currentIndex = Array.IndexOf(numbers, 8, startIndex);
                //find in Array with name IndexOf,  all the numbers 8, on which indexes are they, //
                //starting to iterato from index =0 ;
                if (currentIndex < 0)
                {
                    break;
                }
                Console.WriteLine(currentIndex);
                startIndex = currentIndex + 1; //We move onto check for another numbers  of 8,
                // to find the index of those;

            }

        }


    }
}
