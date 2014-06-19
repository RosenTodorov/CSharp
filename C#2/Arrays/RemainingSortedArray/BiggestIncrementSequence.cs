using System;
using System.Collections.Generic;

// Write a program that reads an array of integers and removes from it a minimal number of elements in such 
// way that the remaining array is sorted in increasing  order. Print the remaining sorted array. 
// Example:	{6, 1, 4, 3, 0, 3, 6, 4, 5}  {1, 3, 3, 4, 5}

namespace RemainingSortedArray
{
    class BiggestIncrementSequence
    {
        public static bool isSorted(List<int> array) // Изхождам от факта, че ако искаме да премахнем най-малко елементи от масива,                                                    
        {                                           // то това е същото като да намерим този сортиран подмасив, който съдържа най-много елементи спрямо всички останали сортирани подмасиви.
            bool isSorted = true; //взимам всички възможни подмасиви от зададения ни и го проверявам дали е сортиран.
            for (int i = 0; i < array.Count - 1; i++) //Ако е сортиран, запомням му дължината в една променлива.
            {
                if (array[i] > array[i + 1])
                {
                    isSorted = false;
                }
            }
            return isSorted;
        }

        public static void Main()
        {
            int[] array = { 6, 1, 4, 3, 0, 3, 6, 4, 5 };

            int length = 0;
            int maxLength = 0; //извеждам като резултат най-дългия сортиран подмасив от всички.

            List<int> bestSequensOfNumbers = new List<int>();
            int allCombinations = (1 << array.Length) - 1;

            for (int i = 1; i < allCombinations; i++)
            {
                List<int> sequensOfNumbers = new List<int>();

                for (int j = 0; j < array.Length; j++)
                {
                    if (((i >> j) & 1) == 1)
                    {
                        length++;
                        sequensOfNumbers.Add(array[j]);
                    }
                }

                if (isSorted(sequensOfNumbers))
                {
                    if (length > maxLength)
                    {
                        maxLength = length;
                        bestSequensOfNumbers = sequensOfNumbers;
                    }
                }
                length = 0;
            }

            for (int i = 0; i < bestSequensOfNumbers.Count; i++)
            {
                Console.Write("{0} ", bestSequensOfNumbers[i]);
            }
            Console.WriteLine();
        }
    }
}
			 
			


			 
			
 
			 
			


