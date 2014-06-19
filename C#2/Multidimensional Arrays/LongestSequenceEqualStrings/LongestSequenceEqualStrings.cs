using System;

/*We are given a matrix of strings of size N x M. 
 * Sequences in the matrix we define as sets of  
 * several neighbor elements located on the same  
 * line, column or diagonal. Write a program that 
 * finds the longest sequence of equal strings  
 * in the matrix. */

namespace LongestSequenceEqualStrings
{
    class LongestSequenceEqualStrings
    {
        static void Main()
        {
            //Console.Write("n = ");        
            //int n = int.Parse(Console.ReadLine());        
            //Console.Write("m = ");        
            //int m = int.Parse(Console.ReadLine());        
            //string[,] matrix = { { "ha", "fifi", "ho", "hi" }, {"fo", "ha", "hi", "xx"}, {"xxx", "ho", "ha", "xx"}};        

            string[,] matrix = { { "d", "qq", "d" }, { "pk", "pk", "d" }, { "pk", "qq", "d" } };

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,6}", matrix[i, j]);
                }
                Console.WriteLine();
            }
            string sequence = "";
            string longestSequence = "";
            int length = 1;
            int biggestLength = 1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                length = 1;
                sequence = "";

                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1])
                    {
                        sequence = matrix[row, col];
                        length++;
                    }
                }
                if (biggestLength < length)
                {
                    biggestLength = length;
                    longestSequence = sequence;
                }
            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                length = 1;

                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    if (matrix[row, col] == matrix[row + 1, col])
                    {
                        sequence = matrix[row, col];
                        length++;
                    }
                }
                if (biggestLength < length)
                {
                    biggestLength = length;
                    longestSequence = sequence;
                }
            }

            length = 1;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (row == col)
                    {
                        if (matrix[row, col] == matrix[row + 1, col + 1])
                        {
                            sequence = matrix[row, col];
                            length++;
                        }
                    }
                }
                if (biggestLength < length)
                {
                    biggestLength = length;
                    longestSequence = sequence;
                }
            }
            for (int i = 0; i < biggestLength; i++)
            {
                Console.Write("{0} ", longestSequence);
            } 
            Console.WriteLine();
        }
    }
}


