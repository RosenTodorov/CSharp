using System;


namespace MoreFactoriels
{
    class MoreFactoriels
    {
        static void Main()
        {
            Console.WriteLine("Please enter the numbers N and K where (1<K<N): ");
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            if (n > k && k > 1)
            {

                decimal nFactorial = 1;
                decimal kFactorial = 1;
                decimal resultFactorial = (k - n);

                for (int i = 1; i < n; i++)
                {
                    nFactorial *= i;
                }

                for (int j = 1; j < k; j++)
                {
                    kFactorial *= j;
                }
                for (int q = 1; q < (k - n); q++)
                {
                    resultFactorial *= q;
                    
                }
                Console.WriteLine("N!*K!/(K-N)! {0}", (nFactorial * kFactorial) / resultFactorial);
            }
            else
            {
                Console.WriteLine("Please input valid numbers");
            }
        }
    }
}
   





            
                    
    



               
