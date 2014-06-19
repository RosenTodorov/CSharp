using System;

// Write a program that finds the index of given element in a sorted array of integers by using the binary search 
// algorithm (find it in Wikipedia).


class BinarySearchFindElement
{
    static int BinarySearch(int[] array, int key)
    {
        int min = 0;
        int max = array.Length - 1;
        // continue searching while [min, max] is not empty
        while (max >= min)
        {
            /* calculate the midpoint */
            int mid = (max + min) / 2;

            // determine which subarray to search
            if (array[mid] < key)
                // change min index to search upper subarray
                min = mid + 1;
            else if (array[mid] > key)
                // change max index to search lower subarray
                max = mid - 1;
            else
                // key found at index mid
                return mid;
        }
        // key not found
        return -1;
    }


    static void Main()
    {
        int[] array = { -10, -8, -3, 0, 1, 1, 2, 3, 5, 10, 10, 25, 26, 30, 31, 33, 38, 40 };
        int number = 26;
        // int number = 34;  // Return that the number is not found

        if (BinarySearch(array, number) == -1)
        {
            Console.WriteLine("The searching number \"{0}\" is not found in the array!", number);
        }
        else
        {
            Console.WriteLine("The index of number is: " + BinarySearch(array, number));
        }
    }
}