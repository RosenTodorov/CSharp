using System;

class DevidingFactoriels
{
    static void Main()
    {
        Console.WriteLine("Please enter the numbers N and K where (1<K<N): ");
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        if (n > k && k > 1)
        {
            decimal nFaktorial = 1;
            decimal kFaktorial = 1;

            for (int i = 1; i <= n; i++)
            {
                nFaktorial *= i;
            }

            for (int j = 1; j <= k; j++)
            {
                nFaktorial *= j;
            }
            Console.WriteLine("N!/K! is: {0}", (nFaktorial / kFaktorial));
        }
        else
        {
            Console.WriteLine("Please input valid numbers");
        }
    }
}

        
               

                
			 
			
           