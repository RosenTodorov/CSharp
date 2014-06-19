using System;

class Program
{
    static void Main()
    {
        // Write a program that reads from the console a positive integer number N and outputs a matrix.
        Console.Write("Enter a positive integer number N (N < 20): ");
        int n = int.Parse(Console.ReadLine());
        int number = 1;

        if (n < 20)
        {
            for (int column = 1; column <= n; column++)
            {
                number = column;

                for (int row = 1; row <= n; row++)
                {
                    Console.Write(number);
                    number++;
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("The number is not correct!");
        }
    }
}

        
    


  