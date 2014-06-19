using System;

class GreatestCommonDivisor
{
    static void Main()
    {
        Console.Write("Please enter the first number to calculate the greatest common divisor (GCD): ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Please enter the second number to calculate the greatest common divisor (GCD): ");
        int secondNumber = int.Parse(Console.ReadLine());


        while (firstNumber != 0 && secondNumber != 0)
        {
            if (firstNumber > secondNumber)
            {
                firstNumber %= secondNumber;
            }
            else
            {
                secondNumber %= firstNumber;
            }
        }
        if (firstNumber == 0)
        {
            Console.WriteLine("The greatest common divisor (GCD) is: {0} ", secondNumber);
        }
        else
        {
            Console.WriteLine("The greatest common divisor (GCD) is: {0} ", firstNumber);
        }
    }
}



               
        

        

