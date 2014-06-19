using System;
using System.Numerics;

class FirstNMembersOfFibonacci
{
    static void Main()
    {
        // Write a program that reads a number N and calculates the sum of the first N members of the sequence
        // of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

        Console.WriteLine("Please enter how many members of the sequence of Fibonacci you want to sum up: ");
        int n = int.Parse(Console.ReadLine());

        BigInteger previousNumber = 0;
        BigInteger actualNumber = 1;
        BigInteger nextNumber;
        BigInteger sum = 1;

        for (int i = 0; i <= n - 3; i++)
        {
            sum = sum + (previousNumber + actualNumber);
            nextNumber = previousNumber;
            previousNumber = actualNumber;
            actualNumber = previousNumber + nextNumber;
        }

        Console.WriteLine("The sum of the first {0} members of the Fibonacci sequance is: {1}", n, sum);
    }
}
    


        
            

           




            