using System;
/*Write a method that adds two positive integer numbers represented as arrays of digits 
 * (each array element arr[i] contains a digit; the last digit is kept in arr[0]). Each of the numbers that will be added  
 * could have up to 10 000 digits.*/
namespace SumDigitsOfArray
{
    class SumDigitsOfArray
    {
        static void Main()
        {
            int[] firstArray = { 3, 4, 5, 7, 8, 9, 8, 4, 7 };
            int[] secondArray = { 1, 7, 9, 0, 2, 5, 4 };

            AddingDigits(firstArray, secondArray);
        }
        static void AddingDigits(int[] arrayOne, int[] arrayTwo)
        {
            int length = 1;
            if (arrayOne.Length > arrayTwo.Length)
            {
                length += arrayOne.Length;
            }
            if (arrayTwo.Length > arrayOne.Length)
            {
                length += arrayTwo.Length;
            }

            int[] result = new int[length];
            for (int index = 0; index < length; index++)
            {
                if (index < arrayOne.Length)
                {
                    result[index] += arrayOne[index];

                    if (result[index] >= 10)
                    {
                        result[index] -= 10;
                        result[index + 1] += 1;
                    }
                }
                if (index < arrayTwo.Length)
                {
                    result[index] += arrayTwo[index];
                    if (result[index] >= 10)
                    {
                        result[index] -= 10;
                        result[index + 1] += 1;
                    }
                }
            }
            Array.Reverse(result);
            PrintArray(result);
        }
        private static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i != 0)
                {
                    Console.Write(array[i] + " ");
                }
                if (i == 0 && array[i] == 0)
                {
                    continue;
                }
            }
            Console.WriteLine();
        }
    }
}
        
/* class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            byte[] firstArray = { 9, 4, 1, 9 };
            byte[] secondArray = { 1, 5, 6, 7, 9, 9, 9 };

            string total = SumArrays(firstArray, secondArray);
            Console.WriteLine(total);
            DateTime final = DateTime.Now;
            Console.WriteLine("{0}", final - start);

        }

        private static string SumArrays(byte[] firstArray, byte[] secondArray)
        {
            List<byte> maxArray = new List<byte>();
            List<byte> minArray = new List<byte>();
            if (firstArray.Length>secondArray.Length)
            {
                maxArray.AddRange(firstArray);
                minArray.AddRange(secondArray);
            }
            else
            {
                maxArray.AddRange(secondArray);
                minArray.AddRange(firstArray);
            }

            int minLength = minArray.Count;
            int maxLength = maxArray.Count;
            int addition = 0;
            int sum;
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < minLength; i++)
            {
                sum = minArray[i] + maxArray[i] + addition;
                if (sum>=10)
                {
                    addition = 1;
                    sum = sum % 10;
                    result.Append(sum);
                }
                else
                {
                    result.Append(sum);
                    addition = 0;
                }
            }

            for (int j = minLength; j < maxLength; j++)
            {
                sum =maxArray[j] + addition;
                if (sum >= 10)
                {
                    addition = 1;
                    sum = sum % 10;
                    result.Append(sum);
                }
                else
                {
                    result.Append(sum);
                    addition = 0;
                }
            }
            if (addition==1)
            {
                result.Append(1);
            }
            char[] reversed = (result.ToString()).ToCharArray();
            result.Clear();
            for (int i = reversed.Length-1; i >=0; i--)
            {
                result = result.Append(reversed[i]);
            }
            return result.ToString();
        }
    }
} */