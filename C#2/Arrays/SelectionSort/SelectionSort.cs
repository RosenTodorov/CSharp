using System;

// Sorting an array means to arrange its elements in increasing order. Write a program to sort 
// an array. Use the "selection sort" algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
namespace SelectionSort
{
    class SelectionSort
    {
        static void Main()
        {
            int[] array = { 1, 8, 4, 5, 32, 6, 3344, 12, 45, 7, 9 };

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ",");
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temporaryVariable = array[j];
                        array[j] = array[i];
                        array[i] = temporaryVariable;
                    }
                }
            }
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ",");
            }
            Console.WriteLine();
        }
    }
}

            
