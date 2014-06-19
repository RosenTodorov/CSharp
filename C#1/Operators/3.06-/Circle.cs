using System;


class Circle

{
    static void Main()
    {
        Console.Write("Please put the coordinate of x:");
        decimal numberX = decimal.Parse(Console.ReadLine());
        Console.Write("Please put the coordiante of y:");
        decimal numberY = decimal.Parse(Console.ReadLine());
        bool result = (numberX * numberX) + (numberY * numberY) <= 25m;
        if ((numberX * numberX) + (numberY * numberY) <= 25m)
            Console.WriteLine("The point is within circle K(0,5)", result);
        else
            Console.WriteLine("The point is outside circle K(0,5)", result);
    }
}
