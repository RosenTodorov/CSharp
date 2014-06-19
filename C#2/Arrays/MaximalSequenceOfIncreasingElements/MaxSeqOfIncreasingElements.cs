using System;


namespace MaximalSequenceOfIncreasingElements
{
    class MaxSeqOfIncreasingElements
    {
        static void Main()
        {
            Console.WriteLine("Please enter your array length");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int arrayLength = array.Length - 1;
            int maxCount = 0;
            int count = 1;
            string sequenceOfNumbers = "";
            string maxSequenceOfNumbers = "";

            for (int i = 0; i < arrayLength; i++)
            {
                if (array[i] < array[i + 1])
                {
                    count++;
                    sequenceOfNumbers += array[i] + "";
                }
                else
                {
                    if (count > maxCount)
                    {
                        maxCount = count;
                        sequenceOfNumbers += array[i] + "";
                        maxSequenceOfNumbers = sequenceOfNumbers;
                    }
                    
                        count = 1;
                        sequenceOfNumbers = "";
                    }
                }
            
                if (count > maxCount)
                {
                    sequenceOfNumbers += array[array.Length - 1];
                    maxSequenceOfNumbers = sequenceOfNumbers;
                }
                Console.WriteLine(maxSequenceOfNumbers);
            }
        }
    }

                       
                

           