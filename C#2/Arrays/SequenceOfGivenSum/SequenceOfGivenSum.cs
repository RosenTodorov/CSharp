using System;

// Write a program that finds in given array of integers a sequence of given sum S (if present).    
// Example: {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}	

namespace SequenceOfGivenSum
{
    class SequenceOfGivenSum
    {
        static void Main()
        {
            int[] array = { 4, 3, 1, 4, 2, 5, 8 };
            Console.Write("Enter the desired sum: ");
            int s = int.Parse(Console.ReadLine());
            int count = 0;
            int sum = 0;
            string elements = string.Empty;

            for (int i = 0; i < array.Length; i++)
            {
                sum = 0;
                for (int j = i; j < array.Length; j++)
                {
                    sum = sum + array[j];
                    elements = elements + "+" + array[j];

                    if (sum == s)
                    {
                        elements = elements.TrimStart('+');
                        Console.WriteLine("The elements for your desired sum are: {0}", elements);
                        count++;     
                        sum = 0;
                        elements = string.Empty;
                    }
                    if (sum > s)
                    {                      
                        elements = string.Empty;
                        sum = 0;
                        break;
                    }
                }
            }
                if (count == 0)
                {
                    Console.WriteLine("There is no numbers, forming that sum!");
                }
            }
        }
    }


