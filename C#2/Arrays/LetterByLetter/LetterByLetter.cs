using System;

//Write a program that compares two char arrays lexicographically (letter by letter).

namespace LetterByLetter
{
    class LetterByLetter
    {
        static void Main()
        {
            Console.WriteLine("Please enter the first char:");
            string firstChar = Console.ReadLine();
            char[] firstArray = firstChar.ToCharArray(); // convert string to char array
            int firstArrayLength = firstArray.Length;

            Console.WriteLine("Please enter the second char elements:");
            string secondChar = Console.ReadLine();
            char[] secondArray = secondChar.ToCharArray();
            int secondArrayLength = secondArray.Length;

            int minLen = Math.Min(secondArrayLength, firstArrayLength); //gets min length of the two arrays

            bool equalCharArrays = true;

            for (int i = 0; i < minLen; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    continue;
                }
                else
                {
                    equalCharArrays = false;
                    if (firstArray[i] < secondArray[i])
                    {
                        Console.WriteLine("The first char array is lexicografically before the second one");
                    }
                    else
                    {
                        Console.WriteLine("The second char array is lexicografically before the first one");
                    }
                    break;
                }
            }
            if (equalCharArrays = true && firstArrayLength < secondArrayLength)
            {
                Console.WriteLine("The first char array is lexicografically before the second one");
            }
            else if (equalCharArrays = true && firstArrayLength > secondArrayLength)
            {
                Console.WriteLine("The second char array is lexicografically before the first one");
            }
            else if (equalCharArrays = true && firstArrayLength == secondArrayLength)
            {
                Console.WriteLine("The arrays are equal.");            
            }
        }
    }
}
