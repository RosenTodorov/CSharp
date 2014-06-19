using System;

// Write a program that finds the most frequent number in an array. 
// Example:	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

namespace MostFrequentElement
{
    class MostFrequentElement
    {
        static void Main()
        {
            int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

            int mostFrequentnumber = 0;
            int count = 0;
            int maxCount = 0;

            for (int i = 0; i < array.Length; i++)
            {
                count = 0;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                    }
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    mostFrequentnumber = array[i];
                }
            }
            Console.WriteLine("The most frequent number is: {0}", mostFrequentnumber);
            Console.WriteLine("Times: {0}", maxCount);
        }
    }
}

