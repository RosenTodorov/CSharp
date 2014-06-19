using System;

class CatalanFormula
{
    static void Main()
    {
        // Catalan formula =  (2n)! / (n + 1)! * n!

        Console.Write("Please enter number for N: ");
        int n = int.Parse(Console.ReadLine());

        decimal firstSum = 1;
        decimal secondSum = 1;
        decimal thirdSum = 1;

        if (n > 0)
        {
            for (int i = 1; i <= (2 * n); i++)
            {
                firstSum *= i;
            }
            for (int j = 1; j <= (n + 1); j++)
            {
                secondSum *= j;
            }
            for (int k = 1; k <= n; k++)
            {
                thirdSum *= k;
            }
            Console.WriteLine("The result from (2n)! / (n + 1)! * n! is: {0}/{1}*{2} = {3}", firstSum, secondSum, thirdSum, firstSum / (secondSum * thirdSum));
        }
        else
        {
            Console.WriteLine("Enter a valid number!");
        }
    }
}

      


           

                   

                   

            
		
           
                




            