using System;


class MinAndMaxNumber
{
    static void Main()
    {
        Console.Write("Put how many numbers you want to write: ");
        int n = int.Parse(Console.ReadLine());

        int smallestValue = int.MaxValue; 
        int greatestValue = int.MinValue;

        for (int i = 1; i <= n; i++)
        {
            Console.Write("The numbers that you choose are {0}: ", i);

            int number = int.Parse(Console.ReadLine());

            if (number > greatestValue)
            {
                greatestValue = number;
            }
            if (number < smallestValue)
            {
                smallestValue = number;
            }
        }
        Console.WriteLine("The minimal of the numbers are: {0} ", smallestValue);
        Console.WriteLine("The maximal of the numbers are: {0} ", greatestValue);
    }
}
                


