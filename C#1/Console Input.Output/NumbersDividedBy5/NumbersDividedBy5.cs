using System;


namespace NumbersDividedBy5
{
    class NumbersDividedBy5
    {
        static void Main()
        {
            Console.Write("Please enter your first positive integer number:");
            string numberA = Console.ReadLine();
            int a = int.Parse(numberA);

            Console.Write("Please enter your second positive integer number:");
            string numberB = Console.ReadLine();
            int b = int.Parse(numberB);

            if (a < b)
            {
                int count = 0;
                for (int i = a; i <= b; i++)
                {
                    if (i % 5 == 0)
                    {
                      count++;
                        {
                            Console.WriteLine("The numbers count are:" + count);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("The number b is greater than a !");
            }
        }
    }
}
                
     
        
 






 