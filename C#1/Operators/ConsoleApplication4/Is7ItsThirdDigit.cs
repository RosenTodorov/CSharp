using System;



class Is7ItsThirdDigit
{
    static void Main()
    {
        Console.Write("Input your number:");
        int number = int.Parse(Console.ReadLine());
        int result = number / 100;
        int number3 = result % 10;
        Console.WriteLine((number3 == 7) ? "The result is 7" : "The result is not 7");
    }
}

