using System;

//Write a program that reads three integer numbers N, K and S and an array of N 
//elements from the console. Find in the array a subset of K elements that have 
//sum S or indicate about its absence.

namespace SubsetOfElements
{
    class SubsetOfKElements
    {
        static void Main()
        {

            Console.Write("Please enter the length of the array: ");
            int n = int.Parse(Console.ReadLine());

            Random generator = new Random();
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = generator.Next(-4, 12);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Enter how many elements want to sum: ");
            int k = int.Parse(Console.ReadLine());

            Console.Write("Enter the desired sum: ");
            int s = int.Parse(Console.ReadLine());

            int allCombinations = ((1 << n) - 1);
            int sum = 0;
            string elements = "";
            int count = 0;
            int minCount = 0;

            for (int i = 1; i <= allCombinations; i++)
            {
                sum = 0;
                elements = "";
                count = 0;

                for (int j = 0; j < n; j++)
                {
                    if (((i >> j) & 1) == 1)
                    {
                        sum = sum + array[j];
                        elements = elements + "+" + array[j];
                        count++;
                    }
                }

                if (sum == s && count == k)
                {
                    minCount++;
                    elements = elements.TrimStart('+');
                    Console.WriteLine("({0} )", elements);
                }
            }

            if (minCount == 0)
            {
                Console.WriteLine("There is no numbers, forming that sum!");
            }
        }
    }
}

