using System;



class DividedBy7And5
{
    static void Main()
    {
        Console.Write("Write your number:");
        int number = int.Parse(Console.ReadLine());
        int result1 = number % 5;
        int result2 = number % 7;
        bool division = false;
        Console.WriteLine((result1 == 0 && result2 == 0) ? division = true : division = false);
    }
}