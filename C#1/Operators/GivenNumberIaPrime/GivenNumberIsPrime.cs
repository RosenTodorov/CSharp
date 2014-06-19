using System;




class GivenNumberIsPrime
{
    static void Main()
    {
        Console.Write("Please put your positive number:");
        decimal number = decimal.Parse(Console.ReadLine());
        bool isPrime = ((number % 2 > 0) && (number % 3 > 0) && (number % 5 > 0) && (number % 7 > 0)) || ((number == 2) || (number == 3) || (number == 5) || (number == 7));
        Console.WriteLine(((number % 2 > 0) && (number % 3 > 0) && (number % 5 > 0) && (number % 7 > 0)) || ((number == 2) || (number == 3) || (number == 5) || (number == 7))? "The number is prime" : "The number is not prime");
    }
}

