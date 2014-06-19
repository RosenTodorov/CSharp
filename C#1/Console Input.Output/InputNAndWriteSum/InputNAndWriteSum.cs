using System;

class InputNAndWriteSum
{
    static void Main()
    {
        Console.Write("Plese enter the total number \"n\" for summing:");
        string nSum = Console.ReadLine();
        int n = int.Parse(nSum);

        double sum = 0;
        for (int count = 0; count < n; count++)
        {
            Console.Write("Please enter your number for summing:");
            string xSum = Console.ReadLine();
            double x = double.Parse(xSum);

            sum = sum + x;
        }
        Console.WriteLine("The sum is:" + sum);
    }
}

