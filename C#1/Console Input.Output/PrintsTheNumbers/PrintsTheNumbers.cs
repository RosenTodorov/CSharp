using System;

class PrintsTheNumbers
{
    static void Main()
    {
        Console.Write("Please enter your integer number in the interval [1..n]:");
        string intNumber = Console.ReadLine();
        int n = int.Parse(intNumber);

        for (int count = 1; count < n; count++)
        {
            Console.WriteLine(count);
        }
    }
}


