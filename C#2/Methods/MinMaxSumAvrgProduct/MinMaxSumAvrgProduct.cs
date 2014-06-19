using System;

/*Write methods to calculate minimum, maximum, average, sum and product of given set of 
  integer numbers. Use variable number of arguments.*/

namespace MinMaxSumAvrgProduct
{
    class MinMaxSumAvrgProduct
    {
        static void Main()
        {
            int[] array = { 8, 4, -7, 2, 9, -12, 56, -1 };
            Console.WriteLine("Minimal element is: {0}", Minimum(array));
            Console.WriteLine("Maximal element is: {0}", ReturnMaximal(array));
            Console.WriteLine("The sum of elements is: {0}", SumElementsInArray(array));
            Console.WriteLine("The product of elements is: {0}", ProductOfIntegers(array));
            Console.WriteLine("Average is: {0:F3}", AverageElement(array));
        }

        static int Minimum(int[] array)
        {
            int minimal = int.MaxValue;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    if (array[i] < minimal)
                    {
                        minimal = array[i];
                    }
                }
                if (array[i] > array[i + 1])
                {
                    if (array[i + 1] < minimal)
                    {
                        minimal = array[i + 1];
                    }
                }
            }
            return minimal;
        }

        static int ReturnMaximal(int[] array) // second way za izrazqvane na max i min stoinosti
        {
            int maximal = int.MinValue;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    if (array[i] > maximal) maximal = array[i];
                }
                if (array[i] < array[i + 1])
                {
                    if (array[i + 1] > maximal) maximal = array[i + 1];
                }
            }
            return maximal;
        }

        static int SumElementsInArray(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        static int ProductOfIntegers(int[] array)
        {
            int product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }
            return product;
        }
        static decimal AverageElement(int[] array)
        {         
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            decimal average = (decimal)sum / array.Length;
            return average;
        }
    }
}


 
    