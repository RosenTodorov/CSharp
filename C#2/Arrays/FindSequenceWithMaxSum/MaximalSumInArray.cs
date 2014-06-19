using System;

// Write a program that finds the sequence of maximal sum in given array.
//Example:	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}

namespace FindSequenceWithMaxSum
{
    class MaximalSumInArray
    {
        static void Main()
        {
            int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

            Console.Write("The elements of your array is: ");
            
            int sum = 0;
            int maxSum = 0;
            string elements = string.Empty;
            string maxElements = string.Empty;

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ",");
                sum = sum + array[i];
                elements = elements + " " + array[i];

                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxElements = elements;
                }

                if (sum < 0)
                {
                    sum = 0;
                    elements = string.Empty;
                }
            }
            Console.WriteLine();
            Console.WriteLine("The maximal sum is: {0}", maxSum);
            Console.WriteLine("The elements are: {0}", maxElements);
        }
    }
}
