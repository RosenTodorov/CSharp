﻿using System;

class SpiralMatrix
{
    static void Main()
    {
        Console.Write("Enter a positive integer number N (N < 20): ");
        int n = int.Parse(Console.ReadLine());
      
        int[,] matrix = new int[n, n];
        int row = 0;
        int col = 0;
        string direction = "right";
        int maxRange = n * n;


        for (int i = 1; i <= maxRange ; i++)
        {
            if (direction == "right" && (col > n - 1 || matrix[row, col] != 0))
            {
                direction = "down";
                col--;
                row++;
            }
            if (direction == "down" && (row > n - 1 || matrix[row, col] != 0))
            {
                direction = "left";
                row--;
                col--;
            }
            if (direction == "left" && (col < 0 || matrix[row, col] != 0))
            {
                direction = "up";
                col++;
                row--;
            }
            if (direction == "up" && (row < 0 || matrix[row, col] != 0))
            {
                direction = "right";
                row++;
                col++;
            }

            matrix[row, col] = i;

            if (direction == "right")
            {
                col++;
            }
            if (direction == "down")
            {
                row++;
            }
            if (direction == "left")
            {
                col--;
            }
            if (direction == "up")
            {
                row--;
            }
        }
        for (int r = 0; r < n; r++)
        {
            for (int c = 0; c < n; c++)
            {
                Console.Write("{0,4}",matrix[r, c]);
            }
            Console.WriteLine();
        }
    }
}
			 
			
                
           

                
           
                
                
                

                


                


			 
			


          