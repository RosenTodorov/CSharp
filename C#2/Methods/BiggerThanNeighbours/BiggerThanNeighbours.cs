using System;

/*Write a method that checks if the element at given position in given array of integers is 
 * bigger than its two neighbors (when such exist).*/

namespace BiggerThanNeighbours
{
    class BiggerThanNeighbours
    {
        static void Main()
        {
            int[] array = new int[] { 5, 3, 6, 9, 10, 75, 8, 0, 23, 14, 1, 9, 8, 2, 44 };

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Please enter your index to compare with the neighbours: ");
            int index = int.Parse(Console.ReadLine());

            BiggerThanItsNeighbours(array, index);
        }
        static bool BiggerThanItsNeighbours(int[] array, int numberIndex)
        {
            if (numberIndex - 1 >= 0 && numberIndex + 1 < array.Length)
            {
                if (array[numberIndex] > array[numberIndex - 1] && array[numberIndex] > array[numberIndex + 1])
                {
                    Console.WriteLine("The number {0} is bigger than its neighbours", array[numberIndex]);
                    return true;
                }
            }
            else if (numberIndex - 1 >= 0 && numberIndex + 1 >= array.Length)
            {
                if (array[numberIndex] > array[numberIndex - 1])
                {
                    Console.WriteLine("The number {0} is bigger than its neighbour", array[numberIndex]);
                    return true;
                }
            }
            else if (numberIndex - 1 < 0 && numberIndex + 1 < array.Length)
            {
                if (array[numberIndex] > numberIndex + 1)
                {
                    Console.WriteLine("The number {0} is bigger than its neighbour", array[numberIndex]);
                    return true;
                }
            }
            Console.WriteLine("The number {0} is not bigger than its neighbour/s", array[numberIndex]);
            return false;
        }
    }
}

    

       
            

