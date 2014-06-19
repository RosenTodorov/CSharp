using System;

// Write a program that finds the maximal sequence of equal elements in an array.
// Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.

namespace MaxSequenceOfEqualElements
{
    class MaxEqualElements
    {
        static void Main()
        {
            Console.WriteLine("Please enter your array length");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int arrayLength = array.Length - 1;
            int nextElement = 1;
            int maxSequence = 1;
            int equalNumbers = 0;
            // check the sequence for equal elements
            for (int i = 0; i < arrayLength; i++)
            {
                if (array[i] == array[i + 1])
                {
                    nextElement += 1;
                    if (nextElement >= maxSequence)
                    {
                        nextElement = maxSequence;
                        equalNumbers = array[i];
                    }
                }
                else if (array[i] != array[i + 1])
                {
                    nextElement = 1;
                }
            }
            // printing of equal elements
            Console.WriteLine("The maximal sequence of equal elements are: {0}", maxSequence);
            for (int i = 0; i < maxSequence; i++)
            {
                Console.WriteLine("The maximal sequence of equal elements in an array is: {0}", equalNumbers);
            }
        }
    }
}