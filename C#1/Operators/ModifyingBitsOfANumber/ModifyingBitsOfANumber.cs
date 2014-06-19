using System;

class ModifyingBitsOfANumber
{
    static void Main()
    {
        Console.Write("Please put your integer number:");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Please put your value 'v' (v=0 or 1)");
        int value = int.Parse(Console.ReadLine());
        Console.Write("Please put your number for the position 'p':");
        int position = int.Parse(Console.ReadLine());

        if (value == 0)
        {
            int mask = ~(1 << position);
            int result = mask & number;
            Console.WriteLine(result);
        }
        else if (value == 1)
        {
            int mask = 1 << position;
            int result = mask | number;
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Your program does not work");
        }
    }
}

