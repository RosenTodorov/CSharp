using System;

class CalucaltingSumXandN
{
    static void Main()
    {
        // Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN

        Console.Write("Please enter the number N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter the number X: ");
        int x = int.Parse(Console.ReadLine());

        decimal sum = 1;
        decimal nFactorial = 1;
        decimal pow = 1;
        
        for (int i = 1; i <= n; i++)
        {
            nFactorial *= i;
            pow = (decimal)Math.Pow(x, i);
            sum += nFactorial / pow;
        }
        Console.WriteLine("The sum of S = 1 + 1!/X + 2!/X2 + … + N!/XN is: {0}", sum);
    }
}



            

			
			
        
        








