using System;

/*Write a method that return the maximal element in a portion of array of integers starting  
  at given index. Using it write another method that sorts an array in ascending/descending order. */

namespace FindBiggestNumFromGivenIndex
{
    class FindBiggestNumFromGivenIndex
    {
        static void Main()
        {
            int[] array = { 4, 6, 9, 5, 0, 1, 5, 12, 9, 2, 1, 78 };
            Console.Write("Please choose the index for starting: ");
            int index = int.Parse(Console.ReadLine());

            Console.WriteLine("The biggest number is at index: {0}", FindMaxElementInAPortion(array, index));
            Console.WriteLine("Ascending order?");
            bool ascending = bool.Parse(Console.ReadLine());

            array = SortArray(array, ascending);

            Console.WriteLine("The order of new array is: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");            
            }
            Console.WriteLine();
        }     

        static int FindMaxElementInAPortion(int[] array, int index)
        {
            int maxElelement = 0;
            int biggestNumberIndex = 0;

            for (int i = index; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    int bigNumber = array[i];

                    if (bigNumber > maxElelement)
                    {
                        maxElelement = bigNumber;
                        biggestNumberIndex = i;
                    }
                }
                if (array[i] < array[i + 1])
                {
                    int bigNumber = array[i + 1];

                    if (bigNumber > maxElelement)
                    {
                        maxElelement = bigNumber;
                        biggestNumberIndex = i + 1;
                    }
                }
            }
            return biggestNumberIndex;
        }

        static int[] SortArray(int[] array, bool ascending)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int max = FindMaxElementInAPortion(array, i);
                int temp = array[i];
                array[i] = array[max];
                array[max] = temp;
            }
            if (ascending)
            {
                Array.Reverse(array);
            }
            return array;
        }
    }
}

         

                
          
 