using System;

class IsGreater
{
    static void Main()
    {
        Console.Write("Please put your first number:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Please put your second number:");
        int secondNumber = int.Parse(Console.ReadLine());

        int otherNumber = 0;

        if (firstNumber == secondNumber)
        {
            Console.WriteLine("The numbers are equal");
        }
        else if (firstNumber > secondNumber)
        {

            otherNumber = firstNumber;
            firstNumber = secondNumber;
            secondNumber = otherNumber;

            Console.WriteLine("First number is bigger than the second, so we swap them: firstNumber = {0} and secondNumber = {1}", firstNumber, secondNumber);
        }
        else if (firstNumber < secondNumber)
        {
            Console.WriteLine("The secondNumber is bigger that the firstNumber, no exchange needed.");
        }
    }
}





