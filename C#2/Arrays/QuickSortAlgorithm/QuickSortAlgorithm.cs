using System;

// Write a program that sorts an array of strings using the quick sort algorithm.

namespace QuickSortAlgorithm
{
    class QuickSortAlgorithm
    {
        static void Main()
        {
            // creation and print of unsorted array
            Console.Write("Please put the numbers in the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] unsortedArray = new int[n];
            Random randomGenerator = new Random();

            for (int i = 0; i < unsortedArray.Length; i++)
            {
                unsortedArray[i] = randomGenerator.Next(-100, 100);
            }

            for (int i = 0; i < unsortedArray.Length; i++)
            {
                Console.Write(" {0}", unsortedArray[i]);
            }
            Console.WriteLine();

            // sorting the array, using the Quick sort algorithm
            QuickSortMethod(unsortedArray, 0, unsortedArray.Length - 1);

            // print the new sorted algorithm
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                Console.Write(" {0}", unsortedArray[i]);
            }
            Console.WriteLine();
        }

        // quicksort method
        public static void QuickSortMethod(int[] numbers, int left, int right)
        {
            int i = left;
            int j = right;
            int pivot = numbers[(left + right) / 2];

            while (i <= j)
            {
                while (numbers[i].CompareTo(pivot) < 0)
                {
                    i++;
                }
                while (numbers[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    int temporary = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temporary;

                    i++;
                    j--;
                }

                // recursive call
                if (left < j)
                {
                    QuickSortMethod(numbers, left, j);
                }

                if (i < right)
                {
                    QuickSortMethod(numbers, i, right);
                }
            }
        }
    }
} 


			 
