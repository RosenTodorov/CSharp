using System;
// We are given an array of integers and a number S. Write a program to find if 
// there exists a subset of the elements of the array that has a sum S.

namespace SubsetSum
{
    class SubsetSum
    {
        static void Main()
        {
            int[] array = { 2, 1, 2, 4, 3, 5, 2, 6 };
            int arrayLength = array.Length;

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Enter the desired sum: ");
            int s = int.Parse(Console.ReadLine());

            int sum = 0;
            int count = 0;
            string elements = string.Empty;

            int allCombinations = (1 << arrayLength) - 1;
            for (int i = 1; i <= allCombinations; i++)
            {
                sum = 0;
                elements = "";

                for (int j = 0; j < arrayLength; j++)
                {
                    if (((i >> j) & 1) == 1)
                    {
                        sum = sum + array[j];
                        elements = elements + "+" + array[j];
                    }
                }
                if (sum == s)
                {
                    count++;
                    elements = elements.TrimStart('+');
                    Console.WriteLine("( {0} )", elements);
                }
            }
            if (count == 0)
            {
                Console.WriteLine("There is no numbers, forming that sum!");
            }
        }
    }
}
			
              
     