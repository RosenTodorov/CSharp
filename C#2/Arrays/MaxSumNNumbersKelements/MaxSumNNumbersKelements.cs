using System;
/*Write a program that reads two integer numbers N and K and an array 
    of N elements from the console. Find in the array those K elements that have maximal sum.*/

namespace MaxSumNNumbersKelements
{
    class MaxSumNNumbersKelements
    {
        static void Main()
        {
            Console.WriteLine("Write the length of the array - N:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Write K:");
            int k = int.Parse(Console.ReadLine());

            if (n >= k)
            {
                Console.WriteLine("Write the elements of the array:");
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }

                int start = 0;
                int sum = 0;
                int bestSum = 0;
                int end = k;
                int bestEnd = 1;
                for (int i = 0; i <= arr.Length - k; i++)
                {

                    for (int j = i; j < end; j++)
                    {
                        sum += arr[j];
                    }
                    if (bestSum < sum)
                    {
                        bestSum = sum;
                        start = i;
                        sum = 0;
                        bestEnd = i + k;
                    }
                    else
                    {
                        sum = 0;
                    }
                    end++;
                }
                for (int i = start; i < bestEnd; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            else
            {
                Console.WriteLine("N must be greater or equal to K");
            }
        }
    }
}

        