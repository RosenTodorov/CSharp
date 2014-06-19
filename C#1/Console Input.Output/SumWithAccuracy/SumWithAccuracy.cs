using System;

class SumWithAccuracy
{
    static void Main()
    {
        decimal count = 2m;
        decimal sum = 1m;
        int sign = 1;

        while((1m / count) > 0.001m)
        {
            sum = sum + (1m / count) * sign;
            sign = sign * (-1);
            count++;
        }
        Console.WriteLine("The sum is {0:0.000}:", sum);
    }
}
