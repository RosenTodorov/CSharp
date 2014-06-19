using System;

//Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).

namespace MergeSortAlgorithm
{
    class MergeSortAlgorithm
    {
        static void MergeSort(int[] a, int length)
        {
            int count = length;

            if (count == 2)
            {
                int temporary;
                if (a[0] > a[1])
                {
                    temporary = a[0];
                    a[0] = a[1];
                    a[1] = temporary;
                }
            }
            else if (count > 2)
            {
                count = length / 2;
                int[] left = new int[count];
                int[] right = new int[count + 1];

                for (int i = 0; i < count; i++)
                {
                    left[i] = a[i];
                }
                for (int i = count; i < length; i++)
                {
                    right[i - count] = a[i];
                }
                MergeSort(left, count);
                MergeSort(right, length - count);

                int first = 0;     // Sled kato bade napravena razmqnata na elementite zapo4va popalvane na masiva
                int second = 0;
                for (int k = 0; k < length; k++)
                {
                    if (first < count && second <= count && left[first] <= right[second])
                    {
                        a[k] = left[first];
                        first++;
                    }
                    else
                    {
                        a[k] = right[second];
                        second++;
                    }
                }
            }
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            MergeSort(array, n);
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i]);
            }
        }
    }
}


    
        
 

 


        
    





                   
			 
			

			
			 
			

