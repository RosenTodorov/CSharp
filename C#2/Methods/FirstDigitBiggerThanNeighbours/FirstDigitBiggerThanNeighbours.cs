using System;

/*Write a method that returns the index of the first element in array that is 
 * bigger than its neighbors, or -1, if there’s no such element. */

namespace FirstDigitBiggerThanNeighbours
{
    class FirstBiggerThanNeighbours
    {
        static void Main()
        {
            int[] array = new int[] { 1, 3, 6, 8, 9, 74, 23, 5, 0, 32, 8, 9, 12 };

            Console.WriteLine(FirstDigitBiggerThanNeighbours(array));
        }

        static int FirstDigitBiggerThanNeighbours(int[] array)
        {
            int index = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
    }
}





    