using System;

/*You are given an array of strings. Write a method that sorts the array by the length of its elements 
 * (the number of characters composing them).*/

namespace SortStringArrayByLength
{
    class SortStringArrayByLength
    {
        static void Main()
        {
            Console.Write("Insert number of elements of array N: ");
            int n = int.Parse(Console.ReadLine());
            string[] StringArray = new string[n];

            Console.WriteLine("Insert elements of string array: ");
            for (int i = 0; i < n; i++)
            {
                StringArray[i] = Console.ReadLine();
            }

            Array.Sort(StringArray, (x, y) => (x.Length).CompareTo(y.Length));
            Console.WriteLine("Sorted array is:");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(StringArray[i]);
            }
        }
    }
}
       