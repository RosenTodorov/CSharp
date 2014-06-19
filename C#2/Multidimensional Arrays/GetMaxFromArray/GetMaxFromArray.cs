﻿using System;

/*Write a program, that reads from the console 
 * an array of N integers and an integer K, sorts  
 * the array and using the method Array. 
 * BinSearch() finds the largest number in the array which is ≤ K. */

namespace GetMaxFromArray
{
    class GetMaxFromArray
    {
        static void Main()
        {
            Console.Write("Input N: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Input K: ");
            int K = int.Parse(Console.ReadLine());

            int[] arrayOfIntegers = new int[N];
            Random randomGenerator = new Random();

            for (int i = 0; i < N; i++)
            {
                arrayOfIntegers[i] = randomGenerator.Next(1, 101);
            }
            Array.Sort(arrayOfIntegers);

            for (int i = 0; i < N; i++)
            {
                Console.Write("{0} ", arrayOfIntegers[i]);
            }
            Console.WriteLine();

            int myIndex = Array.BinarySearch(arrayOfIntegers, K);
            if (myIndex < 0)
            {
                if (~myIndex > 0)
                {
                    Console.WriteLine("The object to search for ({0}) is not found. The previous smaller object is ({1}) at index {2}.",
                        K, arrayOfIntegers[(~myIndex) - 1], (~myIndex) - 1);
                }
                else
                {
                    Console.WriteLine("There is no value, smaller than ({0})", K);
                     
                }
            }
            else
            {
                Console.WriteLine("The object to search for ({0}) is at index {1}.", K, myIndex);
            }
        }
    }
}


 