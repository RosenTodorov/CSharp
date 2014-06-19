using System;

class DivisbleByThreeAndSeven
{
    static void Main()
    {
        Console.Write("Please put the number \'N': ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i < n; i++)
        {
            if (i % 3 == 0 || i % 7 == 0)
            {
                Console.WriteLine("The numbers which are divisible by 3 or 7 are: {0}", i);
            }
        }
        for (int i = 1; i < n; i++)
        {
            if (i % 3 != 0 && i % 7 != 0)
            {
                Console.WriteLine("The numbers which are not divisible by 3 and 7 are: {0}", i);
            }
        }
    }
}
        
    



