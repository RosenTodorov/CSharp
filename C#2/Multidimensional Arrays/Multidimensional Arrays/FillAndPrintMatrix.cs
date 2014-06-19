using System;

//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)

namespace FillPrintMatrix
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please enter the matix size: ");
            string input = Console.ReadLine();
            int N;
            int digit = 1;

            while (int.TryParse(input, out N) == false)
            {
                Console.Write("Please enter a valid integer: ");
                input = Console.ReadLine();
            }
            int[,] matrix = new int[N, N];
            Console.WriteLine();

            // A
            // full in the matrix
            for (int col = 0; col < N; col++)
            {
                for (int row = 0; row < N; row++)
                {
                    matrix[row, col] = digit;
                    digit++;
                }
            }

            // print the matrix
            Console.WriteLine("This is variant A:");
            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    Console.Write("{0,3}", matrix[row, col]);
                }
                Console.WriteLine();
            }
            digit = 1;
            Console.WriteLine();

            // B
            for (int col = 0; col < N; col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < N; row++)
                    {
                        matrix[row, col] = digit;
                        digit++;
                    }
                }
                else
                {
                    for (int row = N - 1; row >= 0; row--)
                    {
                        matrix[row, col] = digit;
                        digit++;
                    }
                }
            }

            Console.WriteLine("This is variant B:");
            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    Console.Write("{0,3}", matrix[row, col]);
                }
                Console.WriteLine();
            }
            digit = 1;
            Console.WriteLine();

            // C
            int r = N - 1;
            int c = 0;
            int StartRow = N - 1;
            int StartCol = 0;
            matrix[r, c] = 1;

            while (digit < N * N)
            {
                //First logic
                //Start position
                if (r == (N - 1) && c < (N - 1))
                {
                    StartRow--;
                    StartCol = 0;
                    r = StartRow;       // Row = (N-1), (N-2), (N-N)
                    c = StartCol;       // Col = 0
                    digit++;
                    matrix[r, c] = digit;

                    //down-right movement -> row++; col++; until bottom-right is reached
                    while (r < (N - 1) && c < (N - 1))
                    {
                        r++;    //Move down
                        c++;    //Move right
                        digit++;
                        matrix[r, c] = digit;
                    }
                }
                //Start position, when bottom-right corner reached
                if (r <= (N - 1) && c == (N - 1))
                {
                    StartRow = 0;
                    StartCol++;
                    r = StartRow;   // Row = 0
                    c = StartCol;   // Col = 1,2,3,4...N-1
                    digit++;        // digit = 1,2,3...N*N
                    matrix[r, c] = digit;

                    //down-right movement -> row++; col++; until rightest column is reached. The bottom is not N-1 anymore!
                    while (c < (N - 1))
                    {
                        r++;    //Move down
                        c++;    //Move right
                        digit++;
                        matrix[r, c] = digit;
                    }
                }
            }

            Console.WriteLine("This is variant C:");
            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    Console.Write("{0,3}", matrix[row, col]);
                }
                Console.WriteLine();
            }
            digit = 1;
            Console.WriteLine();

            // D
            
            int activeRow = 0;
            int activeCol = 0;
            int counter = 1;
            int maxRow = N - 1;
            int maxCol = N - 1;

            while (counter <= N * N)
            {
                for (int i = activeRow; i <= maxRow; i++)
                {
                    matrix[i, activeCol] = counter;
                    counter++;
                }
                activeCol++;

                for (int i = activeCol; i <= maxCol; i++)
                {
                    matrix[maxRow, i] = counter;
                    counter++;
                }
                maxRow--;

                for (int i = maxRow; i >= activeRow; i--)
                {
                    matrix[i, maxCol] = counter;
                    counter++;
                }
                maxCol--;

                for (int i = maxCol; i >= activeCol; i--)
                {
                    matrix[activeRow, i] = counter;
                    counter++;
                }
                activeRow++;
            }
          

            Console.WriteLine("This is variant D:");
            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    Console.Write("{0,3}", matrix[row, col]);
                }
                Console.WriteLine();
            }
            digit = 1;
            Console.WriteLine();
        }
    }
}
        
  
               
      
      
        
    

			
			 
			







    






      
  


