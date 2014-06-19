using System;

/*Extend the program to support also subtraction and multiplication of polynomials. */

namespace SubtractAndMultiplyPolynomials
{
    class SubtractAndMultiplyPolynomials
    {
        static void Main()
        {
            int[] aPolynomial = { 5, 0, 1 };
            int[] bPolynomial = { 5, 0, 1 };

            MultiplyPolynomials(aPolynomial, bPolynomial);
            SubtractPolynomials(aPolynomial, bPolynomial);
        }

        static void MultiplyPolynomials(int[] firstArray, int[] secondArray)
        {
            int biggerLength = 0;
            int smallerLength = 0;

            // bool firstArrayBigger = false;

            if (firstArray.Length >= secondArray.Length)
            {
                biggerLength = firstArray.Length;
                smallerLength = secondArray.Length;
                //  firstArrayBigger = true;
            }
            else
            {
                biggerLength = secondArray.Length;
                smallerLength = firstArray.Length;
            }

            int[] result = new int[biggerLength];

            // if (firstArrayBigger)
            if (firstArray.Length >= secondArray.Length)
            {
                for (int j = 0; j < biggerLength; j++)
                {
                    for (int k = 0; k < smallerLength; k++)
                    {
                        result[j] += firstArray[j] * secondArray[k];
                    }
                }
            }
            else
            {
                for (int j = 0; j < biggerLength; j++)
                {
                    for (int k = 0; k < smallerLength; k++)
                    {
                        result[j] += firstArray[k] * secondArray[j];
                    }
                }
            }
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
            Console.WriteLine();
        }
        static void SubtractPolynomials(int[] firstArray, int[] secondArray)
        {
            int biggerLength = 0;
            int smallerLength = 0;

            // bool firstArrayBigger = false;

            if (firstArray.Length >= secondArray.Length)
            {
                biggerLength = firstArray.Length;
                smallerLength = secondArray.Length;
                //  firstArrayBigger = true;
            }
            else
            {
                biggerLength = secondArray.Length;
                smallerLength = firstArray.Length;
            }

            int[] result = new int[biggerLength];

            // if (firstArrayBigger)
            if (firstArray.Length >= secondArray.Length)
            {
                for (int j = 0; j < biggerLength; j++)
                {
                    for (int k = 0; k < smallerLength; k++)
                    {
                        result[j] += firstArray[j] - secondArray[k];
                    }
                }
            }
            else
            {
                for (int j = 0; j < biggerLength; j++)
                {
                    for (int k = 0; k < smallerLength; k++)
                    {
                        result[j] += firstArray[k] - secondArray[j];
                    }
                }
            }
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
     


 