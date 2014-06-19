using System;

//Write a program that reads two arrays from the console
//and compares them element by element.

namespace CompareArrays
{
    class CompareArrays
    {
        static void Main()
        {
            Console.Write("Please enter the lenght of the first array: ");
            int lengthFirstArray = int.Parse(Console.ReadLine());
            Console.Write("Please enter the lenght of the second array: ");
            int lengthSecondArray = int.Parse(Console.ReadLine());

            int[] firstArray = new int[lengthFirstArray];
            int[] secondArray = new int[lengthSecondArray];

            for (int i = 0; i < lengthFirstArray; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < lengthSecondArray; i++)
            {
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            bool isEqual = true;

            if (lengthFirstArray == lengthSecondArray)
            {
                for (int i = 0; i < lengthFirstArray; i++)
                {
                    if (firstArray[i] != secondArray[i])
                    {
                        isEqual = false;
                        break;
                    }
                }
            }
            else
            {
                isEqual = false;
            }
            Console.WriteLine("The two arrays are equal: {0}", isEqual);
        }  
    }
}

