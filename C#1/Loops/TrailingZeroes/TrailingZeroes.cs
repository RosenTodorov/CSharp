using System;
using System.Numerics;

namespace TrailingZeroes
{
    class TrailingZeroes
    {
        static void Main()
        {
            /* Write a program that calculates 
             * for given N how many trailing zeros  
             * present at the end of the number N!*/

            Console.WriteLine("Please input the number \'N':");
            double n = double.Parse(Console.ReadLine());
            double sum = 0;

            BigInteger nFactoriel = 1;

            for (int i = 1; i <= n; i++)
            {
                nFactoriel *= i;
            }
            Console.WriteLine(nFactoriel);

            for (int j = 1; j < n; j++)
            {
                double divider = Math.Pow(5, j);

                if (divider > 5)
                {
                    break;
                }
                else
                sum += (n / divider); 
            }
            Console.WriteLine("The trailing zeros = {0:0}", sum);
        }
    }
}

               
                
			 
		
                
            


            

            
           

