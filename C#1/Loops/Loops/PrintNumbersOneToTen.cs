using System;

class Program
    {
        static void Main()
        {
            Console.Write("Please put the number \'N':");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("All the numbers from 1 to N are: {0}", i);
            }
            Console.WriteLine();


            // second way
            int[] array = new int[n];

            for (int i = 1; i <= array.Length; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

